using BL.BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class PrescriptionsBL
    {
        public void AddNewPrescription(Prescription prescription)
        {
            //כאן מוסיפים את הבדיקות כמו הבדיקה שהתמונה היא תרופה
            //דוגמאות לבדיקות
            //האם תרופה כבר קיימת(לשים לב שזה הוספה לקטלוג של התרופות ולא למרשמים)
            PrescriptionsDAL dal = new PrescriptionsDAL();
            dal.Add(prescription);
        }
        public List<Prescription> GetPrescriptions()
        {
            PrescriptionsDAL dal = new PrescriptionsDAL();
            return dal.GetPrescriptions();
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