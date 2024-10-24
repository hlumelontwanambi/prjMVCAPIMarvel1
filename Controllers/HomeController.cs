using Microsoft.AspNetCore.Mvc;
using prjMVCAPIMarvel.Models;
using prjMVCAPIMarvel.Services;
using System.Diagnostics;

namespace prjMVCAPIMarvel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApiService _apiService;

        public HomeController(ApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<IActionResult> Index()
        {
            var avengers = await _apiService.GetAvengersAsync();
            return View(avengers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TblAvenger avenger)
        {
            await _apiService.CreateAvengersAsync(avenger);
            return RedirectToAction("Index");
        }
    }
}
