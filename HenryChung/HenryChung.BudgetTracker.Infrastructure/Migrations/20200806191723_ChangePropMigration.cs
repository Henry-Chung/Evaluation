using Microsoft.EntityFrameworkCore.Migrations;

namespace HenryChung.BudgetTracker.Infrastructure.Migrations
{
    public partial class ChangePropMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenditures_Users_UsersId",
                table: "Expenditures");

            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_Users_UsersId",
                table: "Incomes");

            migrationBuilder.DropIndex(
                name: "IX_Incomes_UsersId",
                table: "Incomes");

            migrationBuilder.DropIndex(
                name: "IX_Expenditures_UsersId",
                table: "Expenditures");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Incomes");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Expenditures");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_UserId",
                table: "Incomes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenditures_UserId",
                table: "Expenditures",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenditures_Users_UserId",
                table: "Expenditures",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_Users_UserId",
                table: "Incomes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenditures_Users_UserId",
                table: "Expenditures");

            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_Users_UserId",
                table: "Incomes");

            migrationBuilder.DropIndex(
                name: "IX_Incomes_UserId",
                table: "Incomes");

            migrationBuilder.DropIndex(
                name: "IX_Expenditures_UserId",
                table: "Expenditures");

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "Incomes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "Expenditures",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_UsersId",
                table: "Incomes",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenditures_UsersId",
                table: "Expenditures",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenditures_Users_UsersId",
                table: "Expenditures",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_Users_UsersId",
                table: "Incomes",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
