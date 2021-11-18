using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaudeMonet.Data.Models
{
    public class Category
    {

        public int id { set; get; }

        public string category_name { set; get; }

        public string desc { set; get; }

        public List<Dish> dishs { set; get; }
    }
}
