using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSMProgramVersionTwo.Data;

namespace GSMProgramVersionTwo
{
    class GSMCallHistoryTest
    {
        public static GSM gsm = new GSM();
        public static Display display;
        public static Battery battery;

        static void Main(string[] args)
        {
            gsm = CreateGSM();
            Console.Write("Number of calls: ");
            int numberOfCalls = int.Parse(Console.ReadLine());
            gsm = AddCalls(gsm, numberOfCalls);
            CallsInfo(gsm);
            TotalPriceOfCalls(gsm);
            gsm = DeleteLongCall(gsm);
            TotalPriceOfCalls(gsm);
            gsm.ClearCallHistory();
            CallsInfo(gsm);
        }

        static GSM AddCalls(GSM gsmTwo, int numberOfCalls)
        {
            for (int i = 1; i <= numberOfCalls; i++)
            {
                gsmTwo.AddCall();
            }
            return gsmTwo;
        }

        static void CallsInfo(GSM gsmTwo)
        {
            foreach (var call in gsmTwo.CallHistory)
            {
                Console.WriteLine(call.ToString());
            }
        }

        static GSM DeleteLongCall(GSM gsmTwo)
        {
            double longestDuration = double.MinValue;
            
            for (int i = 0; i < gsmTwo.CallHistory.Count; i++)
            {
                if (gsmTwo.CallHistory[i].Duration > longestDuration)
                {
                    longestDuration = gsmTwo.CallHistory[i].Duration;
                }
            }
            for (int i = 0; i < gsmTwo.CallHistory.Count; i++)
            {
                if (gsmTwo.CallHistory[i].Duration == longestDuration)
                {
                    gsmTwo.CallHistory.RemoveAt(i);
                }
            }
            return gsmTwo;
        }

        static void TotalPriceOfCalls(GSM gsmTwo)
        {
            double totalPrice = 0;
            for (int i = 0; i < gsmTwo.CallHistory.Count; i++)
            {
                if (gsmTwo.CallHistory[i].Duration > 59)
                {
                    totalPrice += (gsmTwo.CallHistory[i].Duration / 60) * 0.37;
                }
                else
                {
                    totalPrice += gsmTwo.CallHistory[i].Duration * 0.37;
                }
            }
            Console.WriteLine("Total price for all calls are: ${0:F2}", totalPrice);
        }
        

        static GSM CreateGSM()
        {

            Console.WriteLine("---GSM INFO---");
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Manufacturer: ");
            string manufacturer = Console.ReadLine();
            Console.Write("Price: ");
            float price = float.Parse(Console.ReadLine());
            Console.Write("Owner: ");
            string owner = Console.ReadLine();

            Console.Clear();
            //CreateBatteryType();
            display = CreateDisplay();
            battery = CreateBattery();
            gsm = new GSM(model, manufacturer, price, owner, display, battery);
            return gsm;
        }

        static Display CreateDisplay()
        {
            Console.WriteLine("---Display INFO---");
            Console.Write("Size: ");
            float size = float.Parse(Console.ReadLine());
            Console.Write("Number of colors: ");
            long numberOfColors = long.Parse(Console.ReadLine());


            Console.Clear();

            display = new Display(size, numberOfColors);
            return display;
        }

        static Battery CreateBattery()
        {
            Console.WriteLine("---Battery INFO---");
            Console.Write("Model: ");
            string batteryModel = Console.ReadLine();
            Console.Write("Hours idle: ");
            int hoursIdle = int.Parse(Console.ReadLine());
            Console.Write("Hours talk: ");
            int hoursTalk = int.Parse(Console.ReadLine());

            Console.Clear();
            int type = 0;

            Console.WriteLine("---Battery type INFO---");
            do
            {
                Console.WriteLine("1. Li-Ion");
                Console.WriteLine("2. NiMH");
                Console.WriteLine("3. NiCd");
                Console.WriteLine("4. Li-Poly");
                Console.Write("Battery type: ");
                type = int.Parse(Console.ReadLine());
            } while (type < 1 || type > 4);

            BatteryType bt = new BatteryType();

            switch (type)
            {
                case 1:
                    bt = BatteryType.LiIon;
                    break;
                case 2:
                    bt = BatteryType.NiMH;
                    break;
                case 3:
                    bt = BatteryType.NiCd;
                    break;
                case 4:
                    bt = BatteryType.LiPoly;
                    break;
            }

            Console.Clear();

            battery = new Battery(batteryModel, hoursIdle, hoursTalk, bt);
            return battery;
        }

    }
}
