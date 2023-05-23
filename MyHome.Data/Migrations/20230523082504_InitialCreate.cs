using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyHome.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    RefreshedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    GroupPhoneNumber = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    GroupEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    GroupName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    GroupAddress = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    GroupUrlSlugIdentifier = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CreatedOnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActivatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsNew = table.Column<bool>(type: "bit", nullable: false),
                    IsSaleAgreed = table.Column<bool>(type: "bit", nullable: false),
                    GroupLogoBgColor = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    GroupPremiumHeadTextColour = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    GroupLogoUrl = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    GroupPremiumLogoUrl = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    GroupPremiumJointLogoUrl = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    GroupRectangularLogoUrl = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    JointGroupRectangularLogoUrl = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    JointGroupPremiumJointLogo = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    GroupUrl = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    IsPremiumAd = table.Column<bool>(type: "bit", nullable: false),
                    IsBuildToRent = table.Column<bool>(type: "bit", nullable: false),
                    IsBuildToRentDevelopment = table.Column<bool>(type: "bit", nullable: false),
                    IsPrivateLandlord = table.Column<bool>(type: "bit", nullable: false),
                    IsBrandBooster = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    SaleTypeId = table.Column<int>(type: "int", nullable: false),
                    IsFavourite = table.Column<bool>(type: "bit", nullable: false),
                    HasVideos = table.Column<bool>(type: "bit", nullable: false),
                    HasWebP = table.Column<bool>(type: "bit", nullable: false),
                    IsMappedAccurately = table.Column<bool>(type: "bit", nullable: false),
                    IsTopSpot = table.Column<bool>(type: "bit", nullable: false),
                    Beds = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SizeStringMeters = table.Column<int>(type: "int", nullable: false),
                    PriceChangeIsIncrease = table.Column<bool>(type: "bit", nullable: false),
                    DisplayAddress = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PropertyClassId = table.Column<int>(type: "int", nullable: false),
                    PropertyClass = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PropertyClassUrlSlug = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PropertyStatus = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PropertyType = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Baths = table.Column<int>(type: "int", nullable: false),
                    BerRating = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EnergyRatingMediaPath = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    OrderedDisplayAddress = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    SeoDisplayAddress = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    BrochureUrl = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    SeoUrl = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PhotoCount = table.Column<int>(type: "int", nullable: false),
                    MainPhoto = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    MainPhotoWeb = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    RelatedPropertiesTotal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalLogo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalLogo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalLogo_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Auction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Auction_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BrochureMaps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    longitude = table.Column<double>(type: "float", nullable: false),
                    latitude = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrochureMaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BrochureMaps_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    IsMyHomePassport = table.Column<bool>(type: "bit", nullable: false),
                    PromotionalSnippet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DevelopmentLogoBgColour = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomDatas_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    Lat = table.Column<double>(type: "float", nullable: false),
                    Lon = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Negotiators",
                columns: table => new
                {
                    NegotiatorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    WebSite = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Negotiators", x => x.NegotiatorId);
                    table.ForeignKey(
                        name: "FK_Negotiators_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OpenViewing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenViewing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpenViewing_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TravelTime",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelTime", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TravelTime_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VirtualViewing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VirtualViewing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VirtualViewing_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RelatedPropertyID",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    CustomDataId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedPropertyID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelatedPropertyID_CustomDatas_CustomDataId",
                        column: x => x.CustomDataId,
                        principalTable: "CustomDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "ActivatedOn", "Address", "Baths", "Beds", "BerRating", "BrochureUrl", "CreatedOnDate", "DisplayAddress", "EnergyRatingMediaPath", "GroupAddress", "GroupEmail", "GroupId", "GroupLogoBgColor", "GroupLogoUrl", "GroupName", "GroupPhoneNumber", "GroupPremiumHeadTextColour", "GroupPremiumJointLogoUrl", "GroupPremiumLogoUrl", "GroupRectangularLogoUrl", "GroupUrl", "GroupUrlSlugIdentifier", "HasVideos", "HasWebP", "IsActive", "IsBrandBooster", "IsBuildToRent", "IsBuildToRentDevelopment", "IsFavourite", "IsMappedAccurately", "IsNew", "IsPremiumAd", "IsPrivateLandlord", "IsSaleAgreed", "IsTopSpot", "JointGroupPremiumJointLogo", "JointGroupRectangularLogoUrl", "MainPhoto", "MainPhotoWeb", "OrderedDisplayAddress", "PhotoCount", "Price", "PriceChangeIsIncrease", "PropertyClass", "PropertyClassId", "PropertyClassUrlSlug", "PropertyStatus", "PropertyType", "RefreshedOn", "RelatedPropertiesTotal", "SaleTypeId", "SeoDisplayAddress", "SeoUrl", "SizeStringMeters" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "46 Ashfield Avenue", 2, 3, "C2", "/residential/brochure/46-ashfield-avenue-kingswood-dublin-24/4690496", new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "//photos-a.propertyimages.ie/static/images/energyRating/C2.png", "6 Village Green, Tallaght, Dublin 24", "tallaght@raycooke.ie", 254910, "#000000", "https://photos-a.propertyimages.ie/groups/0/1/9/254910/logo.jpg", "Ray Cooke Auctioneers", "Ray Cooke Auctioneers", "#FFFFFF", null, null, null, "/estate-agents/ray-cooke-auctioneers-tallaght-254910", "ray-cooke-auctioneers-tallaght", false, false, false, false, false, false, false, false, false, false, false, false, false, null, null, null, null, "46 ashfield avenue kingswood dublin 24", 0, 465000m, false, null, 0, null, null, null, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "46-ashfield-avenue-kingswood-dublin-24", "/residential/brochure/46-ashfield-avenue-kingswood-dublin-24/4690496", 0 },
                    { 2, new DateTime(2023, 3, 31, 9, 0, 0, 0, DateTimeKind.Unspecified), "96 Navan Road", 3, 4, "E2", "/residential/brochure/96-navan-road-navan-road-dublin-7/4690493", new DateTime(2023, 3, 31, 9, 0, 0, 0, DateTimeKind.Unspecified), null, "//photos-a.propertyimages.ie/static/images/energyRating/E2.png", "148 Phibsboro Road, Phibsboro, Dublin 7", "phibsboro@masonestates.ie", 5598, "#70d0f4", "https://photos-a.propertyimages.ie/groups/8/9/5/5598/logo.jpg", "Mason Estates Phibsboro", "Mason Estates Phibsboro", "#FFFFFF", null, null, null, "/estate-agents/mason-estates-phibsboro-5598", "mason-estates-phibsboro", false, false, false, false, false, false, false, false, false, false, false, false, false, null, null, null, null, "96 navan road navan road   dublin 7", 0, 565600m, false, null, 0, null, null, null, new DateTime(2023, 3, 31, 9, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "96-navan-road-navan-road-dublin-7", "/residential/brochure/96-navan-road-navan-road-dublin-7/4690493", 0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "RefreshToken", "RefreshTokenExpiryTime", "UserName" },
                values: new object[] { 1, new byte[] { 254, 140, 18, 228, 138, 174, 63, 69, 233, 192, 76, 27, 3, 126, 225, 111, 119, 90, 234, 146, 8, 184, 81, 8, 9, 95, 51, 112, 199, 242, 43, 157, 158, 179, 248, 146, 97, 0, 116, 46, 213, 192, 90, 219, 3, 21, 211, 255, 61, 105, 211, 211, 57, 209, 57, 174, 135, 0, 88, 250, 206, 248, 188, 73 }, new byte[] { 228, 173, 173, 108, 169, 133, 232, 96, 142, 225, 93, 61, 78, 55, 141, 248, 16, 204, 248, 252, 152, 177, 222, 74, 198, 138, 128, 31, 160, 149, 210, 243, 13, 118, 229, 17, 219, 110, 217, 114, 40, 2, 28, 11, 28, 178, 6, 7, 90, 189, 211, 242, 57, 44, 169, 166, 0, 189, 159, 52, 93, 153, 194, 98, 152, 72, 152, 153, 104, 4, 1, 108, 97, 118, 127, 132, 220, 77, 138, 214, 50, 141, 49, 155, 55, 120, 215, 251, 120, 233, 161, 55, 152, 225, 164, 182, 182, 178, 174, 21, 3, 131, 244, 152, 203, 127, 195, 237, 211, 100, 28, 127, 247, 82, 131, 60, 34, 15, 253, 51, 30, 245, 90, 224, 78, 210, 201, 239 }, null, null, "admin" });

            migrationBuilder.InsertData(
                table: "CustomDatas",
                columns: new[] { "Id", "DevelopmentLogoBgColour", "IsMyHomePassport", "PromotionalSnippet", "PropertyId" },
                values: new object[,]
                {
                    { 1, null, false, null, 1 },
                    { 2, "", false, "", 2 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Lat", "Lon", "PropertyId" },
                values: new object[,]
                {
                    { 1, 0.0, 0.0, 1 },
                    { 2, 0.0, 0.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Negotiators",
                columns: new[] { "NegotiatorId", "Email", "Name", "Phone", "PropertyId", "WebSite" },
                values: new object[,]
                {
                    { 1, "Raycookesales@raycooke.ie", "Ray Cooke Sales", "016875800", 1, "http://www.raycooke.ie" },
                    { 2, "fiona.mcgowan@masongroup.ie", "Fiona McGowan", "01 8304000", 2, "http://www.masonestates.ie/" }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "PhotoURL", "PropertyId", "UploadedBy", "UploadedOn" },
                values: new object[,]
                {
                    { 1, "https://photos-a.propertyimages.ie/media/3/9/4/4690493/ee2ff749-6d34-4f9f-922e-80e225d9cfda_l.jpg", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "https://photos-a.propertyimages.ie/media/3/9/4/4690493/5c9d3934-1f14-4039-a96b-68fe61e94035_l.jpg", 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "https://photos-a.propertyimages.ie/media/6/9/4/4690496/b9f74d3a-fe89-400a-830a-060311ea24a1_l.jpg", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "https://photos-a.propertyimages.ie/media/6/9/4/4690496/48d310d0-de63-4a9b-ae83-db8834c52b59_l.jpg", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalLogo_PropertyId",
                table: "AdditionalLogo",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Auction_PropertyId",
                table: "Auction",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_BrochureMaps_PropertyId",
                table: "BrochureMaps",
                column: "PropertyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomDatas_PropertyId",
                table: "CustomDatas",
                column: "PropertyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_PropertyId",
                table: "Locations",
                column: "PropertyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Negotiators_PropertyId",
                table: "Negotiators",
                column: "PropertyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OpenViewing_PropertyId",
                table: "OpenViewing",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_PropertyId",
                table: "Photos",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedPropertyID_CustomDataId",
                table: "RelatedPropertyID",
                column: "CustomDataId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelTime_PropertyId",
                table: "TravelTime",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_VirtualViewing_PropertyId",
                table: "VirtualViewing",
                column: "PropertyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalLogo");

            migrationBuilder.DropTable(
                name: "Auction");

            migrationBuilder.DropTable(
                name: "BrochureMaps");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Negotiators");

            migrationBuilder.DropTable(
                name: "OpenViewing");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "RelatedPropertyID");

            migrationBuilder.DropTable(
                name: "TravelTime");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "VirtualViewing");

            migrationBuilder.DropTable(
                name: "CustomDatas");

            migrationBuilder.DropTable(
                name: "Properties");
        }
    }
}
