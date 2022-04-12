using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Com.DanLiris.Service.Purchasing.Lib.Migrations
{
    public partial class add_Vat_Correction_EPO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VatId",
                table: "GarmentExternalPurchaseOrders");

            migrationBuilder.DropColumn(
                name: "VatRate",
                table: "GarmentExternalPurchaseOrders");

            migrationBuilder.DropColumn(
                name: "VatId",
                table: "GarmentCorrectionNotes");

            migrationBuilder.DropColumn(
                name: "VatRate",
                table: "GarmentCorrectionNotes");

            migrationBuilder.AddColumn<int>(
                name: "VatId",
                table: "UnitPaymentCorrectionNotes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "VatRate",
                table: "UnitPaymentCorrectionNotes",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "VatId",
                table: "ExternalPurchaseOrders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "VatRate",
                table: "ExternalPurchaseOrders",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VatId",
                table: "UnitPaymentCorrectionNotes");

            migrationBuilder.DropColumn(
                name: "VatRate",
                table: "UnitPaymentCorrectionNotes");

            migrationBuilder.DropColumn(
                name: "VatId",
                table: "ExternalPurchaseOrders");

            migrationBuilder.DropColumn(
                name: "VatRate",
                table: "ExternalPurchaseOrders");

            migrationBuilder.AddColumn<int>(
                name: "VatId",
                table: "GarmentExternalPurchaseOrders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "VatRate",
                table: "GarmentExternalPurchaseOrders",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "VatId",
                table: "GarmentCorrectionNotes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "VatRate",
                table: "GarmentCorrectionNotes",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
