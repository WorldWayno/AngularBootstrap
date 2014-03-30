using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Northwind.Entity;
using Northwind.Repository;

namespace AngularBootstrap.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Employee> _empRepository;  

        public HomeController(IUnitOfWork  unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _empRepository = unitOfWork.Repository<Employee>();

        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            var model = _empRepository.All().ToList();

            return RedirectToAction("Bootstrap", "Book");
        }
    }
}
