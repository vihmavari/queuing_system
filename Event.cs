using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_SMO
{
    public enum Type
    {
        GENERATION,
        INSERTION,
        EXTRACTION,
        RELEASE
    }

    public class Event :IComparable
    {
        public Type type;
        public int deviceId;
        public int clientId;
        public double currentTime;
        public Request request;

        // Type.GENERATION, currentTime, clientId
        public Event(Type type, double currentTime, int clientId)
        {
            Clear();
            this.type = type;
            this.currentTime = currentTime;
            this.clientId = clientId;
        }

        // Type.INSERTION, request
        public Event(Type type, Request request)
        {
            Clear();
            this.type = type;
            this.request = request;
            currentTime = request.GetBorningTime();
            clientId = request.GetClient();
        }

        // Type.EXTRACTION, currentTime
        public Event(Type type, double currentTime)
        {
            Clear();
            this.type = type;
            this.currentTime = currentTime;
        }

        //Type.RELEASE, deviceId, currnetTime
        public Event(Type type, int deviceId, double currentTime)
        {
            Clear();
            this.type = type;
            this.currentTime = currentTime;
            this.deviceId= deviceId;
        }

        public int CompareTo(object obj)
        {
            Event e = obj as Event;
            
            if (e != null)
            {
                if (this.currentTime < e.currentTime)
                {
                    return -1;
                }
                else if (this.currentTime > e.currentTime)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new Exception("Параметр не Event!");
            }
        }

        private void Clear()
        {
            deviceId = 0;
            clientId = 0;
            currentTime = 0;
            request = null;
        }
    }
}
