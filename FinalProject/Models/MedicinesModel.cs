using BL.BE;
using BL;
using System.Collections.Generic;

namespace Zehorit.Models
{
    public class MedicinesModel
    {
        public void AddMedicine(string name, string maker, string genericName, string properties, string imageUrl)
        {
            Medicine medicine = new Medicine()
            {
                Name = name,
                Maker = maker,
                GenericName = genericName,
                Properties = properties,
                ImageUrl = imageUrl
            };
            MedicinesBL bl = new MedicinesBL();
            bl.AddNewMedicine(medicine);
        }
        internal void Delete(int id)
        {
            MedicinesBL bl = new MedicinesBL();
            bl.Delete(id);
        }
        /*public List<MedicineViewModel> GetMedicines()
        {
            MedicinesBL medicineBL = new MedicinesBL();
            List<Medicine> medicines = medicineBL.GetMedicines();
            List<MedicineViewModel> result = new List<MedicineViewModel>();
            MedicineViewModel dvm = null;
            foreach (var item in medicines)
            {
                dvm = new MedicineViewModel(item);
                result.Add(dvm);
            }
            return result;
        }
        public MedicineViewModel GetMedicineById(int id)
        {
            MedicinesBL medicineBL = new MedicinesBL();
            var medicine = medicineBL.GetMedicineByID(id);
            MedicineViewModel result = new MedicineViewModel(medicine);
            return result;

        }
        */





    }
}