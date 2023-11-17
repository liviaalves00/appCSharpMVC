using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace c_.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        public DbSet<Pessoa> Pessoas {get; set;}
        public DbSet<Usuario> Usuario {get; set;}
        public DbSet<Aluno> Alunos {get; set;}
        public DbSet<Professor> Professores {get; set;}
        



    }
}