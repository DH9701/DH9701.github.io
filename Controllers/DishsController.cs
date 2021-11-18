using ClaudeMonet.Data.Interfaces;
using ClaudeMonet.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaudeMonet.Controllers
{
    public class DishsController: Controller
    {
        private readonly I_All_Dishs_Return _allDishs;
        private readonly I_Dishs_Catagory _allCategories;

        public DishsController(I_All_Dishs_Return iAllDishsReturn, I_Dishs_Catagory iDishsCatagory)
        {
            _allDishs = iAllDishsReturn;
            _allCategories = iDishsCatagory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с меню";
            Dishs_List_View_Model obj = new Dishs_List_View_Model();
            obj.allDishs = _allDishs.Dishs;
            obj.currCategory = "Блюда";
            return View(obj);
        }
    }
}
