using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BE
{
    public class Patient : Person
    {
        //[DisplayName("גיל")]
        public int Age { get; set; }
        //[DisplayName("היסטוריה רפואית")]
        public string MedicalHistory { get; set; }
        //[DisplayName("רשימת תרופות")]
        public ICollection<Medicine> DrugsList { get; set; }
        //[DisplayName("מחלות כרוניות")]
        public string Chronic { get; set; }
    }
}
