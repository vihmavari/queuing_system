using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_SMO
{
    public class Input
    {
        public static int countRegisters;
        public static int countClients;
        public static int countRequests;
        public static int bufferSize;
        public static Request[] buffer;
        public static int indexOld;
        public static CustomerQueue[] customersQueue;
        public static CashRegister[] cashRegisters;
        public static double min;
        public static double max;
        public static double lambda;
        public static List<Event> events;

        public Input(int countRegisters,
                     int countClients,
                     int countRequests,
                     int bufferSize,
                     double min,
                     double max,
                     double lambda)
        {
            Input.countRegisters = countRegisters;
            Input.countClients = countClients;
            Input.countRequests = countRequests;
            Input.bufferSize = bufferSize;
            Input.min = min;
            Input.max = max;
            Input.lambda = lambda;

            General.countAllRequest = 0;
            General.time = 0;

            indexOld = 0;
            buffer = new Request[Input.bufferSize];
            for (int i = 0; i < bufferSize; ++i)
            {
                buffer[i] = new Request(-1, -1, -1, i);
            }

            customersQueue = new CustomerQueue[countClients];
            for (int i = 0; i < countClients; ++i)
            {
                customersQueue[i] = new CustomerQueue(i);
            }

            cashRegisters = new CashRegister[countRegisters];
            for (int i = 0; i < countRegisters; ++i)
            {
                cashRegisters[i] = new CashRegister(i);
            }

            initEvents();
        }

        public static int freeRegister()
        {
            foreach (CashRegister cr in cashRegisters)
            {
                if (cr.IsFree())
                {
                    return cr.GetDeviceId();
                }
            }
            return -1;
        }

        public static int freeBuffer()
        {
            foreach(Request r in buffer)
            {
                if (r.GetBorningTime() == -1)
                {
                    return r.GetId();
                }
            }
            return -1;
        }

        public static int oldElement()
        {
            int order = -1;
            int id = -1;
            foreach (Request r in buffer)
            {
                if (r.GetOrder() > order)
                {
                    order = r.GetOrder();
                    id = r.GetId();
                }
            }
            if (order != -1)
            {
                indexOld = id;
            }
            return id;
        }
        
        public static void incOrder(int i)
        {
            foreach(Request r in buffer)
            {
                if (r.GetOrder() != -1)
                {
                    r.SetOrder(r.GetOrder() + i);
                }
            }
        }

        public static void setPackage(int clientId)
        {
            foreach (Request r in buffer)
            {
                if (r.GetClient() == clientId)
                {
                    r.putInPackage();
                }
            }
        }

        public static List<Request> pack()
        {
            List<Request> package = new List<Request>();
            foreach (Request r in buffer)
            {
                if (r.IsInPackage())
                {
                    package.Add(r);
                }
            }
            package.Sort();
            return package;
        }

        private void initEvents()
        {
            events = new List<Event>();
            for (int i = 0; i < countClients; i++)
            {
                events.Add(new Event(Type.GENERATION, customersQueue[i].GetNextRequestGenerationTime(), i));
                System.Threading.Thread.Sleep(10);
            }
            events.Sort();
        }
    }
}
