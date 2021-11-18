using ClaudeMonet.Data.Interfaces;
using ClaudeMonet.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaudeMonet.Data.Mocks
{
    public class Mock_Dishs : I_All_Dishs_Return
    {
        private readonly I_Dishs_Catagory _categoryDishs = new Mock_Category();

        public IEnumerable<Dish> Dishs
        {
            get
            {
                return new List<Dish>
                {
                    new Dish {
                        name = "Оливье",
                        desc_short = "ЛИНГВИНИ С ТЕЛЯТИНОЙ И ЛИМОННЫМ СОУСОМ", desc_long = "ЛИНГВИНИ С ТЕЛЯТИНОЙ И ЛИМОННЫМ СОУСОМ длинное описание",
                        img = "/img/gallery_1.jpg",
                        price = 270,
                        is_favourite = true,
                        available = true,
                        Category=_categoryDishs.AllCategories.First()
                    },
                    new Dish {
                        name = "ЧИАБАТТА С ЯЙЦОМ ПАШОТ И ГОЛЛАНДСКИМ СОУСОМ",
                        desc_short = "", desc_long = "",
                        img = "/img/gallery_2.jpg",
                        price = 280,
                        is_favourite = false,
                        available = true,
                        Category=_categoryDishs.AllCategories.ElementAt(2)
                    },
                    new Dish {
                        name = "Брауни",
                        desc_short = "ПАЛТУС С КАРТОФЕЛЬНЫМ ПЮРЕ И ШПИНАТОМ", desc_long = "",
                        img = "/img/gallery_3.jpg",
                        price = 180,
                        is_favourite = true,
                        available = true,
                        Category=_categoryDishs.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Dish> getFavDishs { get; set; }

        public Dish getObjectDish(int dishId)
        {
            throw new NotImplementedException();
        }
    }
}
