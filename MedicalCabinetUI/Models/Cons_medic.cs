using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCabinetUI.Models
{
    public class Cons_medic
    {
        public Guid ID { get; set; }
        public Guid ID_consultation { get; set; }
        public Guid ID_medication { get; set; }
        public int PrescribedDoseMedication { get; set; }
        public int PeriodOfTreatment { get; set; }
    }
}
