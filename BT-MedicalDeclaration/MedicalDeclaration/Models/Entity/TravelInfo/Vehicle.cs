using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalDeclaration.Models.Entity
{
    [Table("Vehicle")]
    public class Vehicle
    {
        [Key]
        public int VehiclesId { get; set; }
        [MaxLength(50)]
        public string VehiclesName { get; set; }
        public ICollection<InfomationVehicle> InfomationVehicles { get; set; }
    }
}
