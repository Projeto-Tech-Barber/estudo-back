using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Surferbot.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Criacao_Tabela_Clientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Cpf = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Endereco = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Estado = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Cidade = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Cep = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Plano = table.Column<int>(type: "integer", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
