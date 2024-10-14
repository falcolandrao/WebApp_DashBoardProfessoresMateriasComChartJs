using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp_DashBoardProfessoresMateriasComChartJs.Migrations
{
    /// <inheritdoc />
    public partial class InsercaoDeDados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Professores",
            columns: new[] { "Nome" },
            values: new object[,]
            {
                { "Professor José Ferreira Monteiro" }
            });

  
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Professores");

            migrationBuilder.Sql("DELETE FROM Materias");
        }
    }
}
