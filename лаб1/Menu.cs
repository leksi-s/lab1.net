using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб1
{
    public class Menu
    {
            public int MenuId { get; set; }
            public int CategoryId { get { return categories.CategoriesId; } }
            CategoriesOfMenu categories = new CategoriesOfMenu();
            public DateOnly Date { get; set; }
            Dish Dish = new Dish();
            public string Dishname { get { return Dish.DishName; } }
            public int Cost { get; set; }

            public Menu(int menuid, int categoryid, DateOnly date, string dishname, int cost)
            {
                this.MenuId = menuid;
                categories.CategoriesId = categoryid;
                this.Date = date;
                Dish.DishName = dishname;
                this.Cost = cost;
            }
            public Menu() { }

            public override string ToString()
            {
                return string.Format($"id:{this.MenuId}; catid:{categories.CategoriesId}; date:{this.Date}; dish name:{this.Dish.DishName} price:{Cost}");
            }
    }

}

