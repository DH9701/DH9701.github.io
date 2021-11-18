using ClaudeMonet.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaudeMonet.Data.Interfaces
{
    public interface I_Dishs_Catagory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
