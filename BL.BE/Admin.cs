using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BE
{
    public class Admin
    {
        public int Id { get; set; }
        //[DisplayName("שם משתמש")]
        public string Username { get; set; }
        //[DisplayName("סיסמא")]
        public string Password { get; set; }
    }
}
