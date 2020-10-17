using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BE
{
    public class Prescription
    {
        public int Id { get; set; }
        //[DisplayName("תאריך מרשם")]
        public DateTime PrescriptionDate { get; set; }
        //[DisplayName("תעודת זהות של פציינט")]
        public int CardIdP { get; set; }
        //[DisplayName("שם של רופא מנפיק")]
        public string DoctorName { get; set; }
        //[DisplayName("שם תרופה")]
        public string MedicineName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
