using ClaudeMonet.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaudeMonet.ViewModels
{
    public class Dishs_List_View_Model
    {
        public IEnumerable<Dish> allDishs { get; set; }
        public string currCategory { get; set; }
    }
}
