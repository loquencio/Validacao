using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validacao.Models;

namespace Validacao.Controllers
{
    public class JogadorController : Controller
    {
        public ActionResult Lista()
        {
            ValidacaoContext ctx = new ValidacaoContext();
            return View(ctx.Jogadores);
        }

        [HttpGet]
        public ActionResult Cadastra()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastra(Jogador j)
        {
            //if (String.IsNullOrEmpty(j.Nome))
            //{
            //    ModelState.AddModelError("Nome", "O nome do jogador é obrigatório");
            //}
            //if (j.Altura == null || j.Altura < 0)
            //{
            //    ModelState.AddModelError("Altura", "A altura do jogador é obrigatória");
            //}
            //if (j.Numero == null || j.Numero < 0 || j.Numero > 100)
            //{
            //    ModelState.AddModelError("Número", "O número do jogador deve estar entre 0 e 100");
            //}

            if (ModelState.IsValid) { 
                ValidacaoContext ctx = new ValidacaoContext();

                ctx.Jogadores.Add(j);
                ctx.SaveChanges();
                return RedirectToAction("Lista");
            }
            else
            {
                return View("Cadastra", j);
            }

        }
    }
}