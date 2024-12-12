using AlwaysActiveTechnology.Service.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlwaysActiveTechnology.Service
{
    public class PrimeNumberService
    {
        private readonly ICalculatePrimeNumbers _trackingHelper;

        public async Task Start()
        {
            try
            {
                logger.LogInformation("Start");

                Thread oddThread = new Thread(_trackingHelper.GetOddNumbers);
                Thread primeThread = new Thread(_trackingHelper.CalculatePrimes);
                Thread evenThread = new Thread(_trackingHelper.GetEvenNumbers);
                oddThread.Start();
                primeThread.Start();
                evenThread.Start();

                Thread.Sleep(10000);
                oddThread.Abort();
                primeThread.Abort();
                evenThread.Abort();
            }
            catch
            {
                throw;
            }
        }


        public async Task Save()
        {
            logger.LogInformation("Save");
            throw new NotImplementedException();
        }
    }
}
