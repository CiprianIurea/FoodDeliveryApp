using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodDeliveryApp.Migrations
{
    public partial class RelationsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocalitateId",
                table: "Restaurante",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RestaurantId",
                table: "Produse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BonId",
                table: "Plata",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ComandaId",
                table: "Plata",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TaraId",
                table: "Localitate",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ComandaId",
                table: "Cos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CosId",
                table: "Comenzi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LivratorId",
                table: "Comenzi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlataId",
                table: "Comenzi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlataId",
                table: "BonFiscal",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AdaugaCos",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProdusId = table.Column<int>(type: "int", nullable: false),
                    CosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdaugaCos", x => new { x.UserId, x.CosId, x.ProdusId });
                    table.ForeignKey(
                        name: "FK_AdaugaCos_Cos_CosId",
                        column: x => x.CosId,
                        principalTable: "Cos",
                        principalColumn: "CosId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdaugaCos_Produse_ProdusId",
                        column: x => x.ProdusId,
                        principalTable: "Produse",
                        principalColumn: "ProdusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdaugaCos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "faceComanda",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ComandaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_faceComanda", x => new { x.ComandaId, x.UserId });
                    table.ForeignKey(
                        name: "FK_faceComanda_Comenzi_ComandaId",
                        column: x => x.ComandaId,
                        principalTable: "Comenzi",
                        principalColumn: "ComandaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_faceComanda_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurante_LocalitateId",
                table: "Restaurante",
                column: "LocalitateId");

            migrationBuilder.CreateIndex(
                name: "IX_Produse_RestaurantId",
                table: "Produse",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Plata_ComandaId",
                table: "Plata",
                column: "ComandaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Localitate_TaraId",
                table: "Localitate",
                column: "TaraId");

            migrationBuilder.CreateIndex(
                name: "IX_Comenzi_CosId",
                table: "Comenzi",
                column: "CosId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comenzi_LivratorId",
                table: "Comenzi",
                column: "LivratorId");

            migrationBuilder.CreateIndex(
                name: "IX_BonFiscal_PlataId",
                table: "BonFiscal",
                column: "PlataId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdaugaCos_CosId",
                table: "AdaugaCos",
                column: "CosId");

            migrationBuilder.CreateIndex(
                name: "IX_AdaugaCos_ProdusId",
                table: "AdaugaCos",
                column: "ProdusId");

            migrationBuilder.CreateIndex(
                name: "IX_faceComanda_UserId",
                table: "faceComanda",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BonFiscal_Plata_PlataId",
                table: "BonFiscal",
                column: "PlataId",
                principalTable: "Plata",
                principalColumn: "PlataId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comenzi_Cos_CosId",
                table: "Comenzi",
                column: "CosId",
                principalTable: "Cos",
                principalColumn: "CosId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comenzi_Livrator_LivratorId",
                table: "Comenzi",
                column: "LivratorId",
                principalTable: "Livrator",
                principalColumn: "LivratorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Localitate_Tara_TaraId",
                table: "Localitate",
                column: "TaraId",
                principalTable: "Tara",
                principalColumn: "TaraId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Plata_Comenzi_ComandaId",
                table: "Plata",
                column: "ComandaId",
                principalTable: "Comenzi",
                principalColumn: "ComandaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produse_Restaurante_RestaurantId",
                table: "Produse",
                column: "RestaurantId",
                principalTable: "Restaurante",
                principalColumn: "RestaurantId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurante_Localitate_LocalitateId",
                table: "Restaurante",
                column: "LocalitateId",
                principalTable: "Localitate",
                principalColumn: "LocalitateId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BonFiscal_Plata_PlataId",
                table: "BonFiscal");

            migrationBuilder.DropForeignKey(
                name: "FK_Comenzi_Cos_CosId",
                table: "Comenzi");

            migrationBuilder.DropForeignKey(
                name: "FK_Comenzi_Livrator_LivratorId",
                table: "Comenzi");

            migrationBuilder.DropForeignKey(
                name: "FK_Localitate_Tara_TaraId",
                table: "Localitate");

            migrationBuilder.DropForeignKey(
                name: "FK_Plata_Comenzi_ComandaId",
                table: "Plata");

            migrationBuilder.DropForeignKey(
                name: "FK_Produse_Restaurante_RestaurantId",
                table: "Produse");

            migrationBuilder.DropForeignKey(
                name: "FK_Restaurante_Localitate_LocalitateId",
                table: "Restaurante");

            migrationBuilder.DropTable(
                name: "AdaugaCos");

            migrationBuilder.DropTable(
                name: "faceComanda");

            migrationBuilder.DropIndex(
                name: "IX_Restaurante_LocalitateId",
                table: "Restaurante");

            migrationBuilder.DropIndex(
                name: "IX_Produse_RestaurantId",
                table: "Produse");

            migrationBuilder.DropIndex(
                name: "IX_Plata_ComandaId",
                table: "Plata");

            migrationBuilder.DropIndex(
                name: "IX_Localitate_TaraId",
                table: "Localitate");

            migrationBuilder.DropIndex(
                name: "IX_Comenzi_CosId",
                table: "Comenzi");

            migrationBuilder.DropIndex(
                name: "IX_Comenzi_LivratorId",
                table: "Comenzi");

            migrationBuilder.DropIndex(
                name: "IX_BonFiscal_PlataId",
                table: "BonFiscal");

            migrationBuilder.DropColumn(
                name: "LocalitateId",
                table: "Restaurante");

            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "Produse");

            migrationBuilder.DropColumn(
                name: "BonId",
                table: "Plata");

            migrationBuilder.DropColumn(
                name: "ComandaId",
                table: "Plata");

            migrationBuilder.DropColumn(
                name: "TaraId",
                table: "Localitate");

            migrationBuilder.DropColumn(
                name: "ComandaId",
                table: "Cos");

            migrationBuilder.DropColumn(
                name: "CosId",
                table: "Comenzi");

            migrationBuilder.DropColumn(
                name: "LivratorId",
                table: "Comenzi");

            migrationBuilder.DropColumn(
                name: "PlataId",
                table: "Comenzi");

            migrationBuilder.DropColumn(
                name: "PlataId",
                table: "BonFiscal");
        }
    }
}
