using BL.BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class PatientsBL
    {
        public void AddNewPatient(Patient patient)
        {
            //כאן מוסיפים את הבדיקות כמו הבדיקה שהתמונה היא תרופה
            //דוגמאות לבדיקות
            //האם תרופה כבר קיימת(לשים לב שזה הוספה לקטלוג של התרופות ולא למרשמים)
            PatientsDAL dal = new PatientsDAL();
            dal.Add(patient);
        }
        public List<Patient> GetPatients()
        {
            PatientsDAL dal = new PatientsDAL();
            return dal.GetPatients();
        }

        public void Delete(int id)
        {
            PatientsDAL dal = new PatientsDAL();
            dal.Delete(id);
        }

        public Patient GetPatientByID(int id)
        {
            PatientsDAL patientDAL = new PatientsDAL();
            return patientDAL.GetPatientByID(id);
        }
    }
}
