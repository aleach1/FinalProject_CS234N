using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreweryProject
{
    public partial class Hop
    {
        public int IngredientId { get; set; }
        public int HopTypeId { get; set; }
        public string Origin { get; set; }
        public double Alpha { get; set; }
        public double Beta { get; set; }
        public double HSI { get; set; }
        public string Form {  get; set; }

        public virtual Ingredients Ingredient { get; set; }
        public virtual HopType HopType { get; set; }
    }
}
