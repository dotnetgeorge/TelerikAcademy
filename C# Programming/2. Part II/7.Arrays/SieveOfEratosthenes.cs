//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;
using System.Collections;

class SieveOfEratosthenes
{
    static void Main(string[] args)
    {
        Console.Write("Max prime: ");
        int maxprime = int.Parse(Console.ReadLine());
        ArrayList primeList = Sieve(maxprime);
        foreach (var item in primeList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Count = " + primeList.Count);
    }

    static ArrayList Sieve(int maxprime)
    {
        BitArray al = new BitArray(maxprime, true);

        int lastPrime = 1;
        int lastPrimeSquare = 1;

        while (lastPrimeSquare <= maxprime)
        {
            lastPrime++;
            while (!(bool)al[lastPrime])
            {
                lastPrime++;
            }
            lastPrimeSquare = lastPrime * lastPrime;

            for (int i = lastPrimeSquare; i < maxprime; i += lastPrime)
            {
                if (i > 0)
                {
                    al[i] = false;
                }
            }
        }
        ArrayList sieve_2_return = new ArrayList();

        for (int i = 2; i < maxprime; i++)
        {
            if (al[i])
            {
                sieve_2_return.Add(i);
            }
        }
        return sieve_2_return;
    }
}