using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Login.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TraCuuC12",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    STT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NoiDung = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    BHXH_OD_TS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BHXH_HTTT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BHYT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BHTN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BHTNLD_BNN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    userName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraCuuC12", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TraCuuC12");
        }
    }
}
