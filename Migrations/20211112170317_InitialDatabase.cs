using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoQuiz.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quiz",
                columns: table => new
                {
                    idQuiz = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(nullable: true),
                    titulo = table.Column<string>(nullable: true),
                    ques1 = table.Column<string>(nullable: true),
                    ques2 = table.Column<string>(nullable: true),
                    ques3 = table.Column<string>(nullable: true),
                    ques4 = table.Column<string>(nullable: true),
                    respCerta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quiz", x => x.idQuiz);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quiz");
        }
    }
}
