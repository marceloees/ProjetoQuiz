using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoQuiz.Models
{
    [Table("Quiz")]
    public class Quiz
    {
        [Key]
        [Column("idQuiz")]
        public int Id { get; set; }
       

        [Column("User")]
        public string User { get; set; }
        

        [Column("titulo")]
        public string Titulo { get; set; }
        

        [Column("ques1")]
        public string Question1 { get; set; }
        
        [Column("ques2")]
        public string Question2 { get; set; }
       
        [Column("ques3")]
        public string Question3 { get; set; }
        
        [Column("ques4")]
        public string Question4 { get; set; }
        

        [Column("respCerta")]
        public string RespCerta { get; set; }
      



    }


    //ter uma variável que escuta e armazena a escolha do usuário e depois comparar com o banco de dados. 
    //criar o cálculo de percentual do jogador
}
