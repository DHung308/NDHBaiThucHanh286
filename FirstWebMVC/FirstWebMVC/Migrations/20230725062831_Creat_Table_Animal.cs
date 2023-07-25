using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstWebMVC.Migrations
{
    /// <inheritdoc />
    public partial class Creat_Table_Animal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    GiongLoai = table.Column<string>(type: "TEXT", nullable: false),
                    XuatXu = table.Column<string>(type: "TEXT", nullable: false),
                    TuoiTho = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.GiongLoai);
                });

            migrationBuilder.CreateTable(
                name: "Cat",
                columns: table => new
                {
                    GiongLoai = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cat", x => x.GiongLoai);
                    table.ForeignKey(
                        name: "FK_Cat_Animal_GiongLoai",
                        column: x => x.GiongLoai,
                        principalTable: "Animal",
                        principalColumn: "GiongLoai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dog",
                columns: table => new
                {
                    GiongLoai = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dog", x => x.GiongLoai);
                    table.ForeignKey(
                        name: "FK_Dog_Animal_GiongLoai",
                        column: x => x.GiongLoai,
                        principalTable: "Animal",
                        principalColumn: "GiongLoai",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cat");

            migrationBuilder.DropTable(
                name: "Dog");

            migrationBuilder.DropTable(
                name: "Animal");
        }
    }
}
