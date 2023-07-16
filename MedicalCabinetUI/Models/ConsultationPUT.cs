using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCabinetUI.Models
{
    public class ConsultationPUT
    {
        public Guid ID_Patient { get; set; }
        public Guid ID_MedicalStaff { get; set; }
        public DateTime DateOfConsultation { get; set; }
        public string Symptoms { get; set; }
        public string Diagnosis { get; set; }
        public List<Cons_medic> ListConsMedic { get; set; }
    }
}
