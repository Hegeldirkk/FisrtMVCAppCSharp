using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FisrtMVCAppCSharp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FisrtMVCAppCSharp.Controllers
{
    public class HelloWorldController : Controller
    {

        private static readonly List<DogViewModel> dogs = new List<DogViewModel>();

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(dogs);
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            dogs.Add(dogViewModel);
            //return View("Index");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Hello()
        {
            DogViewModel dogHelo = new DogViewModel() { Name = "Yedi", Age = 10 };
            return View(dogHelo);
        }
    }
}

