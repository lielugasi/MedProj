using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class MedicationAdminLogic
    {
        public bool AddMedication(string name, string maker, string genericName, string activeIngredients, string properties, string imageUrl)
        {
            bool Result = true;

            //כאן מוסיפים את הבדיקות כמו הבדיקה שהתמונה היא תרופה

            DAL.ReadWriteMedicines dal = new DAL.ReadWriteMedicines();
            dal.InsertMedication(name, maker, genericName, activeIngredients, properties, imageUrl);
            return Result;
        }

    }
}
