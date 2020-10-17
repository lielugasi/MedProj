using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BE
{
    public class Doctor : Person
    {
        //[DisplayName("מספר רישיון")]
        public int LicenseNumber { get; set; }
        //[DisplayName("תוקף רישיון")]
        public DateTime LicenseValidity { get; set; }
        //[DisplayName("תאריך הוספה למערכת")]
        public DateTime DateAdd { get; set; }
        //[DisplayName("התמחות")]
        public string Specialty { get; set; }
    }
}
