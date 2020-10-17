using BL.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MedicinesDAL
    {
        public void Add(Medicine medicine)
        {
            using (var ctx = new MedicineContext())
            {
                ctx.Medicines.Add(medicine);
                ctx.SaveChanges();
            }
        }




        /*public void AddImageMedicines(int id, HttpPostedFileBase file)//// עצמן איילה
        {
            using (var ctx = new MedicineContext())
            {
                Medicine tmp = ctx.Medicines.First(m => m.Id == id);
                tmp.ImageUrl = file.FileName;
                ctx.SaveChanges();

                //Google Drive API
                GoogleDriveAPIHelper gd = new GoogleDriveAPIHelper();
                gd.UplaodFileOnDriveInFolder(file, file.FileName, "MedicinesImages");

            }
        }*/
        public void UpdateMedicines(Medicine medicine, int id)
        {
            using (var ctx = new MedicineContext())
            {
                Medicine tmp = ctx.Medicines.First(m => m.Id == id);
                tmp.Name = medicine.Name;
                tmp.Maker = medicine.Maker;
                tmp.GenericName = medicine.GenericName;
                tmp.ActiveIngredients = medicine.ActiveIngredients;
                tmp.Properties = medicine.Properties;
                tmp.ImageUrl = medicine.ImageUrl;
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
                var medicine = ctx.Medicines.Where(s => s.Id == id).FirstOrDefault();
                ctx.Medicines.Remove(medicine);
                ctx.SaveChanges();
            }
        }

        public List<Medicine> GetMedicines()
        {
            var ctx = new MedicineContext();
            return ctx.Medicines.ToList();
        }

        public Medicine GetMedicineByID(int id)
        {
            using (var ctx = new MedicineContext())
            {
                var medicine = ctx.Medicines.Where(s => s.Id == id).FirstOrDefault();
                return medicine;
            }
        }
        public Medicine GetMedicineByName(string name)
        {
            using (var ctx = new MedicineContext())
            {
                var medicine = ctx.Medicines.Where(s => s.Name == name).FirstOrDefault();
                return medicine;
            }
        }
        /*public List<Medicine> GetMedicineOfPatient(int id)//להביא תרופא לפי לקוח
        {
            using (var ctx = new MedicineContext())
            {

                return from pres in Prescription 
                       from Medicine in MedicineContext
                       where Prescriptions.CardIdP == id && med.Id == pres.MedicineId
                       select Medicine. ;

                /*var medicine = ctx.Prescriptions.Where(s => s.Id == id && s.EndTime<=DateTime.Now);
                return medicine..Medicines.ToList();

            }
        }*/


        public List<string> GetMedicineOfPatient(int id)//להביא תרופא לפי לקוח
        {
            using (var ctx = new MedicineContext())
            {

                 //return from pres in Prescription
                 //       from Medicine in MedicineContext
                 //       where Prescriptions.CardIdP == id && med.Id == pres.MedicineId
                 //       select Medicine. ;

                var prescriptions = ctx.Prescriptions.Where(s => s.Id == id && s.EndTime <= DateTime.Now).ToList();
                List<string> res = new List<string>();
                foreach (var presp in prescriptions)
                    res.Add(presp.MedicineName);

                return res;

            }
        }
    }
}