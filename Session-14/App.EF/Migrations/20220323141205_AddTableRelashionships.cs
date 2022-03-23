using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.EF.Migrations
{
    public partial class AddTableRelashionships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "ManagerID",
                table: "Engineers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CarID",
                table: "Transactions",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CustomerID",
                table: "Transactions",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ManagerID",
                table: "Transactions",
                column: "ManagerID");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLines_EngineerID",
                table: "TransactionLines",
                column: "EngineerID");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLines_ServiceTaskID",
                table: "TransactionLines",
                column: "ServiceTaskID");

            migrationBuilder.CreateIndex(
                name: "IX_Engineers_ManagerID",
                table: "Engineers",
                column: "ManagerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Engineers_Managers_ManagerID",
                table: "Engineers",
                column: "ManagerID",
                principalTable: "Managers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLines_Engineers_EngineerID",
                table: "TransactionLines",
                column: "EngineerID",
                principalTable: "Engineers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLines_ServiceTasks_ServiceTaskID",
                table: "TransactionLines",
                column: "ServiceTaskID",
                principalTable: "ServiceTasks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Cars_CarID",
                table: "Transactions",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Customers_CustomerID",
                table: "Transactions",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Managers_ManagerID",
                table: "Transactions",
                column: "ManagerID",
                principalTable: "Managers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engineers_Managers_ManagerID",
                table: "Engineers");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLines_Engineers_EngineerID",
                table: "TransactionLines");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLines_ServiceTasks_ServiceTaskID",
                table: "TransactionLines");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Cars_CarID",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Customers_CustomerID",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Managers_ManagerID",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_CarID",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_CustomerID",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_ManagerID",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_TransactionLines_EngineerID",
                table: "TransactionLines");

            migrationBuilder.DropIndex(
                name: "IX_TransactionLines_ServiceTaskID",
                table: "TransactionLines");

            migrationBuilder.DropIndex(
                name: "IX_Engineers_ManagerID",
                table: "Engineers");

            migrationBuilder.AlterColumn<Guid>(
                name: "ManagerID",
                table: "Engineers",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }
    }
}
