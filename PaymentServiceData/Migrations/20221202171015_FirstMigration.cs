using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentServiceData.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Key",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    KeyType = table.Column<int>(nullable: false),
                    Description = table.Column<string>(type: "varchar(1000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Key", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payer",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    KeyId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(type: "varchar(1000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payer_Key_KeyId",
                        column: x => x.KeyId,
                        principalTable: "Key",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Receiver",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    KeyId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(type: "varchar(1000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receiver", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receiver_Key_KeyId",
                        column: x => x.KeyId,
                        principalTable: "Key",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "date", nullable: false),
                    PayerId1 = table.Column<Guid>(nullable: false),
                    PayerId = table.Column<int>(nullable: false),
                    ReceiverId1 = table.Column<Guid>(nullable: false),
                    ReceiverId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transaction_Payer_PayerId1",
                        column: x => x.PayerId1,
                        principalTable: "Payer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transaction_Receiver_ReceiverId1",
                        column: x => x.ReceiverId1,
                        principalTable: "Receiver",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payer_KeyId",
                table: "Payer",
                column: "KeyId");

            migrationBuilder.CreateIndex(
                name: "IX_Receiver_KeyId",
                table: "Receiver",
                column: "KeyId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_PayerId1",
                table: "Transaction",
                column: "PayerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_ReceiverId1",
                table: "Transaction",
                column: "ReceiverId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "Payer");

            migrationBuilder.DropTable(
                name: "Receiver");

            migrationBuilder.DropTable(
                name: "Key");
        }
    }
}
