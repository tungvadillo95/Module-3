using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CalculaterBasic.Models
{
    [Table("calculators")]
    public class Calculator
    {
        [Key]
        public int ID { get; set; }
        public double valueA { get; set; }
        public double valueB { get; set; }
        public string Operator { get; set; }
        public double result { get; set; }
    }
}
