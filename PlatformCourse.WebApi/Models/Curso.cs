using System.Collections.Generic;
namespace PlatformCourse.WebApi.Models{
    public class Curso{
        public Curso(){ }          
        public Curso(int id, string nome, float preco, int desconto, int tutorId) {
                this.Id = id;
                this.Nome = nome;
                this.preco = preco;
                this.desconto = desconto;
                this.TutorId = tutorId;                
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public float preco { get; set; }
        public int desconto { get; set; }
        public int TutorId { get; set; }
        public Tutor tutor { get; set; }
        public IEnumerable<AlunoCurso> AlunosCursos { get; set; }
    }
}