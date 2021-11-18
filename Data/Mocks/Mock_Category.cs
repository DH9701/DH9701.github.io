using ClaudeMonet.Data.Interfaces;
using ClaudeMonet.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaudeMonet.Data.Mocks
{
    public class Mock_Category : I_Dishs_Catagory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { category_name = "Лингвини", desc = "классические итальянские макаронные изделия крупного формата из региона Кампания"},
                    new Category { category_name = "Чиабатта", desc = "это национальный итальянский хлеб, который готовится на основе пшеничной муки с добавлением дрожжей"},
                    new Category { category_name = "Палтус", desc = "рыба семейства камбаловых"}
                };
            }
        }
    }
}
