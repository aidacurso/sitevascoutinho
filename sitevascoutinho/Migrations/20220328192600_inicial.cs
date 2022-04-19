using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sitevascoutinho.Migrations
{
	public partial class inicial : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Noticia",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
					Corpo = table.Column<string>(type: "nvarchar(max)", nullable: true),
					Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Noticia", x => x.Id);
				});
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Noticia");
		}
	}
}
