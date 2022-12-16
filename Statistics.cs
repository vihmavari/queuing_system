using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_SMO
{
    public class Statistics
    {
        public int generatedRequestsCounter;
        public int completedtedRequestsCounter;
        public int refusedRequestsCounter;
        public double totalTime;
        public double squaredTotalTime;
        public double totalBufferedTime;
        public double squaredTotalBufferedTime;
        public double totalInWorkTime;
        public double squaredTotalInWorkTime;
        public double bufferDispersion;
        public double deviceDispersion;

        public Statistics()
        {
            Clear();
        }

        public void incrementGeneratedRequest()
        {
            generatedRequestsCounter++;
        }

        public void incrementRefusedRequest()
        {
            refusedRequestsCounter++;
        }

        public void incrementCompletedRequest()
        {
            completedtedRequestsCounter++;
        }

        public void addTime(double time)
        {
            totalTime += time;
            squaredTotalTime += time * time;
        }

        public void addBufferedTime(double time)
        {
            totalBufferedTime += time;
            squaredTotalBufferedTime += time * time;
        }

        public void addTimeInWork(double time)
        {
            totalInWorkTime += time;
            squaredTotalInWorkTime += time * time;
        }

        public double getBufferDispersion()
        {
            return (Convert.ToDouble(squaredTotalBufferedTime) / generatedRequestsCounter - Math.Pow(totalBufferedTime / generatedRequestsCounter, 2));
        }

        public double getDeviceDispersion()
        {
            return (Convert.ToDouble(squaredTotalInWorkTime) / completedtedRequestsCounter - Math.Pow(totalInWorkTime / completedtedRequestsCounter, 2));
        }

        public void Clear()
        {
            generatedRequestsCounter = 0;
            completedtedRequestsCounter = 0;
            refusedRequestsCounter = 0;
            totalTime = 0;
            totalBufferedTime = 0;
            totalInWorkTime = 0;
            bufferDispersion = 0;
            deviceDispersion = 0;
        }

    }
}


