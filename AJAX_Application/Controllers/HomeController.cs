using AJAX_Application.Models.Data;
using AJAX_Application.Models.Repos;
using Microsoft.AspNetCore.Mvc;

namespace AJAX_Application.Controllers
{
      public class HomeController : Controller
      {
            private readonly IRepoProj<City> cityRepo;
            public HomeController(IRepoProj<City> cityRepo)
            {
                  this.cityRepo = cityRepo;
            }

            public IActionResult Index()
            {
                  var model = cityRepo.List();
                  return View(model);
            }

            public IActionResult Privacy()
            {
                  return View();
            }
      }
}