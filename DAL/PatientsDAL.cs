using BL.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PatientsDAL
    {
        public void Add(Patient patient)
        {
            using (var ctx = new MedicineContext())
            {
                ctx.Patients.Add(patient);
                ctx.SaveChanges();
            }
        }

        public void UpdatePatients(Patient patient, int id)
        {
            using (var ctx = new MedicineContext())
            {
                Patient tmp = ctx.Patients.First(m => m.Id == id);
                tmp.FirstName = patient.FirstName;
                tmp.LastName = patient.LastName;
                tmp.CardId = patient.CardId;
                tmp.CellPhone = patient.CellPhone;
                tmp.ImageUrlDP = patient.ImageUrlDP;
                tmp.Address = patient.Address;
                tmp.Age = patient.Age;
                tmp.MedicalHistory = patient.MedicalHistory;
                tmp.DrugsList = patient.DrugsList;
                tmp.Chronic = patient.Chronic;
                ctx.SaveChanges();

                //Google Drive API
                //GoogleDriveAPIHelper gd = new GoogleDriveAPIHelper();
                //gd.deleteAllFiles(medicineId.ToString());
                //gd.UplaodFileOnDriveInFolder(file, medicineId.ToString(), "cloudComputing");

            }
        }







        public void Delete(int id)
        {
            using (var ctx = new MedicineContext())
            {
                var patient = ctx.Patients.Where(s => s.Id == id).FirstOrDefault();
                ctx.Patients.Remove(patient);
                ctx.SaveChanges();
            }
        }

        public List<Patient> GetPatients()
        {
            var ctx = new MedicineContext();
            return ctx.Patients.ToList();
        }

        public Patient GetPatientByID(int id)
        {
            using (var ctx = new MedicineContext())
            {
                var patient = ctx.Patients.Where(s => s.Id == id).FirstOrDefault();
                return patient;
            }
        }
        public Patient GetPatientByName(string name)
        {
            using (var ctx = new MedicineContext())
            {
                var patient = ctx.Patients.Where(s => s.FirstName == name).FirstOrDefault();
                return patient;
            }
        }

    }
}