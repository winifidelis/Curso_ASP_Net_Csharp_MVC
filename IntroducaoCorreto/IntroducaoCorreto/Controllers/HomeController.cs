using IntroducaoCorreto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroducaoCorreto.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Winicius";
            pessoa1.PessoaID = 1;
            pessoa1.Tipo = "Administrador";

            var pessoa2 = new Pessoa
            {
                PessoaID = 2,
                Nome = "Teste",
                Tipo = "programador",
            };

            var pessoa3 = new Pessoa();
            pessoa3.Nome = "3";
            pessoa3.PessoaID = 3;
            pessoa3.Tipo = "3";

            ViewData["PessoaId"] = pessoa1.PessoaID;
            ViewData["Nome"] = pessoa1.Nome;
            ViewData["Tipo"] = pessoa1.Tipo;

            ViewBag.Id = pessoa2.PessoaID;
            ViewBag.Nome = pessoa2.Nome;
            ViewBag.Tipo = pessoa2.Nome;

            

            return View(pessoa1);
        }

        public ActionResult Contatos()
        {
            return View();
        }

        //TODA VEZ QUE UM MÉTODO FOR EXECUTADO VIA FORM/POST EU DEVO INFORMAR A FUNÇÃO O TIPO FO MÉTODO
        //[HttpPost]
        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            //ViewData["PessoaId"] = pessoa.PessoaID;
            //ViewData["Nome"] = pessoa.Nome;
            //ViewData["Tipo"] = pessoa.Tipo;
            var pessoaNova = new Pessoa();
            pessoaNova = pessoa;
            return View(pessoaNova);
        }


    }
}