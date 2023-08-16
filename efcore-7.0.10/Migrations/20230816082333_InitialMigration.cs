using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace efcore_7._0._10.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ISSUE",
                columns: table => new
                {
                    ISSUE_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NAME = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    WEIGHT = table.Column<double>(type: "BINARY_DOUBLE", nullable: true),
                    IS_DELETED = table.Column<int>(type: "NUMBER(1)", precision: 1, nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ISSUE", x => x.ISSUE_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ISSUE");
        }
    }
}
