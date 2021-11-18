using ClaudeMonet.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaudeMonet.Data.Interfaces
{
    public interface I_All_Dishs_Return
    {
        IEnumerable<Dish> Dishs { get;}//IEnumerable<Dish> Dishs { get; set; }
        IEnumerable<Dish> getFavDishs { get; set; }
        Dish getObjectDish(int dishId);
    }
}
