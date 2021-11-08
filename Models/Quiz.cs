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
        public int Id { get; set; }
        [Column("idQuiz")]

        public string User { get; set; }
        [Column("tb_User")]

        public string Titulo { get; set; }
        [Column("tb_titulo")]

        public string Question1 { get; set; }
        [Column("tb_ques1")]
        public string Question2 { get; set; }
        [Column("tb_ques2")]
        public string Question3 { get; set; }
        [Column("tb_ques3")]
        public string Question4 { get; set; }
        [Column("tb_ques4")]

        public char RespCerta { get; set; }
        [Column("tb_respCerta")]

        [ForeignKey("idUsuario")]
        public virtual ApplicationIdentity idUsuario { get; set; }
        public virtual ICollection<Quiz> Quizzes { get; private set; }


    }

    //ter uma variável que escuta e armazena a escolha do usuário e depois comparar com o banco de dados. 
    //criar o cálculo de percentual do jogador
}
