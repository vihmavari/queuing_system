using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_SMO
{
    public class ExtractionManager
    {

        int devicePointer;

        public ExtractionManager()
        {
            devicePointer = 0;
        }

        public int GetDevicePointer() { return devicePointer; }

        public bool IsAnyFree()
        {
            foreach (CashRegister cr in Input.cashRegisters)
            {
                if (cr.IsFree())
                {
                    return true;
                }
            }
            return false;
        }

        public Request getRequest()
        {
            // начинаем поиск свободного девайса по кольцу
            int beginPointer = devicePointer;

            LinkedList<CashRegister> freeLeftCashRegisters = new LinkedList<CashRegister>();
            LinkedList<CashRegister> freeRightCashRegisters = new LinkedList<CashRegister>();
            foreach (CashRegister device in Input.cashRegisters)
            {
                if (device.IsFree())
                {
                    if (device.GetDeviceId() >= beginPointer)
                    {
                        freeRightCashRegisters.AddLast(device);
                    }
                    else
                    {
                        freeLeftCashRegisters.AddLast(device);
                    }
                }
            }

            // если не нашлось свободного девайса с обеих сторон ИЛИ буффер пуст, то выход
            if ((freeRightCashRegisters.Count == 0 && freeLeftCashRegisters.Count == 0) || Input.oldElement() == -1)
            {
                return null;
            }

            int min = Input.countRegisters + 100;
            
            // ищем свободный девайс с минимальным индексом, если есть справа, иначе слева
            if (freeRightCashRegisters.Count != 0)
            {
                foreach (CashRegister cr in freeRightCashRegisters)
                {
                    if (min > cr.GetDeviceId())
                    {
                        min = cr.GetDeviceId();
                    }
                }
            }
            else
            {
                foreach (CashRegister cr in freeLeftCashRegisters)
                {
                    if (min > cr.GetDeviceId())
                    {
                        min = cr.GetDeviceId();
                    }
                }
            }

            // устанавливаем значение указателя, на котором мы остановились (первый свободный девайс по кольцу)
            devicePointer = min;

            // пакет реквестов
            List<Request> pack = Input.pack();
            
            Request request = new Request(-1, -1, -1, -1);

            // если в пакете есть реквесты
            if (pack.Count != 0)
            {
                request = pack.First();
            }
            // если в пакете нет реквестов
            else
            {
                // приоритет по номеру источника
                int tempMinClientId = Input.countClients + 2;
                foreach (Request r in Input.buffer)
                {
                    if(r.GetClient() != -1 && r.GetClient() < tempMinClientId)
                    {
                        tempMinClientId = r.GetClient();
                    }
                }
                int tempMinRequestNumber = Input.countRequests;
                foreach (Request r in Input.buffer)
                {
                    if (r.GetClient() == tempMinClientId && r.GetNumber() < tempMinRequestNumber)
                    {
                        tempMinRequestNumber = r.GetNumber();
                        request = r;
                    }
                }
            }

            //удаление реквеста из буффера
            if (request.GetId() != -1)
            {
                Input.buffer[request.GetId()] = new Request(-1, -1, -1, request.GetId());
            }
            else
            {
                return null;
            }

            // передача реквеста на девайс
            foreach (CashRegister device in Input.cashRegisters)
            {
                if (device.GetDeviceId() == devicePointer)
                {
                    device.SetRequest(request);
                }
            }

            // декрементируем порядок всех занятых ячеек буфера с порядком больше порядка переданного реквеста
            int reqOrder = request.GetOrder();
            foreach (Request r in Input.buffer)
            {
                if (r.GetOrder() > reqOrder)
                {
                    r.SetOrder(r.GetOrder() - 1);
                }
            }

            double timeRelease = General.time + Input.cashRegisters[devicePointer].GetReleaseTime();

            request.SetOnDeviceTime(timeRelease);

            //переменные для статистики
            int clientId = request.GetClient();
            double bufferedTime = General.time - request.GetBorningTime();

            // статистика
            Input.customersQueue[clientId].statistics.addBufferedTime(bufferedTime);

            return request;
        }
    }
}
