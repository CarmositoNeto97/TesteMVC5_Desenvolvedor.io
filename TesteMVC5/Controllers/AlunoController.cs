using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteMVC5.Models;

namespace TesteMVC5.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        [Route(template:"novo-aluno")]
        public ActionResult Novo(Aluno aluno)
        {
            aluno = new Aluno
            {
                Id = 1,
                Nome = "Carmosito",
                CPF = "12345678945",
                DataMatricula = DateTime.Now,
                Email = "carmo@carmo.com",
                Ativo = true,
                Senha = "123",
                SenhaConfirmacao = "123"

            };

            return RedirectToAction("Index", aluno);
        }

        public ActionResult Index(Aluno aluno)
        {
            if (!ModelState.IsValid)
                return View(aluno);
            return View(aluno);
        }
    }
}