using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoQuiz.Models;

namespace ProjetoQuiz.Data
{
    public class ProjetoQuizContext : DbContext
    {
        public ProjetoQuizContext (DbContextOptions<ProjetoQuizContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoQuiz.Models.Quiz> Quiz { get; set; }
    }
}
