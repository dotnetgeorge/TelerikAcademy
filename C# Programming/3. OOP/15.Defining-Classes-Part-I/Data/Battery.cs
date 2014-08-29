namespace GSMProgramVersionTwo.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public enum BatteryType
    {
        LiIon = 1,
        NiMH = 2,
        NiCd = 3,
        LiPoly = 4
    }

    class Battery
    {
        private string batteryModel;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType batteryType;

        public Battery()
        {
            this.batteryModel = "";
            this.hoursIdle = int.MinValue;
            this.hoursTalk = int.MinValue;
        }

        public Battery(string batteryModel, int hoursIdle, int hoursTalk)
        {
            this.batteryModel = batteryModel;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        public Battery(string batteryModel, int hoursIdle, int hoursTalk, BatteryType batteryType)
        {
            this.batteryModel = batteryModel;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = batteryType;
        }

        public string BatteryModel
        {
            get { return this.batteryModel; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Battery model must be filled.");
                }
                this.batteryModel = value;
            }
        }

        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Hours of idle can't be under 1.");
                }
                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Hours of talk can't be under 1.");
                }
                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }

        public override string ToString()
        {
            string result = "\nBattery Model: " + this.batteryModel;
            result += "\nHours idle: " + this.hoursIdle;
            result += "\nHours talk: " + this.hoursTalk;
            result += "\nBattery type: " + this.batteryType;
            return result;
        }
    }
}
