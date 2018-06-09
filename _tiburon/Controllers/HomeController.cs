using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using _tiburon.Abstract.Models;
using _tiburon.Models;
using _tiburon.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace _tiburon.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRespondentRepository _respondentRepository;

        public HomeController(IRespondentRepository respondentRepository)
        {
            _respondentRepository = respondentRepository;
        }

        public IActionResult Index()
        {
            RespondentViewModel restpondentView = new RespondentViewModel(_respondentRepository);
            return View(restpondentView);
        }

        [HttpPost]
        public IActionResult Index(string gender, string[] items)
        {

            if (gender == null || items.Length < 1)
            {
                ModelState.AddModelError("", "Значения должны быть выбраны.");
                RespondentViewModel restpondentView = new RespondentViewModel(_respondentRepository);
                return View(restpondentView);
            }
            else
            {
             _respondentRepository.AddRespondentAnswer(gender, items);
            return PartialView("_thanks");
            }  
        }


    }
}
