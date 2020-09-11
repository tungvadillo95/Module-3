using MedicalDeclaration.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalDeclaration.Models.Entity
{
    [Table("TravelInformation")]
    public class TravelInfo
    {
        [Key]
        public int TravelInformationId { get; set; }
        //public int MedicalDeclaraterId { get; set; }
        //public MedicalDeclarater MedicalDeclarater { get; set; }
        [MaxLength(2000)]
        public string OtherVehicles { get; set; }
        public ICollection<InfomationVehicle> InfomationVehicles { get; set; }
        [MaxLength(500)]
        public string VehicleNumber { get; set; }
        [MaxLength(500)]
        public string SeatsNumber { get; set; }
        public DateTime DepartureDay { get; set; }
        public DateTime EntryDay { get; set; }
        public int DepartureLocation_ProvinceId { get; set; }
        public int PlaceOfDestination_ProvinceId { get; set; }
        [MaxLength(500)]
        public string TravelHistory { get; set; }
    }
}
