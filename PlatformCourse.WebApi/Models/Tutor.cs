using System.Collections.Generic;

namespace PlatformCourse.WebApi.Models{
    public class Tutor{
        public Tutor() { }
        public Tutor(int id, string nome){
            this.Id = id;
            this.Nome = nome;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Curso> Cursos { get; set; }
    }
}