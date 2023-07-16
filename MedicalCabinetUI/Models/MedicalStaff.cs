using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCabinetUI
{
    public class MedicalStaff
    {
    public Guid ID { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Speciality { get; set; }
    public string PhoneNumber { get; set; }
    public int DeleteMS { get; set; }

    }
}
