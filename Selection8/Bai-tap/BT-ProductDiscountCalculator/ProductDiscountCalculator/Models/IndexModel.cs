using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDiscountCalculator.Models
{
    public class IndexModel
    {
        public string ProductDescription { get; set; }
        public float ListPrice { get; set; }
        public float DiscountPercent { get; set; }
        public double DiscountAmount { get; set; }
        public double DiscountPrice { get; set; }
    }
}
