using BL;
using BL.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zehorit.Models
{
    public class DoctorsModel
    {
        public void AddDoctor(string firstName, string lastName, string cardId, string cellPhone, string imageUrlDP, string address, int licenseNumber, DateTime licenseValidity, DateTime dateAdd, string specialty)
        {
            Doctor doctor = new Doctor()
            {
                FirstName = firstName,
                LastName = lastName,
                CardId = cardId,
                CellPhone = cellPhone,
                ImageUrlDP = imageUrlDP,
                Address = address,
                LicenseNumber = licenseNumber,
                LicenseValidity = licenseValidity,
                DateAdd = dateAdd,
                Specialty = specialty

            };
            DoctorsBL bl = new DoctorsBL();
            bl.AddNewDoctor(doctor);
        }
        internal void Delete(int id)
        {
            DoctorsBL bl = new DoctorsBL();
            bl.Delete(id);
        }

    }
}