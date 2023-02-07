using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantReservation.Server.Migrations
{
    public partial class newdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spotlights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpotlightHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spotlights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeSlot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    RestaurantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpotlightItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpotlightId = table.Column<int>(type: "int", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpotlightItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpotlightItems_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpotlightItems_Spotlights_SpotlightId",
                        column: x => x.SpotlightId,
                        principalTable: "Spotlights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "c93ca134-e484-469e-a57a-cb975e16927b", "CustomerUser", "CUSTOMERUSER" },
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "1134e23c-a0f2-4bbf-9794-9af94de68af9", "Administrator", "ADMINISTRATOR" },
                    { "e660c1e1-9327-4b4a-a449-da5bb9547d0d", "0089f39c-ce99-46d5-afb3-cff206a22959", "RestaurantUser", "RESTAURANTUSER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "3374837f-b5dc-4545-ab32-f5200dc83b7d", "admin@localhost.com", false, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJzYxGI6ZhkRKwSA3dxPqOOSwFgmn+5/geTswSZVjC1aUY5ys+6znpmn39QoWtjxJQ==", null, false, "4aef2571-29cb-4ad5-bc39-736729eb4885", false, "Admin" },
                    { "12db73f8-0dd6-493b-b15d-6701880bf36e", 0, "92c53f02-3c91-41f6-911d-32e98e80b28b", "restaurant@localhost.com", false, false, null, "RESTAURANT@LOCALHOST.COM", "RESTAURANT@LOCALHOST.COM", "AQAAAAEAACcQAAAAEMWCMMPlpTW3UnOARLDx+EmfAyievaqQKMtetMpYIL1GMVLX4CleXQ1MoEL19s3I9w==", null, false, "9dea022d-cf5d-431c-a272-2eb8d6107181", false, "restauranttestuser" },
                    { "ce2cf924-58d3-427f-813a-a6de6bc7400d", 0, "97f47a79-11f3-4256-8f5d-5c08103bfdc1", "customer@localhost.com", false, false, null, "CUSTOMER@LOCALHOST.COM", "CUSTOMER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEFVZAHMBLt6aAU5ULTRXGB+ElKJ/EIUMtYB93oNmdcaSlqrvlEJ7C7UtoxgwR+uX/g==", null, false, "4eae867f-e261-431e-9c1b-3f2725d2e244", false, "customertestuser" },
                    { "cdc39beb-763d-4764-8086-d3d2790f98fd", 0, "b1ec78a7-d0ad-4b50-9e03-a657fdacf57b", "kfc@localhost.com", false, false, null, "KFC@LOCALHOST.COM", "KFC@LOCALHOST.COM", "AQAAAAEAACcQAAAAEOtOjKuNMGSMWRuM4VFixY731pX+JwXm/KPRFcodHTukExy4Qzn3MP9yBhxg2RowDw==", null, false, "d4d04049-105e-4ece-9141-55ea06ee1f1e", false, "KFC" },
                    { "d2e65d50-0175-40ae-b91d-449484f6623a", 0, "f14cea6a-053f-4a32-95b6-c464f42b5cc9", "macs@localhost.com", false, false, null, "MACS@LOCALHOST.COM", "MACS@LOCALHOST.COM", "AQAAAAEAACcQAAAAEFsrLMb4U5FMfQYXdi/Gjt+OpAmRAwMyWC4t89OadOeGwQuQGiZQ4LIycl/MnNc1jQ==", null, false, "17aa677e-a1cc-4179-a41a-3b34bd71168f", false, "MACS" },
                    { "86c52720-1b0d-4f59-b660-9d04357e8653", 0, "e75fd51e-be80-4887-9ff7-75db9dab46f3", "subway@localhost.com", false, false, null, "SUBWAY@LOCALHOST.COM", "SUBWAY@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJeWCSyLuJRhBeS5nHtJB1M6fmRRaEhvdfo/l/j6+kfc8JASXV6AxF+BCq8ZPACWUQ==", null, false, "0d269921-fbb7-4cb7-8fb2-44f9c0dfd5c6", false, "Subway" },
                    { "d5de43ef-33a1-48c2-ac88-b2d9b4ef6d49", 0, "49fed972-831e-4776-adb9-98a596574840", "John@localhost.com", false, false, null, "JOHN@LOCALHOST.COM", "JOHN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJiq2uInSpG84+0xqkUObRzfdXmDq5RZITd93An/dzU9KXN/b3xs6c3saFr3hQAjtQ==", null, false, "d40194e5-9780-4ecd-bdb1-617fdc219db7", false, "John" },
                    { "63320eb6-1c7b-439e-9e4f-99b47a240472", 0, "fef9353e-f6a7-44f7-88de-2889366d50f0", "Peter@localhost.com", false, false, null, "PETER@LOCALHOST.COM", "PETER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEE3zt7KbFqZsy39SpglO9SguvI+KTb9Sl0zvMfkAnZsdxpKfJR7dj6ywvaSYSnrdnw==", null, false, "045d423d-2796-48bf-a3a0-da5f6b390a42", false, "Peter" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Category", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Name", "UpdatedBy", "UserId", "UserName" },
                values: new object[,]
                {
                    { 1, "Food", "System", new DateTime(2023, 2, 7, 8, 53, 2, 144, DateTimeKind.Local).AddTicks(4253), new DateTime(2023, 2, 7, 8, 53, 2, 144, DateTimeKind.Local).AddTicks(4259), "We sell food", "Admin's Restaurant", "System", "3781efa7-66dc-47f0-860f-e506d04102e4", "Admin" },
                    { 2, "Fast Food", "System", new DateTime(2023, 2, 7, 8, 53, 2, 144, DateTimeKind.Local).AddTicks(4597), new DateTime(2023, 2, 7, 8, 53, 2, 144, DateTimeKind.Local).AddTicks(4601), "We sell fried chicken", "Kentucky Fried Chicken", "System", "cdc39beb-763d-4764-8086-d3d2790f98fd", "KFC" },
                    { 3, "Fast Food", "System", new DateTime(2023, 2, 7, 8, 53, 2, 144, DateTimeKind.Local).AddTicks(4607), new DateTime(2023, 2, 7, 8, 53, 2, 144, DateTimeKind.Local).AddTicks(4607), "We sell burgers and fries", "Mac Donalds", "System", "d2e65d50-0175-40ae-b91d-449484f6623a", "MACS" },
                    { 4, "Fast Food", "System", new DateTime(2023, 2, 7, 8, 53, 2, 144, DateTimeKind.Local).AddTicks(4610), new DateTime(2023, 2, 7, 8, 53, 2, 144, DateTimeKind.Local).AddTicks(4611), "We sell sandwiches", "Subway", "System", "86c52720-1b0d-4f59-b660-9d04357e8653", "Subway" }
                });

            migrationBuilder.InsertData(
                table: "Spotlights",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "SpotlightHeader", "UpdatedBy" },
                values: new object[] { 1, "System", new DateTime(2023, 2, 7, 8, 53, 2, 145, DateTimeKind.Local).AddTicks(1268), new DateTime(2023, 2, 7, 8, 53, 2, 145, DateTimeKind.Local).AddTicks(1275), "Fast Food", "System" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" },
                    { "e660c1e1-9327-4b4a-a449-da5bb9547d0d", "12db73f8-0dd6-493b-b15d-6701880bf36e" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "ce2cf924-58d3-427f-813a-a6de6bc7400d" },
                    { "e660c1e1-9327-4b4a-a449-da5bb9547d0d", "cdc39beb-763d-4764-8086-d3d2790f98fd" },
                    { "e660c1e1-9327-4b4a-a449-da5bb9547d0d", "d2e65d50-0175-40ae-b91d-449484f6623a" },
                    { "e660c1e1-9327-4b4a-a449-da5bb9547d0d", "86c52720-1b0d-4f59-b660-9d04357e8653" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "d5de43ef-33a1-48c2-ac88-b2d9b4ef6d49" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "63320eb6-1c7b-439e-9e4f-99b47a240472" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Pax", "ReservationDate", "RestaurantId", "RestaurantName", "TimeSlot", "UpdatedBy", "UserId", "UserName" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 2, 7, 8, 53, 2, 143, DateTimeKind.Local).AddTicks(7691), new DateTime(2023, 2, 7, 8, 53, 2, 143, DateTimeKind.Local).AddTicks(7956), "3", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Kentucky Fried Chicken", "1400-1600", "System", "d5de43ef-33a1-48c2-ac88-b2d9b4ef6d49", "John" },
                    { 2, "System", new DateTime(2023, 2, 7, 8, 53, 2, 143, DateTimeKind.Local).AddTicks(9074), new DateTime(2023, 2, 7, 8, 53, 2, 143, DateTimeKind.Local).AddTicks(9076), "4", new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Mac Donalds", "1200-1400", "System", "63320eb6-1c7b-439e-9e4f-99b47a240472", "Peter" }
                });

            migrationBuilder.InsertData(
                table: "SpotlightItems",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "ExpireDate", "RestaurantId", "SpotlightId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 2, 7, 8, 53, 2, 144, DateTimeKind.Local).AddTicks(8820), new DateTime(2023, 2, 7, 8, 53, 2, 144, DateTimeKind.Local).AddTicks(8825), new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "System" },
                    { 2, "System", new DateTime(2023, 2, 7, 8, 53, 2, 144, DateTimeKind.Local).AddTicks(8931), new DateTime(2023, 2, 7, 8, 53, 2, 144, DateTimeKind.Local).AddTicks(8932), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, "System" },
                    { 3, "System", new DateTime(2023, 2, 7, 8, 53, 2, 144, DateTimeKind.Local).AddTicks(8938), new DateTime(2023, 2, 7, 8, 53, 2, 144, DateTimeKind.Local).AddTicks(8939), new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, "System" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RestaurantId",
                table: "Reservations",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_SpotlightItems_RestaurantId",
                table: "SpotlightItems",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_SpotlightItems_SpotlightId",
                table: "SpotlightItems",
                column: "SpotlightId");
        }

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
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "SpotlightItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Spotlights");
        }
    }
}
