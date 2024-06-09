using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDiyetProgramiProje_DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuvenlikSorusu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuvenlikYaniti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HatirlaSifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifre3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifre4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ogunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgunAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogunler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YemekKategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekKategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciBilgiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Yas = table.Column<int>(type: "int", nullable: true),
                    Kilo = table.Column<double>(type: "float", nullable: true),
                    HedefKilo = table.Column<double>(type: "float", nullable: true),
                    VucutKitleEndeksi = table.Column<double>(type: "float", nullable: true),
                    GunlukHedefKalori = table.Column<int>(type: "int", nullable: true),
                    BazalMetabolizmaHizi = table.Column<double>(type: "float", nullable: true),
                    Boy = table.Column<double>(type: "float", nullable: true),
                    Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciId = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciBilgiler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KullaniciBilgiler_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Yemekler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YemekAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kalori = table.Column<double>(type: "float", nullable: true),
                    Tarif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gorsel = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    YemekKategoriId = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yemekler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yemekler_YemekKategoriler_YemekKategoriId",
                        column: x => x.YemekKategoriId,
                        principalTable: "YemekKategoriler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OgunYemekler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgunId = table.Column<int>(type: "int", nullable: false),
                    YemekId = table.Column<int>(type: "int", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    BirimAdedi = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgunYemekler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgunYemekler_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgunYemekler_Ogunler_OgunId",
                        column: x => x.OgunId,
                        principalTable: "Ogunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgunYemekler_Yemekler_YemekId",
                        column: x => x.YemekId,
                        principalTable: "Yemekler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "Id", "CreatedTime", "DataStatus", "DeletedTime", "GuvenlikSorusu", "GuvenlikYaniti", "HatirlaSifre", "KullaniciAdi", "ModifiedTime", "Sifre", "Sifre2", "Sifre3", "Sifre4" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, null, null, null, "admin", null, "123", null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciBilgiler_KullaniciId",
                table: "KullaniciBilgiler",
                column: "KullaniciId",
                unique: true,
                filter: "[KullaniciId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OgunYemekler_KullaniciId",
                table: "OgunYemekler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_OgunYemekler_OgunId",
                table: "OgunYemekler",
                column: "OgunId");

            migrationBuilder.CreateIndex(
                name: "IX_OgunYemekler_YemekId",
                table: "OgunYemekler",
                column: "YemekId");

            migrationBuilder.CreateIndex(
                name: "IX_Yemekler_YemekKategoriId",
                table: "Yemekler",
                column: "YemekKategoriId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KullaniciBilgiler");

            migrationBuilder.DropTable(
                name: "OgunYemekler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Ogunler");

            migrationBuilder.DropTable(
                name: "Yemekler");

            migrationBuilder.DropTable(
                name: "YemekKategoriler");
        }
    }
}
