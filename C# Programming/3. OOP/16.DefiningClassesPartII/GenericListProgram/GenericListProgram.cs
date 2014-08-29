using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericListProgram.Data;

namespace GenericListProgram
{
    class GenericListProgram
    {
        static void Main(string[] args)
        {
            try
            {
                //Creating new list
                GenericList<int> intList = new GenericList<int>(20);

                //Overfill his capacity to make him auto grow
                int maxCapacity = intList.Capacity;
                for (int i = 1; i < maxCapacity * 2; i++)
                {
                    intList.Add(i);
                }

                //Access elemtn by index
                Console.WriteLine(intList[9]);

                //Remove from index
                intList.RemoveAtIndex(9);

                //Insert new element at this position
                intList.InsertAtPosition(9, 100);

                //Look by value if the element is at this position
                Console.WriteLine(intList.FindByValue(100));

                //Find Min and Max value
                Console.WriteLine(intList.Min());
                Console.WriteLine(intList.Max());

                //Use overriden method ToString()
                Console.WriteLine(intList.ToString());

                //Clear list
                intList.Clear();

                //And print again whith ToString()
                Console.WriteLine(intList.ToString());






            }
            catch (Exception e)
            {

                Console.WriteLine("Error!" + e.Message);
            }
        }
    }
}
