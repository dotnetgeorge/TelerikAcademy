namespace GSMProgramVersionTwo.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Call : GSM
    {
        private DateTime date;
        private DateTime time;
        private string dialedPhoneNumber;
        private double duration;

        public Call()
        {
            this.date = new DateTime(2000, 1, 1);
            this.time = new DateTime(2000, 1, 1, 1, 1, 1);
            this.dialedPhoneNumber = "";
            this.duration = 1.0;
        }

        public Call(DateTime date, DateTime time, string dialedPhoneNumber, double duration)
        {
            this.date = date;
            this.time = time;
            this.dialedPhoneNumber = dialedPhoneNumber;
            this.duration = duration;
        }

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public DateTime Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

        public string DialedPhoneNumber
        {
            get { return this.dialedPhoneNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Dialed phone number must be filled.");
                }
                this.dialedPhoneNumber = value;
            }
        }

        public double Duration
        {
            get { return this.duration; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Invalid duration!");
                }
                this.duration = value;

            }
        }

        public override string ToString()
        {
            string result = "";
            if (this.CallHistory.Count == 0)
            {
                Console.WriteLine("Call history is empty.");
            }
            else
            {
                result = "Date: " + this.date.Day + "/" + this.date.Month + "/" + this.date.Year;
                result += "\nTime: " + this.time.Hour + ":" + this.time.Minute;
                result += "\nDialed phone number: " + this.dialedPhoneNumber;
                result += "\nDuration: " + this.duration;
            }
            return result;
        }
    }
}
