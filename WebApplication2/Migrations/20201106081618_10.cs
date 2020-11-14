using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class _10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Position_PosID",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "ReturnedBook");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Reader");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_PosID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PubAddress",
                table: "Publisher");

            migrationBuilder.DropColumn(
                name: "PubCity",
                table: "Publisher");

            migrationBuilder.DropColumn(
                name: "PubName",
                table: "Publisher");

            migrationBuilder.DropColumn(
                name: "PosDuties",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "PosName",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "PosRequirements",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "PosSalary",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "EmpAddress",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmpAge",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmpFullName",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmpPassportData",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmpPhoneNumber",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmpSex",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PosID",
                table: "Employee");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "employees");

            migrationBuilder.AddColumn<long>(
                name: "EmployeeID",
                table: "Publisher",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "adress",
                table: "Publisher",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "amount",
                table: "Publisher",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "amountOfTheRefund",
                table: "Publisher",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "conDate",
                table: "Publisher",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "mark",
                table: "Publisher",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Publisher",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "pasportData",
                table: "Publisher",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "Publisher",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "retDate",
                table: "Publisher",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "duties",
                table: "Position",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Position",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "requirements",
                table: "Position",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "salary",
                table: "Position",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "adress",
                table: "employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "contributionID",
                table: "employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "pasportData",
                table: "employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "employees",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "positionId",
                table: "employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sex",
                table: "employees",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_employees",
                table: "employees",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "currencies",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    exchangeRate = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_currencies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "contributions",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContributionName = table.Column<string>(nullable: true),
                    minTime = table.Column<int>(nullable: false),
                    maxTime = table.Column<int>(nullable: false),
                    InterestRate = table.Column<double>(nullable: false),
                    AdditionalConditions = table.Column<string>(nullable: true),
                    CurrencyID = table.Column<long>(nullable: true),
                    EmployeeID = table.Column<long>(nullable: true),
                    DepositorID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contributions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_contributions_currencies_CurrencyID",
                        column: x => x.CurrencyID,
                        principalTable: "currencies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_contributions_Publisher_DepositorID",
                        column: x => x.DepositorID,
                        principalTable: "Publisher",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_contributions_employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Publisher_EmployeeID",
                table: "Publisher",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_positionId",
                table: "employees",
                column: "positionId");

            migrationBuilder.CreateIndex(
                name: "IX_contributions_CurrencyID",
                table: "contributions",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_contributions_DepositorID",
                table: "contributions",
                column: "DepositorID");

            migrationBuilder.CreateIndex(
                name: "IX_contributions_EmployeeID",
                table: "contributions",
                column: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_Position_positionId",
                table: "employees",
                column: "positionId",
                principalTable: "Position",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Publisher_employees_EmployeeID",
                table: "Publisher",
                column: "EmployeeID",
                principalTable: "employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_Position_positionId",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Publisher_employees_EmployeeID",
                table: "Publisher");

            migrationBuilder.DropTable(
                name: "contributions");

            migrationBuilder.DropTable(
                name: "currencies");

            migrationBuilder.DropIndex(
                name: "IX_Publisher_EmployeeID",
                table: "Publisher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_employees",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_positionId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Publisher");

            migrationBuilder.DropColumn(
                name: "adress",
                table: "Publisher");

            migrationBuilder.DropColumn(
                name: "amount",
                table: "Publisher");

            migrationBuilder.DropColumn(
                name: "amountOfTheRefund",
                table: "Publisher");

            migrationBuilder.DropColumn(
                name: "conDate",
                table: "Publisher");

            migrationBuilder.DropColumn(
                name: "mark",
                table: "Publisher");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Publisher");

            migrationBuilder.DropColumn(
                name: "pasportData",
                table: "Publisher");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "Publisher");

            migrationBuilder.DropColumn(
                name: "retDate",
                table: "Publisher");

            migrationBuilder.DropColumn(
                name: "duties",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "requirements",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "salary",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "adress",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "age",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "contributionID",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "name",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "pasportData",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "positionId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "sex",
                table: "employees");

            migrationBuilder.RenameTable(
                name: "employees",
                newName: "Employee");

            migrationBuilder.AddColumn<string>(
                name: "PubAddress",
                table: "Publisher",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PubCity",
                table: "Publisher",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PubName",
                table: "Publisher",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PosDuties",
                table: "Position",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PosName",
                table: "Position",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PosRequirements",
                table: "Position",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PosSalary",
                table: "Position",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "EmpAddress",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "EmpAge",
                table: "Employee",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "EmpFullName",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmpPassportData",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmpPhoneNumber",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmpSex",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PosID",
                table: "Employee",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Reader",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RdAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RdBdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RdFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RdPassportData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RdPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RdSex = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reader", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BkAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BkName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BkRealiseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GenreId = table.Column<long>(type: "bigint", nullable: true),
                    PublisherID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Book_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Book_Publisher_PublisherID",
                        column: x => x.PublisherID,
                        principalTable: "Publisher",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReturnedBook",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BkId = table.Column<long>(type: "bigint", nullable: false),
                    EmpId = table.Column<long>(type: "bigint", nullable: false),
                    RbGiveOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RbReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RbReturnFlag = table.Column<bool>(type: "bit", nullable: false),
                    RdId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnedBook", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReturnedBook_Book_BkId",
                        column: x => x.BkId,
                        principalTable: "Book",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReturnedBook_Employee_EmpId",
                        column: x => x.EmpId,
                        principalTable: "Employee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReturnedBook_Reader_RdId",
                        column: x => x.RdId,
                        principalTable: "Reader",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PosID",
                table: "Employee",
                column: "PosID");

            migrationBuilder.CreateIndex(
                name: "IX_Book_GenreId",
                table: "Book",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_PublisherID",
                table: "Book",
                column: "PublisherID");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnedBook_BkId",
                table: "ReturnedBook",
                column: "BkId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnedBook_EmpId",
                table: "ReturnedBook",
                column: "EmpId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnedBook_RdId",
                table: "ReturnedBook",
                column: "RdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Position_PosID",
                table: "Employee",
                column: "PosID",
                principalTable: "Position",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
