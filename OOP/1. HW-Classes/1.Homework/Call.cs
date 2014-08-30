using System;

namespace Homework
{
    class Call
    {
        //Fields
        private DateTime dateAndTime;
        private string dialedPhone;
        private int duration;

        //Constructor
        public Call(DateTime dateAndTime, string dialedPhone, int duration)
        {
            this.dateAndTime = dateAndTime;
            this.dialedPhone = dialedPhone;
            this.duration = duration;
        }

        //Properties
        public DateTime DateAndTime
        {
            get { return this.dateAndTime; }
            set { this.dateAndTime = value; }
        }

        public string DialedPhone
        {
            get { return this.dialedPhone; }
            set { this.dialedPhone = value; }
        }

        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
    }
}
