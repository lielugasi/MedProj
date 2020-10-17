using BL.BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DoctorsBL
    {
        public void AddNewDoctor(Doctor doctor)
        {
            //כאן מוסיפים את הבדיקות כמו הבדיקה שהתמונה היא תרופה
            //דוגמאות לבדיקות
            //האם תרופה כבר קיימת(לשים לב שזה הוספה לקטלוג של התרופות ולא למרשמים)
            DoctorsDAL dal = new DoctorsDAL();
            dal.Add(doctor);
        }
        public List<Doctor> GetDoctors()
        {
            DoctorsDAL dal = new DoctorsDAL();
            return dal.GetDoctors();
        }

        public void Delete(int id)
        {
            DoctorsDAL dal = new DoctorsDAL();
            dal.Delete(id);
        }

        public Doctor GetDoctorByID(int id)
        {
            DoctorsDAL doctorDAL = new DoctorsDAL();
            return doctorDAL.GetDoctorByID(id);
        }
    }
}
