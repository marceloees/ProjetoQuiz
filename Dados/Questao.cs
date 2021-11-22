using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoQuiz.Dados
{
    public class Questao
    {
        public int IdQuestao { get; set; }
        public string NomeQuestão { get; set; }
        public string Usuario { get; set; }
        public bool IsRespondida { get; set; }
        public List<Alternativa> ListaAlternativas { get; set; }

        public Questao()
        {
            this.ListaAlternativas = new List<Alternativa>();
        }

            public List<Questao> CarregarQuestões()
        {
            List<Questao> lst = new List<Questao>();
            Questao questao = new Questao();


            questao.IdQuestao = 1;
            questao.NomeQuestão = "Qual valor da soma 10-1";
            questao.Usuario = "guilherme";
            questao.IsRespondida = false;

            Alternativa alternativa = new Alternativa();

            alternativa.IdQuestao = 1;
            alternativa.IdALterenativa = 1;
            alternativa.NomeAlterenativa = "8";
            alternativa.isSelecionada = false;

            Alternativa alternativa1 = new Alternativa();

            alternativa1.IdQuestao = 1;
            alternativa1.IdALterenativa = 2;
            alternativa1.NomeAlterenativa = "9";
            alternativa1.isSelecionada = false;

            Alternativa alternativa2 = new Alternativa();

            alternativa1.IdQuestao = 1;
            alternativa1.IdALterenativa = 3;
            alternativa1.NomeAlterenativa = "0";
            alternativa1.isSelecionada = false;

            Alternativa alternativa3 = new Alternativa();

            alternativa1.IdQuestao = 1;
            alternativa1.IdALterenativa = 4;
            alternativa1.NomeAlterenativa = "1";
            alternativa1.isSelecionada = false;

            questao.ListaAlternativas.Add(alternativa);
            questao.ListaAlternativas.Add(alternativa1);
            questao.ListaAlternativas.Add(alternativa2);
            questao.ListaAlternativas.Add(alternativa3);

            lst.Add(questao);
            //--------------------------------------------------

            Questao questao1 = new Questao();


            //questao1.IdQuestão = 2;
            questao1.NomeQuestão = "Qual formaula da água";
            questao1.Usuario = "guilherme";
            questao1.IsRespondida = false;

            Alternativa alternativa4 = new Alternativa();

            alternativa4.IdQuestao = 2;
            alternativa4.IdALterenativa = 5;
            alternativa4.NomeAlterenativa = "N2OH";
            alternativa4.isSelecionada = false;

            Alternativa alternativa5 = new Alternativa();

            alternativa5.IdQuestao = 2;
            alternativa5.IdALterenativa = 6;
            alternativa5.NomeAlterenativa = "CO2";
            alternativa5.isSelecionada = false;

            Alternativa alternativa6 = new Alternativa();

            alternativa6.IdQuestao = 2;
            alternativa6.IdALterenativa = 7;
            alternativa6.NomeAlterenativa = "CH4";
            alternativa6.isSelecionada = false;

            Alternativa alternativa7 = new Alternativa();

            alternativa7.IdQuestao = 2;
            alternativa7.IdALterenativa = 8;
            alternativa7.NomeAlterenativa = "H2O";
            alternativa7.isSelecionada = false;

            questao1.ListaAlternativas.Add(alternativa4);
            questao1.ListaAlternativas.Add(alternativa5);
            questao1.ListaAlternativas.Add(alternativa6);
            questao1.ListaAlternativas.Add(alternativa7);

          
            lst.Add(questao1);
            return lst;

        }
    }
}
