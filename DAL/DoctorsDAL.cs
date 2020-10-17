using BL.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DoctorsDAL
    {
        public void Add(Doctor doctor)
        {
            using (var ctx = new MedicineContext())
            {
                ctx.Doctors.Add(doctor);
                ctx.SaveChanges();
            }
        }

        public void UpdateDoctors(Doctor doctor, int id)
        {
            using (var ctx = new MedicineContext())
            {
                Doctor tmp = ctx.Doctors.First(m => m.Id == id);
                tmp.FirstName = doctor.FirstName;
                tmp.LastName = doctor.LastName;
                tmp.CardId = doctor.CardId;
                tmp.CellPhone = doctor.CellPhone;
                tmp.ImageUrlDP = doctor.ImageUrlDP;
                tmp.Address = doctor.Address;
                tmp.LicenseNumber = doctor.LicenseNumber;
                tmp.LicenseValidity = doctor.LicenseValidity;
                tmp.DateAdd = doctor.DateAdd;
                tmp.Specialty = doctor.Specialty;
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
                var doctor = ctx.Doctors.Where(s => s.Id == id).FirstOrDefault();
                ctx.Doctors.Remove(doctor);
                ctx.SaveChanges();
            }
        }

        public List<Doctor> GetDoctors()
        {
            var ctx = new MedicineContext();
            return ctx.Doctors.ToList();
        }

        public Doctor GetDoctorByID(int id)
        {
            using (var ctx = new MedicineContext())
            {
                var doctor = ctx.Doctors.Where(s => s.Id == id).FirstOrDefault();
                return doctor;
            }
        }
        public Doctor GetDoctorByName(string name)
        {
            using (var ctx = new MedicineContext())
            {
                var doctor = ctx.Doctors.Where(s => s.FirstName == name).FirstOrDefault();
                return doctor;
            }
        }

    }
}