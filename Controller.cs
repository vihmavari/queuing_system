using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CW_SMO
{
    public class Controller
    {
        private InsertionManager insertionManager;
        private ExtractionManager extractionManager;

        public Controller()
        {
            insertionManager = new InsertionManager();
            extractionManager = new ExtractionManager();
        }

        public void autoMode()
        {
            while (Input.events.Count != 0)
            {
                stepMode();
            }
        }

        public Event stepMode()
        {
            if (Input.events.Count == 0)
                return null;

            Event currentEvent = Input.events.First();
            Input.events.RemoveAt(0);

            General.time = currentEvent.currentTime;

            Type type = currentEvent.type;
            int clientId = currentEvent.clientId;
            int deviceId = currentEvent.deviceId;                
            Request request = currentEvent.request;

            Event newEvent;
            double nextTime;

            if (type == Type.GENERATION)
            {
                if (General.countAllRequest < Input.countRequests)
                {
                    // генерация реквеста
                    request = Input.customersQueue[clientId].GenerateRequest(General.time);
                    Input.customersQueue[clientId].statistics.incrementGeneratedRequest();
                    General.countAllRequest++;
                    General.lastGeneratedInfo = request.GetInfo();

                    // создание ивента вставки в буффер
                    newEvent = new Event(Type.INSERTION, request);
                    Input.events.Add(newEvent);

                    // создание ивента новой генерации
                    nextTime = General.time + Input.customersQueue[clientId].GetNextRequestGenerationTime();
                    newEvent = new Event(Type.GENERATION, nextTime, clientId);
                    Input.events.Add(newEvent);
                    
                    // сотировка ивентов
                    Input.events.Sort();
                }
            }            
            else if (type == Type.INSERTION)
            {
                // вставка реквеста в буффер
                insertionManager.putRequest(request);

                // создание ивента выбора реквеста на девайс
                newEvent = new Event(Type.EXTRACTION, request);
                Input.events.Add(newEvent);

                // сотировка ивентов
                Input.events.Sort();

                currentEvent.request = request;
            }
            else if (type == Type.EXTRACTION)
            {
                if (extractionManager.IsAnyFree() && (Input.oldElement() != -1))
                {
                    // отправка реквеста из буффера на устройство
                    request = extractionManager.getRequest();

                    nextTime = request.GetOnDeviceTime();

                    // создание ивента исполнения реквеста
                    newEvent = new Event(Type.RELEASE, extractionManager.GetDevicePointer(), nextTime);
                    Input.events.Add(newEvent);

                    // сотировка ивентов
                    Input.events.Sort();

                    currentEvent.request = request;
                    currentEvent.deviceId = extractionManager.GetDevicePointer();
                }
                else
                {
                    currentEvent.request = null;
                    currentEvent.deviceId = -1;
                }

            }
            else if (type == Type.RELEASE)
            {
                Input.cashRegisters[deviceId].Release(General.time);

                // создание ивента выбора реквеста на девайс
                newEvent = new Event(Type.EXTRACTION, General.time);
                Input.events.Add(newEvent);

                // сотировка ивентов
                Input.events.Sort();
            }
            return currentEvent;
        }
    }
}
