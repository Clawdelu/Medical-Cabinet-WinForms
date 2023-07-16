using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCabinetUI.Models
{
    public class MedicationPOST
    {
        public string Name { get; set; }
        public int AvailableQuantity { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Guid ID_medicalStaff { get; set; }

    }
}
