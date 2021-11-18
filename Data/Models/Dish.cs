using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaudeMonet.Data.Models
{
    public class Dish
    {
        public int id {set;get;}
        public  string name { set; get; }
        public string desc_short { set; get; }
        public string desc_long { set; get; }
        public string img { set; get; }
        public ushort price { set; get; }
        public bool is_favourite { set; get; }
        public bool available { set; get; }
        public int category_ID { set; get; }
        public virtual Category Category {set;get;}
    }
}
