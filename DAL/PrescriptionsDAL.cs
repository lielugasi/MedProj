using BL.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PrescriptionsDAL
    {
        public void Add(Prescription prescription)
        {
            using (var ctx = new MedicineContext())
            {
                ctx.Prescriptions.Add(prescription);
                ctx.SaveChanges();
            }
        }

        public void UpdatePrescriptions(Prescription prescription, int id)
        {
            using (var ctx = new MedicineContext())
            {
                Prescription tmp = ctx.Prescriptions.First(m => m.Id == id);
                tmp.PrescriptionDate = prescription.PrescriptionDate;
                tmp.CardIdP = prescription.CardIdP;
                tmp.DoctorName = prescription.DoctorName;
                tmp.MedicineName = prescription.MedicineName;
                tmp.StartTime = prescription.StartTime;
                tmp.EndTime = prescription.EndTime;
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
                var prescription = ctx.Prescriptions.Where(s => s.Id == id).FirstOrDefault();
                ctx.Prescriptions.Remove(prescription);
                ctx.SaveChanges();
            }
        }

        public List<Prescription> GetPrescriptions()
        {
            var ctx = new MedicineContext();
            return ctx.Prescriptions.ToList();
        }

        public Prescription GetPrescriptionByID(int id)
        {
            using (var ctx = new MedicineContext())
            {
                var prescription = ctx.Prescriptions.Where(s => s.Id == id).FirstOrDefault();
                return prescription;
            }
        }
        /*public Prescription GetPrescriptionByName(string name)
        {
            using (var ctx = new MedicineContext())
            {
                var prescription = ctx.Prescriptions.Where(s => s.FirstName == name).FirstOrDefault();
                return prescription;
            }
        }*/
    }
}
