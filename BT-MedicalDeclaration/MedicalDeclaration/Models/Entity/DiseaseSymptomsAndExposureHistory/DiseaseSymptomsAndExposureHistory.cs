using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalDeclaration.Models.Entity.DiseaseSymptomsAndExposureHistory
{
    public class DiseaseSymptomsAndExposureHistory
    {
        [Key]
        public int DSAEH_Id { get; set; }
        public bool Fever { get; set; }
        public bool Cough { get; set; }
        public bool Sultry { get; set; }
        public bool SoreThroat { get; set; }
        public bool VomitingOrNausea { get; set; }
        public bool Diarrhea { get; set; }
        public bool BleedingFromTheSkin { get; set; }
        public bool SkinRash { get; set; }
        [MaxLength(500)]
        public string VaccinesOrBiologicalsUsed { get; set; }


       
        public bool AnimalContact { get; set; }
        public bool CloseContact { get; set; }
    }
}
