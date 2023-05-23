using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace лаб1
{
    public class CategoriesOfMenu
    {
        public int CategoriesId { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }

        public CategoriesOfMenu(int categoriesid, string category, string name)
        {
            this.CategoriesId = categoriesid;
            this.Category = category;
            this.Name = name;
        }

        public CategoriesOfMenu() { }

        public override string ToString()
        {
            return string.Format($"id:{this.CategoriesId};  category:{this.Category}; dish name:{this.Name} ");
        }

    }

}  

     


   

