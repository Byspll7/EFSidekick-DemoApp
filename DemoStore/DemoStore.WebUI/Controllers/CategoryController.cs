﻿using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace DemoStore.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly DataContext _dataContext;

        public CategoryController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult CategoryList()
        {
            var values = _dataContext.Categories.ToList();
            return View(values);
        }
        

    }
}
