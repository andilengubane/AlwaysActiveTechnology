using AlwaysActiveTechnology.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlwaysActiveTechnology.Service.Extensions
{
    public class CalculatePrimeNumbers : ICalculatePrimeNumbers
    {
        List<int> numbers = new List<int>();
        readonly object lockObject = new object();
        bool stopThreads = false;

        public void GetOddNumbers()
        {
            Random random = new Random();
            while (true)
            {
                int number = random.Next(1, 101);
                if (number % 2 != 0)
                {
                    lock (lockObject)
                    {
                        numbers.Add(number);
                        Console.WriteLine($"Added odd number {number} to the list.");
                    }
                }
                Thread.Sleep(1000);
            }
        }

        public void CalculatePrimes()
        {
            int number = 2;
            while (true)
            {
                if (IsPrime(number))
                {
                    int negatedPrime = -number;
                    lock (lockObject)
                    {
                        numbers.Add(negatedPrime);
                    }
                }
                number++;
                Thread.Sleep(1000);
            }
        }

        public void GetEvenNumbers()
        {
            Random random = new Random();
            while (!stopThreads)
            {
                int number = random.Next(1, 101);
                if (number % 2 == 0)
                {
                    lock (lockObject)
                    {
                        numbers.Add(number);
                        Console.WriteLine($"Added even number {number} to the list.");
                    }
                }
                Thread.Sleep(1000);
            }
        }

        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}