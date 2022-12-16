using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_SMO
{
    public class CustomerQueue
    {
        private int customerQueueId;
        private int requestNumber;
        public Statistics statistics;

        public CustomerQueue(int customerQueueId)
        {
            this.customerQueueId = customerQueueId;
            statistics = new Statistics();
            requestNumber = 0;
        }

        public Request GenerateRequest(double currentTime)
        {
            requestNumber++;
            return new Request(currentTime, requestNumber, customerQueueId, -1);
        }

        //пуассон
        public double GetNextRequestGenerationTime()
        {
            double lambda = Input.lambda;

            Random rnd = new Random();
            double rndDouble = rnd.NextDouble();
            return (-1.0 / lambda) * Math.Log(rndDouble);
        }
    }
}
