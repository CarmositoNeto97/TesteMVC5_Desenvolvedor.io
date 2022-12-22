using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TesteMVC5.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        [Route(template: "sobre-nos")]
        public ActionResult About()
        {
            return View();
        }
        
        [Route(template: "institucional/entre-me-contato")]
        public ActionResult Contact()
        {
            return View();
        }

        [Route(template: "content-result")]
        public ContentResult ContentResult()
        {
            return Content("Olá");
        }

        [Route(template: "downloads/meu-arquivo")]
        public FileContentResult FileContentResult()
        {
            var foto = System.IO.File.ReadAllBytes(Server.MapPath("/content/images/capa.png"));
            return File(foto, contentType: "image/png", fileDownloadName: "capa.png");
        }

        public HttpUnauthorizedResult HttpUnauthorizedResult()
        {
            return new HttpUnauthorizedResult();
        }
        public JsonResult JsonResult()
        {
            return Json(data: "teste:'Teste'", JsonRequestBehavior.AllowGet);
        }
        public RedirectResult RedirectResult()
        {
            return new RedirectResult(url: "https://desenvolvedor.io");
        }

        public RedirectToRouteResult RedirectToRouteResult()
        {
            //return RedirectToRoute(new
            //{
            //    controller = "Home",
            //    action = "Index"
            //});
            return RedirectToAction("IndexTeste", controllerName: "Teste");
        }
    }
}