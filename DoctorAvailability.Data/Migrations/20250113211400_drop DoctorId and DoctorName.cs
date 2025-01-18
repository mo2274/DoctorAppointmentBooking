using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorAvailability.Data.Migrations
{
    /// <inheritdoc />
    public partial class dropDoctorIdandDoctorName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoctorId",
                schema: "DoctorAvailabilities",
                table: "Slots");

            migrationBuilder.DropColumn(
                name: "DoctorName",
                schema: "DoctorAvailabilities",
                table: "Slots");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DoctorId",
                schema: "DoctorAvailabilities",
                table: "Slots",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "DoctorName",
                schema: "DoctorAvailabilities",
                table: "Slots",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
