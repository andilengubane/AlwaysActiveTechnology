using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlwaysActiveTechnology.DTO
{
    public class NumberDTO
    {
        public int Id { get; set; }
        public int PrimeValue { get; set; }
        public bool IsPrime { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
