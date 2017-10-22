using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Accountingserver.Migrations
{
    public partial class ChangePrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountProgramm",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "PurchaseItems");

            migrationBuilder.AddColumn<bool>(
                name: "Discount",
                table: "Prices",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Prices");

            migrationBuilder.AddColumn<bool>(
                name: "DiscountProgramm",
                table: "Purchases",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Discount",
                table: "PurchaseItems",
                nullable: false,
                defaultValue: false);
        }
    }
}
