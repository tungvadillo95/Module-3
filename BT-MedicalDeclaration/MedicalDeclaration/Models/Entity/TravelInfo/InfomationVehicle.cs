using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalDeclaration.Models.Entity
{
    public class InfomationVehicle
    {
        public int TravelInformationId { get; set; }
        public TravelInfo TravelInformation { get; set; }
        public int VehiclesId { get; set; }
        public Vehicle Vehicles { get; set; }
    }
}
