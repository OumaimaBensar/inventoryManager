using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryM.Migrations
{
    /// <inheritdoc />
    public partial class mgrationone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    roleid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    rolename = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.roleid);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KeepLoggedIn = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "roleuser",
                columns: table => new
                {
                    rolesroleid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    usersUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roleuser", x => new { x.rolesroleid, x.usersUserId });
                    table.ForeignKey(
                        name: "FK_roleuser_Roles_rolesroleid",
                        column: x => x.rolesroleid,
                        principalTable: "Roles",
                        principalColumn: "roleid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_roleuser_Users_usersUserId",
                        column: x => x.usersUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_roleuser_usersUserId",
                table: "roleuser",
                column: "usersUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "roleuser");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
