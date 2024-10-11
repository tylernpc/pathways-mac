using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ef_test.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YourEntities",
                columns: table => new
                {
                    account_id = table.Column<string>(type: "text", nullable: false),
                    email_address = table.Column<string>(type: "text", nullable: false),
                    account_type = table.Column<string>(type: "text", nullable: false),
                    annual_fee = table.Column<int>(type: "integer", nullable: false),
                    total_amount_spent = table.Column<double>(type: "double precision", nullable: false),
                    type_of_nonprofit = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YourEntities", x => x.account_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YourEntities");
        }
    }
}
