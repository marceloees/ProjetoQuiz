using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoQuiz.Dados
{
    public class Alternativa
    {
        public int IdALterenativa { get; set; }
        public string NomeAlterenativa { get; set; }
        public bool isSelecionada { get; set; }
        public int IdQuestao { get; set; }
        public Questao questao { get; set; }

        public Alternativa()
        {
            this.questao = new Questao();  
        }
     }
}
