using System;

namespace Homework
{
    

    class Battery
    {
        //Enumeration
        public enum BatteryType
        {
            LiIon, NiMH, NiCd
        }

        //Fields
        public string batteryModel;
        public int batteryHoursIdle;
        public int batteryHoursTalk;

        //Constructor
        public Battery(string model, int hoursIdle, int hoursTalk)
        {
            this.batteryModel = model;
            this.batteryHoursIdle = hoursIdle;
            this.batteryHoursTalk = hoursTalk;
        }

        //Properties
        public string BatModel
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; }
        }

        public int BatHoursIdle
        {
            get { return this.batteryHoursIdle; }
            set { this.batteryHoursIdle = value; }
        }

        public int BatHoursTalk
        {
            get { return this.batteryHoursTalk; }
            set { this.batteryHoursTalk = value; }
        }
    }
}
