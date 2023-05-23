using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб1
{
    public class Dish
    {
       
            public int DishId { get; set; }
            public string DishName { get; set; }
            public int IngredientId { get { return Ingredient.IngredientId; } }
            Ingredient Ingredient = new Ingredient();
            public int AmountOfIngredient { get; set; }


            public List<Dish> Dishes { get; set; }

            public Dish(int dishid, string dishname, int ingredientid, int amountofingredient)
            {
                this.DishId = dishid;
                this.DishName = dishname;
                Ingredient.IngredientId = ingredientid;
                this.AmountOfIngredient = amountofingredient;

            }
            public Dish() { }

            public override string ToString()
            {
                return string.Format($"id:{this.DishId};  dish name:{this.DishName} ingredient:{this.Ingredient.IngredientName} amount:{this.AmountOfIngredient} ");
            }
        
    }
}
