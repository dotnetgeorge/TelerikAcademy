/*
 * Define a class BitArray64 to hold 64 bit values inside an ulong value. 
 * Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitArray64Program.Data;

namespace BitArray64Program
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray64 arr = new BitArray64(5);
            arr.Add(18446744073709551615);
            arr.Add(204203);
            arr.Add(30494202);
            arr.Add(40494202);
            arr.Add(50494202);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            BitArray64 arr2 = new BitArray64(5);
            arr2.Add(20494202);
            arr2.Add(204203);
            arr2.Add(30494202);
            arr2.Add(40494202);
            arr2.Add(50494202);

            Console.WriteLine(arr.Equals(arr2));
            Console.WriteLine(arr.GetHashCode());

            arr2[0] = 1;
            Console.WriteLine("Check for equality: {0}", arr == arr2);
        }
    }
}
