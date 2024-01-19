﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DEMOFORMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepo repo;

        public ProductController(IProductRepo repo)
        {
            this.repo = repo;
        }


        public IActionResult Index()
        {
            var products = repo.GetAllProducts();
            return View(products);
        }
    }
}
