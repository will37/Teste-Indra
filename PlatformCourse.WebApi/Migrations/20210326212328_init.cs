using Microsoft.EntityFrameworkCore.Migrations;

namespace PlatformCourse.WebApi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cartoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    numero = table.Column<string>(nullable: true),
                    vencimento = table.Column<string>(nullable: true),
                    CVC = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cartoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tutores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    CartaoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Alunos_Cartoes_CartaoId",
                        column: x => x.CartaoId,
                        principalTable: "Cartoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    preco = table.Column<float>(nullable: false),
                    desconto = table.Column<int>(nullable: false),
                    TutorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cursos_Tutores_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlunosCursos",
                columns: table => new
                {
                    AlunoId = table.Column<int>(nullable: false),
                    CursoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunosCursos", x => new { x.AlunoId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_AlunosCursos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunosCursos_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cartoes",
                columns: new[] { "Id", "CVC", "numero", "vencimento" },
                values: new object[] { 1, "754", "5369 3512 5614 9320", "26/08/2022" });

            migrationBuilder.InsertData(
                table: "Cartoes",
                columns: new[] { "Id", "CVC", "numero", "vencimento" },
                values: new object[] { 2, "570", "5449 1767 6344 0266", "26/11/2021" });

            migrationBuilder.InsertData(
                table: "Cartoes",
                columns: new[] { "Id", "CVC", "numero", "vencimento" },
                values: new object[] { 3, "854", "5277 5975 2779 7914", "26/09/2022" });

            migrationBuilder.InsertData(
                table: "Cartoes",
                columns: new[] { "Id", "CVC", "numero", "vencimento" },
                values: new object[] { 4, "413", "5370 9134 5448 2295", "26/01/2023" });

            migrationBuilder.InsertData(
                table: "Tutores",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Kaua Melo Lima" });

            migrationBuilder.InsertData(
                table: "Tutores",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "Antônio Santos Rodrigues" });

            migrationBuilder.InsertData(
                table: "Tutores",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 3, "Vitor Ribeiro Rocha" });

            migrationBuilder.InsertData(
                table: "Tutores",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 4, "Caio Correia Almeida" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "id", "CartaoId", "Email", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 1, 1, "VitoriaAlvesCosta@armyspy.com", "Vitoria", "Alves Costa", "5259-9477" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "id", "CartaoId", "Email", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 2, 2, "AlexSousaPinto@rhyta.com", "Alex", "Sousa Pinto", "5974-7598" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "id", "CartaoId", "Email", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 3, 3, "LaraFerreiraBarros@armyspy.com", "Lara", "Ferreira Barros", "4850-9411" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "id", "CartaoId", "Email", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 4, 4, "RenanRochaOliveira@rhyta.com", "Renan", "Rocha Oliveira", "2384-4677" });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "Id", "Nome", "TutorId", "desconto", "preco" },
                values: new object[] { 3, "Gestão da Informação", 1, 0, 550f });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "Id", "Nome", "TutorId", "desconto", "preco" },
                values: new object[] { 2, "Psicologia", 2, 10, 350f });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "Id", "Nome", "TutorId", "desconto", "preco" },
                values: new object[] { 1, "Fisioterapia", 3, 0, 500f });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "Id", "Nome", "TutorId", "desconto", "preco" },
                values: new object[] { 4, "Tecnologia da Informação (TI)", 4, 0, 250f });

            migrationBuilder.InsertData(
                table: "AlunosCursos",
                columns: new[] { "AlunoId", "CursoId" },
                values: new object[] { 1, 3 });

            migrationBuilder.InsertData(
                table: "AlunosCursos",
                columns: new[] { "AlunoId", "CursoId" },
                values: new object[] { 2, 3 });

            migrationBuilder.InsertData(
                table: "AlunosCursos",
                columns: new[] { "AlunoId", "CursoId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "AlunosCursos",
                columns: new[] { "AlunoId", "CursoId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "AlunosCursos",
                columns: new[] { "AlunoId", "CursoId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "AlunosCursos",
                columns: new[] { "AlunoId", "CursoId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "AlunosCursos",
                columns: new[] { "AlunoId", "CursoId" },
                values: new object[] { 3, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_CartaoId",
                table: "Alunos",
                column: "CartaoId");

            migrationBuilder.CreateIndex(
                name: "IX_AlunosCursos_CursoId",
                table: "AlunosCursos",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_TutorId",
                table: "Cursos",
                column: "TutorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunosCursos");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Cartoes");

            migrationBuilder.DropTable(
                name: "Tutores");
        }
    }
}
