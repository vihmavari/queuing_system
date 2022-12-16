using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CW_SMO
{
    public class CashRegister
    {
        private int deviceId;
        private Request request;

        public double statTime;

        private double requestStartTime;

        public CashRegister(int deviceId)
        {
            this.deviceId = deviceId;
            requestStartTime = 0;
            request = null;
        }

        public void addTime(double time)
        {
            statTime += time;
        }

        //равномерный закон
        public double GetReleaseTime()
        {
            Random rand = new Random();

            double r = Input.min + rand.NextDouble() * (Input.max - Input.min);

            addTime(r);
            Input.customersQueue[request.GetClient()].statistics.addTimeInWork(r);
            Input.customersQueue[request.GetClient()].statistics.incrementCompletedRequest();
            Input.customersQueue[request.GetClient()].statistics.addTime(r);

            return r;
        }

        internal void SetRequest(Request request)
        {
            this.request = request;
        }

        public bool IsFree()
        {
            return (request == null);
        }

        internal void SetRequestStartTime(double time)
        {
            this.requestStartTime = time;
        }

        internal int GetDeviceId()
        {
            return deviceId;
        }

        public void Release(double currentTime)
        {
            if (request != null)
            {
                List<Request> package = Input.pack();

                if(package.Count == 0)
                {
                    int min = Input.countClients + 100;
                    foreach (Request r in Input.buffer)
                    {
                        if (min > r.GetClient() && r.GetClient() >= 0)
                        {
                            min = r.GetClient();
                        }
                    }
                    if (min != Input.countClients + 100)
                    {
                        Input.setPackage(min);

                    }
                }
                request = null;
                requestStartTime = currentTime;
            }
        }

        internal Request GetRequest()
        {
            return request;
        }
    }
}
