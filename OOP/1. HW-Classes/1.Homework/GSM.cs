using System;
using System.Collections.Generic;

namespace Homework
{
    class GSM
    {
        //Fields
        private string gsmModel;
        private string gsmManufacterer;
        private double gsmPrice;
        private string gsmOwner;
        public static GSM iPhone4S;

        //Constructor
        public GSM(string model, string manufacterer, double price, string owner)
        {
            this.gsmModel = model;
            this.gsmManufacterer = manufacterer;
            this.gsmPrice = price;
            this.gsmOwner = owner;
        }

        //Static instance of GSM
        static GSM()
        {
            iPhone4S = new GSM("iPhone 4S", "Apple", 722.0, "Mihail");
        }

        //Properties
        public string GSMModel
        {
            get { return this.gsmModel; }
            set { this.gsmModel = value; }
        }

        public string GSMManufacterer
        {
            get { return this.gsmManufacterer; }
            set { this.gsmManufacterer = value; }
        }

        public double GSMPrice
        {
            get { return this.gsmPrice; }
            set { this.gsmPrice = value; }
        }

        public string GSMOwner
        {
            get { return this.gsmOwner; }
            set { this.gsmOwner = value; }
        }

        //Override method
        public override string ToString()
        {
            Console.WriteLine("-----GSM-----");
            Console.WriteLine("GSM Model: {0}", this.gsmModel);
            Console.WriteLine("GSM Manufacterer: {0}", this.gsmManufacterer);
            Console.WriteLine("GSM Price: {0}", this.gsmPrice);
            Console.WriteLine("GSM Owner: {0}", this.gsmOwner);
            Console.WriteLine();
            return base.ToString();
        }

        //Call stuff
        public List<Call> CallHistory = new List<Call>();

        public void AddCall(DateTime dateAndTime, string dialedPhone, int duration)
        {
            Call call = new Call(dateAndTime, dialedPhone, duration);
            CallHistory.Add(call);
        }

        public void DeleteCalls(int duration)
        {
            for (int i = 0; i < CallHistory.Count; i++)
            {
                if (CallHistory[i].Duration == duration)
                {
                    CallHistory.RemoveAt(i);
                    i--;
                }
            }
        }

        public void ClearCallHistory()
        {
            CallHistory.Clear();
        }

        public void PrintCalls()
        {
            for (int i = 0; i < CallHistory.Count; i++)
            {
                Console.WriteLine("---------- Calls ----------");
                Console.WriteLine("Date and Time: " + CallHistory[i].DateAndTime);
                Console.WriteLine("Dialed phone number: " + CallHistory[i].DialedPhone);
                Console.WriteLine("Duration: {0} seconds ", CallHistory[i].Duration);
                Console.WriteLine();
            }
        }

        public void CalculateTotalPrice(double pricePerMinute)
        {
            double wholeTime = 0;
            for (int i = 0; i < CallHistory.Count; i++)
            {
                wholeTime += CallHistory[i].Duration;
            }

            double price = pricePerMinute * (Math.Ceiling(wholeTime / 60));
            Console.WriteLine("Total price: " + price);
            Console.WriteLine();
        }
    }
}
