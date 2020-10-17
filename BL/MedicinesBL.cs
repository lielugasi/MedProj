using BL.BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class MedicinesBL
    {
        public void AddNewMedicine(Medicine medicine)
        {
            //כאן מוסיפים את הבדיקות כמו הבדיקה שהתמונה היא תרופה
            //דוגמאות לבדיקות
            //האם תרופה כבר קיימת(לשים לב שזה הוספה לקטלוג של התרופות ולא למרשמים)
            MedicinesDAL dal = new MedicinesDAL();
            dal.Add(medicine);
        }
        public List<Medicine> GetMedicines()
        {
            MedicinesDAL dal = new MedicinesDAL();
            return dal.GetMedicines();
        }

        public void Delete(int id)
        {
            MedicinesDAL dal = new MedicinesDAL();
            dal.Delete(id);
        }

        public Medicine GetMedicineByID(int id)
        {
            MedicinesDAL medicineDAL = new MedicinesDAL();
            return medicineDAL.GetMedicineByID(id);
        }
    }
}
