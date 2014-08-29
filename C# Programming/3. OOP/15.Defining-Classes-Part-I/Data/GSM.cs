namespace GSMProgramVersionTwo.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;


    class GSM
    {
        private string model;
        private string manufacturer;
        private float price;
        private string owner;
        private Display display;
        private Battery battery;
        private List<Call> callHistory = new List<Call>();

        public GSM()
        {
            this.model = "";
            this.manufacturer = "";
            this.price = float.MinValue;
            this.owner = "";
        }

        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, float price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }

        public GSM(string model, string manufacturer, float price, string owner, Display display, Battery battery)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.display = display;
            this.battery = battery;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Model must be filled.");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Manufacturer must be filled.");
                }
                this.manufacturer = value;
            }
        }

        public float Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price can't be under $0.");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Owner must be filled.");
                }
                this.owner = value;
            }
        }

        static string IPhone4S
        {
            get { return IPhone4s(); }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }    
        }

        public static string IPhone4s()
        {
            string model = "4S";
            string manufacturer = "Apple";
            float price = 300f;
            string owner = "Steve Jobs";
            float size = 3.5f;
            long numberOfColors = 16000000;
            string batteryModel = "BL4D";
            int hoursIdle = 200;
            int hoursTalk = 8;
            BatteryType bt = BatteryType.LiIon;
            Display display = new Display(size, numberOfColors);
            Battery battery = new Battery(batteryModel, hoursIdle, hoursTalk, bt);
            GSM gsm = new GSM(model, manufacturer, price, owner, display, battery);
            return gsm.ToString();
        }

        public void AddCall()
        {
            Console.Write("Date: ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Time: ");
            DateTime time = DateTime.ParseExact(Console.ReadLine(), "HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Dialed phone number: ");
            string dialedPhoneNumber = Console.ReadLine();
            Console.Write("Duration: ");
            double duration = double.Parse(Console.ReadLine());
            this.CallHistory.Add(new Call(date, time, dialedPhoneNumber, duration));
            Console.Clear();
        }

        public void DeleteCall(DateTime date, DateTime time, string dialedPhoneNumber, double duration)
        {
            Call call = new Call(date, time, dialedPhoneNumber, duration);
            this.CallHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public void TotalPriceOfCalls()
        {
            double totalPrice = 0;
            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                if (this.CallHistory[i].Duration > 59)
                {
                    totalPrice += (this.CallHistory[i].Duration / 60) / 0.37;
                }
                else
                {
                    totalPrice += this.CallHistory[i].Duration * 0.37;
                }
            }
            Console.WriteLine("Total price for all calls are: ${0:F2}", totalPrice);
        }
        public override string ToString()
        {
            string result = "Model: " + this.model;
            result += "\nManufacturer: " + this.manufacturer;
            result += "\nPrice: " + this.price;
            result += "\nOwner: " + this.price;
            result += this.display.ToString();
            result += this.battery.ToString();
            return result;
        }
    }
}
