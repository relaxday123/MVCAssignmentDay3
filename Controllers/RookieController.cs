using System.Data;
using b1.Models;
using b1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace b1.Controllers
{
    public class RookieController : Controller
    {
        private readonly ILogger<RookieController> _logger;
        private readonly IPersonService _personService;

        public RookieController(ILogger<RookieController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        public IActionResult Index()
        {
            var data = _personService.GetAll();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person model)
        {
            var member = _personService.Create(model);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int index)
        {
            ViewData["Index"] = index;
            var person = _personService.GetOne(index);
            return View(person);
        }

        [HttpPost]
        public IActionResult Update(Person model, int index)
        {
            var member = _personService.Update(model, index);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int index)
        {
            _personService.Delete(index);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int index)
        {
            ViewData["Index"] = index;
            var person = _personService.GetOne(index);
            return View(person);
        }

        [HttpPost]
        public IActionResult DeleteAndRedirectToResultPage(int index)
        {
            var person = _personService.GetOne(index);
            HttpContext.Session.SetString("DELETED_MEMBER_FULLNAME", person.FullName);
            
            _personService.Delete(index);
            return RedirectToAction("DeleteResult");
        }

        public IActionResult DeleteResult()
        {
            ViewData["MemberName"] =  HttpContext.Session.GetString("DELETED_MEMBER_FULLNAME");
            return View();
        }
    }
}