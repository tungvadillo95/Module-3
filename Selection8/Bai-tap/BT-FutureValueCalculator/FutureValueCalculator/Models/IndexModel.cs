using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureValueCalculator.Models
{
    public class IndexModel
    {
        public double InventmentAmount { get; set; }
        public float YearlyInterestRate { get; set; }
        public int NumberofYears { get; set; }
        public double FutureValue { get; set; }
    }
}
