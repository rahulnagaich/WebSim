using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSim.Persistence.Migrations
{
    public partial class CreateUsersDomain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: false),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(maxLength: 4000, nullable: true),
                    SecurityStamp = table.Column<string>(maxLength: 4000, nullable: true),
                    LockoutEndDateUtc = table.Column<DateTime>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    IsStatic = table.Column<bool>(nullable: false),
                    ResetPassword = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<Guid>(nullable: true),
                    LastModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedBy = table.Column<Guid>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
