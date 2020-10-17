using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BE
{
    public class Medicine
    {
        public int Id { get; set; }
        //[DisplayName("השם המסחרי של התרופה")]
        public string Name { get; set; }
        //[DisplayName("יצרן")]
        public string Maker { get; set; }
        //[DisplayName("שם גנרי")]
        public string GenericName { get; set; }
        //[DisplayName("מרכיבים פעילים")]
        public List<Ingredient> ActiveIngredients { get; set; }
        //[DisplayName("מאפייני מנה")]
        public string Properties { get; set; }
        //[DisplayName("תמונה")]
        public string ImageUrl { get; set; }
    }
}
