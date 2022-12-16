using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_SMO
{
    public class InsertionManager
    {
        public InsertionManager() {  }

        public Request deleteRequest(int id)
        {
            // сохраняем данные об удаляемом реквесте
            Request temp = Input.buffer[id];

            // удаление из буффера
            Input.buffer[id] = new Request(-1, -1, -1, id);

            //переменные для статистики
            int clientId = temp.GetClient();
            double allTime = General.time - temp.GetBorningTime();
            
            // статистика
            Input.customersQueue[clientId].statistics.incrementRefusedRequest();
            Input.customersQueue[clientId].statistics.addTime(allTime);
            Input.customersQueue[clientId].statistics.addBufferedTime(allTime);

            General.lastDeletedInfo = temp.GetInfo();
            
            return temp;
        } 

        public int putRequest(Request request)
        {
            int id = -1;
            int maxOrder = -1;
            
            // поиск максимального значения порядка среди всех ячеек
            foreach (Request r in Input.buffer)
            {
                if (r.GetOrder() > maxOrder)
                {
                    maxOrder = r.GetOrder();
                    id = r.GetId();
                }
            }            
            
            // освобождаем ячейку с максимальным допустимым порядком (при её наличии)
            if (maxOrder == Input.bufferSize)
            {
                deleteRequest(id);
            }

            // ищем ячейку в буфере, у которой не установлен порядок (не занятая ячейка)
            foreach (Request r in Input.buffer)
            {
                if (r.GetOrder() == -1)
                {
                    id = r.GetId();
                    break;
                }
            }
            // инкрементируем порядок всех занятых ячеек
            Input.incOrder(1);

            // устанавливаем нашему реквесту id ячейки и порядок
            request.SetId(id);
            request.SetOrder(1);
            
            // занимаем ячейку с индексом id нашим реквестом
            Input.buffer[id] = request;

            return id;
        }        
    }
}
