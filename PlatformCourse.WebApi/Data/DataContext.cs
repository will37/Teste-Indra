using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PlatformCourse.WebApi.Models;

namespace PlatformCourse.WebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){ }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Tutor> Tutores { get; set; }
        public DbSet<Cartao> Cartoes { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<AlunoCurso> AlunosCursos { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<AlunoCurso>().HasKey(AC => new {AC.AlunoId, AC.CursoId});

            builder.Entity<Aluno>()
                   .HasData(new List<Aluno>(){
                       new Aluno(1, "Vitoria", "Alves Costa", "VitoriaAlvesCosta@armyspy.com", "5259-9477", 1),
                       new Aluno(2, "Alex", "Sousa Pinto", "AlexSousaPinto@rhyta.com", "5974-7598", 2),
                       new Aluno(3, "Lara", "Ferreira Barros", "LaraFerreiraBarros@armyspy.com", "4850-9411", 3),
                       new Aluno(4, "Renan", "Rocha Oliveira", "RenanRochaOliveira@rhyta.com", "2384-4677", 4)
                    });

            builder.Entity<Tutor>()
                   .HasData(new List<Tutor>(){
                       new Tutor(1, "Kaua Melo Lima"),
                       new Tutor(2, "Antônio Santos Rodrigues"),
                       new Tutor(3, "Vitor Ribeiro Rocha"),
                       new Tutor(4, "Caio Correia Almeida")
                    });

            builder.Entity<Cartao>()
                   .HasData(new List<Cartao>(){
                       new Cartao(1, "5369 3512 5614 9320", "26/08/2022", "754", 1),
                       new Cartao(2, "5449 1767 6344 0266", "26/11/2021", "570", 3),
                       new Cartao(3, "5277 5975 2779 7914", "26/09/2022", "854", 2),
                       new Cartao(4, "5370 9134 5448 2295", "26/01/2023", "413", 4)
                    });

            builder.Entity<Curso>()
                   .HasData(new List<Curso>(){
                       new Curso(1, "Fisioterapia", 15000, 0, 3),
                       new Curso(2, "Psicologia", 350, 10, 2),
                       new Curso(3, "Gestão da Informação", 550, 0, 1),
                       new Curso(4, "Tecnologia da Informação (TI)", 250, 0, 4)
                    });

            builder.Entity<AlunoCurso>()
                   .HasData(new List<AlunoCurso>() {
                       new AlunoCurso() {AlunoId = 1, CursoId = 2, situacao = "pago"},
                       new AlunoCurso() {AlunoId = 2, CursoId = 1, situacao = "aguardado pagamento"},
                       new AlunoCurso() {AlunoId = 3, CursoId = 2, situacao = "pago"},
                       new AlunoCurso() {AlunoId = 2, CursoId = 2, situacao = "pago"},
                       new AlunoCurso() {AlunoId = 3, CursoId = 4, situacao = "pago"},
                       new AlunoCurso() {AlunoId = 1, CursoId = 3, situacao = "pago"},
                       new AlunoCurso() {AlunoId = 2, CursoId = 3, situacao = "aguardado pagamento"}
                    });



        }

    }
}