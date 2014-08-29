using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSMProgramVersionTwo.Data;

namespace GSMProgramVersionTwo
{
    class GSMTest
    {
        public static GSM gsm = new GSM();
        public static GSM secondGSM;
        public static Display display;
        public static Battery battery;
        public static List<GSM> listGSM = new List<GSM>();

        //static void Main(string[] args)
        //{
        //    Console.Write("Number of phones: ");
        //    int numberOfPhones = int.Parse(Console.ReadLine());
        //    Console.Clear();
        //    Loop(numberOfPhones);
        //    ShowInfo();

        //    Console.WriteLine(GSM.IPhone4s());
        //}

        static void Loop(int numberOfPhones)
        {
            for (int i = 1; i <= numberOfPhones; i++)
            {
                Console.WriteLine("Phone " + i);
                listGSM.Add(CreateGSM());
            }
        }

        static void ShowInfo()
        {
            foreach (var item in listGSM)
            {
                Console.WriteLine(item.ToString());
                Console.Write("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
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

        //static void CreateBatteryType()
        //{
        //    int type = 0;

        //    Console.WriteLine("---Battery type INFO---");
        //    do
        //    {
        //        Console.WriteLine("1. Li-Ion");
        //        Console.WriteLine("2. NiMH");
        //        Console.WriteLine("3. NiCd");
        //        Console.WriteLine("4. Li-Poly");
        //        Console.Write("Battery type: ");
        //        type = int.Parse(Console.ReadLine());
        //    } while(type < 1 || type > 4);

        //    switch (type)
        //    {
        //        case 1:
        //            gsm.BatteryType = BatteryType.LiIon;
        //            break;
        //        case 2:
        //            gsm.BatteryType = BatteryType.NiMH;
        //            break;
        //        case 3:
        //            gsm.BatteryType = BatteryType.NiCd;
        //            break;
        //        case 4:
        //            gsm.BatteryType = BatteryType.LiPoly;
        //            break;
        //    }

        //    Console.Clear();
        //}
    }
}
