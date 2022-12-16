using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_SMO
{
    public class Request : IComparable
    {
        private double borningTime;
        private double onDeviceTime;

        private string info;
        private int number;
        private int client;
        private int order;
        private int id;
        private bool inPackage;

        public Request(double borningTime, int number, int client, int id)
        {
            this.borningTime = borningTime;
            this.number = number;
            this.client = client;
            this.id = id;
            order = -1;
            onDeviceTime = 0;

            info = client.ToString() + '-' + number.ToString();
            inPackage = false;
        }

        public void SetBorningTime(double currentTime) { borningTime = currentTime; }
        public double GetBorningTime() { return borningTime; }
        public void SetOnDeviceTime(double currentTime) { onDeviceTime = currentTime; }
        public double GetOnDeviceTime() { return onDeviceTime; }
        public string GetInfo() { return info; }
        public int GetNumber() { return number; }
        public int GetClient() { return client; }
        public void SetOrder(int order) { this.order = order; }
        public int GetOrder() { return order; }
        public void SetId(int id) { this.id = id; }
        public int GetId() { return id; }
        public bool IsInPackage() { return inPackage; }
        public void putInPackage() { inPackage = true; }

        public int CompareTo(object obj)
        {
            Request r = obj as Request;

            if (r != null)
            {
                if (this.GetNumber() < r.GetNumber())
                {
                    return -1;
                }
                else if (this.GetNumber() > r.GetNumber())
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
                throw new Exception("Параметр не Request!");
            }
        }
    }
}
