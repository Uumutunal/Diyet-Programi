using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDiyetProgramiProje_DAL.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicilar_KullaniciBilgiler_KullaniciBilgiId",
                table: "Kullanicilar");

            migrationBuilder.DropIndex(
                name: "IX_Kullanicilar_KullaniciBilgiId",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "KullaniciBilgiId",
                table: "Kullanicilar");

            migrationBuilder.RenameColumn(
                name: "EPostaAdresi",
                table: "Kullanicilar",
                newName: "GuvenlikYaniti");

            migrationBuilder.AddColumn<string>(
                name: "GuvenlikSorusu",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "KullaniciId",
                table: "KullaniciBilgiler",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciBilgiler_KullaniciId",
                table: "KullaniciBilgiler",
                column: "KullaniciId",
                unique: true,
                filter: "[KullaniciId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_KullaniciBilgiler_Kullanicilar_KullaniciId",
                table: "KullaniciBilgiler",
                column: "KullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KullaniciBilgiler_Kullanicilar_KullaniciId",
                table: "KullaniciBilgiler");

            migrationBuilder.DropIndex(
                name: "IX_KullaniciBilgiler_KullaniciId",
                table: "KullaniciBilgiler");

            migrationBuilder.DropColumn(
                name: "GuvenlikSorusu",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "KullaniciBilgiler");

            migrationBuilder.RenameColumn(
                name: "GuvenlikYaniti",
                table: "Kullanicilar",
                newName: "EPostaAdresi");

            migrationBuilder.AddColumn<int>(
                name: "KullaniciBilgiId",
                table: "Kullanicilar",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_KullaniciBilgiId",
                table: "Kullanicilar",
                column: "KullaniciBilgiId",
                unique: true,
                filter: "[KullaniciBilgiId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicilar_KullaniciBilgiler_KullaniciBilgiId",
                table: "Kullanicilar",
                column: "KullaniciBilgiId",
                principalTable: "KullaniciBilgiler",
                principalColumn: "Id");
        }
    }
}
