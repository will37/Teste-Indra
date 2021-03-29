using System.Collections.Generic;
namespace PlatformCourse.WebApi.Models{
    public class Aluno{
        public Aluno() {}
        public Aluno(int id, string nome, string Sobrenome, string email, string telefone, int cartaoId){
            this.id = id;
            this.Nome = nome;
            this.Sobrenome = Sobrenome;
            this.Email = email;
            this.Telefone = telefone;
            this.CartaoId = cartaoId;

        }
        public int id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int CartaoId { get; set; }
        public IEnumerable<AlunoCurso> AlunosCursos { get; set; }
    }
}