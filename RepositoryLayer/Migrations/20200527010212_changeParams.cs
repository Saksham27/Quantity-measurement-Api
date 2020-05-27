using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class changeParams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value_Two_Unit",
                table: "Comparisons",
                newName: "ValueTwoUnit");

            migrationBuilder.RenameColumn(
                name: "Value_Two",
                table: "Comparisons",
                newName: "ValueTwo");

            migrationBuilder.RenameColumn(
                name: "Value_One_Unit",
                table: "Comparisons",
                newName: "ValueOneUnit");

            migrationBuilder.RenameColumn(
                name: "Value_One",
                table: "Comparisons",
                newName: "ValueOne");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ValueTwoUnit",
                table: "Comparisons",
                newName: "Value_Two_Unit");

            migrationBuilder.RenameColumn(
                name: "ValueTwo",
                table: "Comparisons",
                newName: "Value_Two");

            migrationBuilder.RenameColumn(
                name: "ValueOneUnit",
                table: "Comparisons",
                newName: "Value_One_Unit");

            migrationBuilder.RenameColumn(
                name: "ValueOne",
                table: "Comparisons",
                newName: "Value_One");
        }
    }
}
