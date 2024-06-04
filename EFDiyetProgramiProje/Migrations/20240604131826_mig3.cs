using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDiyetProgramiProje_DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
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

            migrationBuilder.AlterColumn<int>(
                name: "KullaniciBilgiId",
                table: "Kullanicilar",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicilar_KullaniciBilgiler_KullaniciBilgiId",
                table: "Kullanicilar");

            migrationBuilder.DropIndex(
                name: "IX_Kullanicilar_KullaniciBilgiId",
                table: "Kullanicilar");

            migrationBuilder.AlterColumn<int>(
                name: "KullaniciBilgiId",
                table: "Kullanicilar",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_KullaniciBilgiId",
                table: "Kullanicilar",
                column: "KullaniciBilgiId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicilar_KullaniciBilgiler_KullaniciBilgiId",
                table: "Kullanicilar",
                column: "KullaniciBilgiId",
                principalTable: "KullaniciBilgiler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
