using System.Collections.Generic;
namespace PlatformCourse.WebApi.Models{
    public class Cartao{
        public Cartao(){ }
        public Cartao(int id, string numero, string vencimento, string cvc, int alunoId) {
                this.Id = id;
                this.numero = numero;
                this.vencimento = vencimento;
                this.CVC = cvc;
        }
        public int Id { get; set; }
        public string numero { get; set; }
        public string vencimento { get; set; }
        public string CVC { get; set; }
        public IEnumerable<Aluno> Alunos {get; set; }
    }
}