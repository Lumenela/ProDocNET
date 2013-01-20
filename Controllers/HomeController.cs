using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProdocNET.Models.Abstract;

namespace ProdocNET.Controllers
{
    public class HomeController : Controller
    {
        private IDocumentsRepository documentsRepository { get; set; }
        private ICategoriesRepository categoriesRepository { get; set; }

        public HomeController(IDocumentsRepository documentsRepository, ICategoriesRepository categoriesRepository)
        {
            this.documentsRepository = documentsRepository;
            this.categoriesRepository = categoriesRepository;
        }

        public ActionResult Index()
        {
            var categories = documentsRepository.GetDocumentsByCategoryName("C#");
            return View(categories);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
