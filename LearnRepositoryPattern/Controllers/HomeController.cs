using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LearnRepositoryPattern.Models;
using BLL.Repositories;
using DAL.Entities;

namespace LearnRepositoryPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CategoryRepository categoryRepository;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            categoryRepository = new CategoryRepository();
        }

        public IActionResult Index()
        {
            var categories = categoryRepository.GetAll();
            CategoryIndexVM result = new CategoryIndexVM();
            result.Test = "Hai";
            result.categories = categories.Cast<Category>().ToList();
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
