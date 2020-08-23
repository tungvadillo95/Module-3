using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sandwich.Models
{
    public class SanwichModel
    {
        public bool Lettuce { get; set; }
        public bool Tomato { get; set; }
        public bool Mustard { get; set; }
        public bool Sprouts { get; set; }
        public string Display()
        {
            string result = "";
            if (Lettuce)
            {
                result += "Lettuce";
            }
            if (Tomato)
            {
                result += ", Tomato";
            }
            if (Mustard)
            {
                result += ", Mustard";
            }
            if (Sprouts)
            {
                result += ", Sprouts";
            }
            return result;
        }
    }
}
