using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Railwaiy_Eproject.Data.Migrations
{
    /// <inheritdoc />
    public partial class TrainMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Train",
                columns: table => new
                {
                    No_of_Compartments = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    No_of_Seats = table.Column<int>(type: "int", nullable: false),
                    TrainCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Train_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    One_AC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Two_AC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Three_AC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sleeper = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Train", x => x.No_of_Compartments);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Train");
        }
    }
}
