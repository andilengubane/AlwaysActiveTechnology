using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlwaysActiveTechnology.Service.Interface
{
    public interface ICalculatePrimeNumbers
    {
        void GetOddNumbers();
        void CalculatePrimes();
        void GetEvenNumbers();
        bool IsPrime(int number);
    }
}
