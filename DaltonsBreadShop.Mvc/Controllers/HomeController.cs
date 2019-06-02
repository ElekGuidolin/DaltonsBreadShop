using DaltonsBreadShop.Mvc.Models;
using DaltonsBreadShop.Mvc.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DaltonsBreadShop.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBreadRepository _breadRepository;

        public HomeController(IBreadRepository breadRepository)
        {
            _breadRepository = breadRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Dalton's Bakery";

            var breads = _breadRepository.GetAllBreads().OrderBy(b => b.Name);

            var homeVm = new HomeViewModel
            {
                Title = string.Format("Bem vindo à {0}", ViewBag.Title),
                Breads = breads.ToList()
            };

            return View(homeVm);
        }

        public IActionResult Details(int id)
        {
            var bread = _breadRepository.GetBreadById(id);
            if (bread == null)
            {
                return NotFound();
            }

            return View(bread);
        }
    }
}