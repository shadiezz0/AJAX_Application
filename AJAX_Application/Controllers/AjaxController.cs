using AJAX_Application.Models.Data;
using AJAX_Application.Models.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo.Models.Data;
using Repo.ViewModel;

namespace Repo.Controllers
{
    public class AjaxController : Controller
    {
        private readonly IRepoProj<Country> country;
        private readonly IRepoProj<City> city;
        private readonly IRepoProj<User> user;

        public AjaxController(IRepoProj<Country> country, IRepoProj<City> city, IRepoProj<User> user)
        {
            this.country = country;
            this.city = city;
            this.user = user;
        }
        public IActionResult Index()
        {
            CountryCityVM vM = new CountryCityVM
            {
                Countries = country.List(),
            };
            return View(vM);
        }
        [HttpGet]
        public JsonResult GetCities(int CountryId)
        {
            var c = country.Find(CountryId);
            var cit = city.ListByFilter(cc => cc.Country == c);
            return Json(new SelectList(cit, "Id", "Name"));
        }

        [HttpPost]
        public JsonResult AddUser(string username, int cid)
        {
            var c = city.Find(cid);
            var u = new User
            {
                City = c,
                Name = username,
            };
            user.Add(u);
            return Json(username);
        }

    }
}
