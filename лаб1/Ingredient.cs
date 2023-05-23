using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб1
{
    public class Ingredient
    {
        
            public int IngredientId { get; set; }
            public string IngredientName { get; set; }
            public int AmountOfCalories { get; set; }

            public Ingredient(int ingredientid, string ingredientname, int amountofcalories)
            {
                this.IngredientId = ingredientid;
                this.IngredientName = ingredientname;
                this.AmountOfCalories = amountofcalories;
            }
            public Ingredient() { }
            public override string ToString()
            {
                return string.Format($"id:{this.IngredientId};  name:{this.IngredientName}; amount of calories:{this.AmountOfCalories} ");
            }
        
    }
}
