namespace PlatformCourse.WebApi.Models
{
    public class AlunoCurso{
        public AlunoCurso() { }

        public AlunoCurso(int alunoId, int cursoId, int parcelas, int parcelasPagas, string situacao){
            this.AlunoId = alunoId;
            this.CursoId = cursoId;
            this.situacao = situacao;
            this.parcelas = parcelas;
            this.parcelasPagas = parcelasPagas;
        }
        public int AlunoId { get; set; }
        public Aluno aluno { get; set; }
        public int CursoId { get; set; }
        public Curso curso { get; set; }
        public int parcelas { get; set; }
        public int parcelasPagas { get; set; }
        public string situacao { get; set; }
    }
}