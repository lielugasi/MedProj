using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BE
{
    public class Person
    {
        public int Id { get; set; }
        //[DisplayName("שם פרטי")]
        public string FirstName { get; set; }
        //[DisplayName("שם משפחה")]
        public string LastName { get; set; }
        //[DisplayName("מספר תעודת זהות")]
        public string CardId { get; set; }
        //[DisplayName("מספר פלאפון")]
        public string CellPhone { get; set; }
        //[DisplayName("תמונה")]
        public string ImageUrlDP { get; set; }
        //[DisplayName("כתובת")]
        public string Address { get; set; }


    }
}
