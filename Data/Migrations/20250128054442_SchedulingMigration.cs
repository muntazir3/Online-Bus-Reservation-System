using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Railwaiy_Eproject.Data.Migrations
{
    /// <inheritdoc />
    public partial class SchedulingMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scheduling",
                columns: table => new
                {
                    StartStation = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EndStation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntermediateStation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalDistance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArrivalTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartureTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Train_Id = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scheduling", x => x.StartStation);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scheduling");
        }
    }
}
