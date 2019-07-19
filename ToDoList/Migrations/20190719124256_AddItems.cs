using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoList.Migrations
{
    public partial class AddItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    //UserName = table.Column<string>(nullable: true),
                    //NormalizedUserName = table.Column<string>(nullable: true),
                    //Email = table.Column<string>(nullable: true),
                    //NormalizedEmail = table.Column<string>(nullable: true),
                    //EmailConfirmed = table.Column<bool>(nullable: false),
                    //PasswordHash = table.Column<string>(nullable: true),
                    //SecurityStamp = table.Column<string>(nullable: true),
                    //ConcurrencyStamp = table.Column<string>(nullable: true),
                    //PhoneNumber = table.Column<string>(nullable: true),
                    //PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    //TwoFactorEnabled = table.Column<bool>(nullable: false),
                    //LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    //LockoutEnabled = table.Column<bool>(nullable: false),
                    //AccessFailedCount = table.Column<int>(nullable: false),
                    IsDone = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    DueAt = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
