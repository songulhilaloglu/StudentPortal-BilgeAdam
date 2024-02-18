using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentPortal_DataAccess.IdentityContext.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f38a670-2f7b-4e35-99d4-357018ff35fe", null, "teacher", "TEACHER" },
                    { "32f065e3-1790-4b27-95cf-948252f5d0d6", null, "hrPersonal", "HRPERSONAL" },
                    { "4554501c-499a-47ef-b2cf-60dfffa42aa9", null, "student", "STUDENT" },
                    { "6bebcad2-b4b3-46ed-b437-dbb5d4373229", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { "2de7310f-a715-4887-9919-7ccd29cf474a", 0, "3189c8aa-fd0b-44a9-beb4-44cf75098bff", new DateTime(2024, 2, 17, 20, 57, 13, 682, DateTimeKind.Local).AddTicks(6614), null, "teacher@test.com", false, false, null, "TEACHER@TEST.COM", "TEACHER", "AQAAAAIAAYagAAAAEKbmHIdvbWxMF4N8VVXMGrHANDXTxGtDeT1RZuEaaU1AHelElJta/MM6Szh3B/+hkA==", null, false, "96226f8a-b3ed-4098-b341-c993e6254d08", 1, false, null, "teacher" },
                    { "7c84991e-f980-4c42-8c08-f0c1fad65547", 0, "4bb9adc3-8156-44e7-b79f-c1d8e93e5c50", new DateTime(2024, 2, 17, 20, 57, 13, 616, DateTimeKind.Local).AddTicks(1291), null, "student2@test.com", false, false, null, "STUDENT2@TEST.COM", "STUDENT2", "AQAAAAIAAYagAAAAEOfkx1o065nJgsiYMyE8hngLbNRYdC//3ss52fhVUBJRAHbVlplFoFTIXDMOXyTXQQ==", null, false, "b12056b6-ce37-4dd5-a12a-4b3e502bda8f", 1, false, null, "student2" },
                    { "81debc83-817b-4c81-8d04-b1a822be78c9", 0, "54048abf-ed6a-4cd5-88d8-ecfe836dc96c", new DateTime(2024, 2, 17, 20, 57, 13, 548, DateTimeKind.Local).AddTicks(3438), null, "student@test.com", false, false, null, "STUDENT@TEST.COM", "STUDENT", "AQAAAAIAAYagAAAAEDBlPVF/LKwb2t1vhFjFSlHHinBD3uR4dpZkcNpZWJbg/olqjXxYIdAOa15UeinZRw==", null, false, "8ed69bfe-ccd2-44d6-a9f5-2e558f2e77dc", 1, false, null, "student" },
                    { "b07931af-b4ed-4e01-9a06-9560d31ab594", 0, "b8aee377-0d5e-4f0e-8865-e8200173e217", new DateTime(2024, 2, 17, 20, 57, 13, 751, DateTimeKind.Local).AddTicks(8472), null, "hrPersonel@test.com", false, false, null, "HRPERSONEL@TEST.COM", "HRPERSONEL", "AQAAAAIAAYagAAAAEF1yXlDsdWG1WSZw2JTekvWMjCkBMrENNqTnB2V745UNbPuyOliwL6qZcsvjHiiWpQ==", null, false, "ef2d6179-be15-4609-a1bc-5d31eaf5cd94", 1, false, null, "hrPersonel" },
                    { "b6e412f3-9b23-4a20-a1af-d5babfd75db5", 0, "58351ba3-8700-4eeb-9735-580f0e4ae814", new DateTime(2024, 2, 17, 20, 57, 13, 479, DateTimeKind.Local).AddTicks(6364), null, "admin@test.com", false, false, null, "ADMIN@TEST.COM", "ADMIN", "AQAAAAIAAYagAAAAEL+2oRuv/SohiaeeM2SJn1zEojJwcgtC6vKPMKutLycnfEsSqLwARFLftQ2eZ0xvzg==", null, false, "269d1441-fcde-43f5-b20f-ff1256a421c6", 1, false, null, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0f38a670-2f7b-4e35-99d4-357018ff35fe", "2de7310f-a715-4887-9919-7ccd29cf474a" },
                    { "4554501c-499a-47ef-b2cf-60dfffa42aa9", "7c84991e-f980-4c42-8c08-f0c1fad65547" },
                    { "4554501c-499a-47ef-b2cf-60dfffa42aa9", "81debc83-817b-4c81-8d04-b1a822be78c9" },
                    { "32f065e3-1790-4b27-95cf-948252f5d0d6", "b07931af-b4ed-4e01-9a06-9560d31ab594" },
                    { "6bebcad2-b4b3-46ed-b437-dbb5d4373229", "b6e412f3-9b23-4a20-a1af-d5babfd75db5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
