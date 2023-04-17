using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Øvelse8._1.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        //    migrationBuilder.CreateTable(
        //        name: "Person",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            Age = table.Column<string>(type: "nvarchar(max)", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Person", x => x.Id);
        //        });

        //    migrationBuilder.InsertData(
        //        table: "Person",
        //        columns: new[] { "Id", "Age", "Name" },
        //        values: new object[] { -1, "40", "Bob" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
