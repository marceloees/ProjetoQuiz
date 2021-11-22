using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoQuiz.Dados;


namespace ProjetoQuiz.Controllers
{
    [Authorize]
    [Controller]
    [Route("Questoes1")]
    public class Questoes1Controller : Controller
    {
        public IActionResult Index()
        
        {
            var questoes = new Questao().CarregarQuestões();
            return View("Index",questoes);
        }
    }
}
