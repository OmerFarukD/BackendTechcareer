using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day6_efcore1.Migrations
{
    /// <inheritdoc />
    public partial class db_relations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Players",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "BranchName",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "TeamName",
                table: "Players");

            migrationBuilder.RenameTable(
                name: "Players",
                newName: "Players_db");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Players_db",
                newName: "player_price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Players_db",
                newName: "player_name");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Players_db",
                newName: "player_age");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Players_db",
                newName: "player_id");

            migrationBuilder.AlterColumn<int>(
                name: "player_id",
                table: "Players_db",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "branch_id",
                table: "Players_db",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "outfit_id",
                table: "Players_db",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "team_id",
                table: "Players_db",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Players_db",
                table: "Players_db",
                column: "player_id");

            migrationBuilder.CreateTable(
                name: "Branch_db",
                columns: table => new
                {
                    branch_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    branch_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch_db", x => x.branch_id);
                });

            migrationBuilder.CreateTable(
                name: "Outfits_db",
                columns: table => new
                {
                    outfit_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    outfit_type = table.Column<int>(type: "int", nullable: false),
                    outfit_no = table.Column<short>(type: "smallint", nullable: false),
                    outfit_brand_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    player_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outfits_db", x => x.outfit_id);
                });

            migrationBuilder.CreateTable(
                name: "Teams_db",
                columns: table => new
                {
                    team_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    team_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams_db", x => x.team_id);
                });

            migrationBuilder.InsertData(
                table: "Branch_db",
                columns: new[] { "branch_id", "branch_name" },
                values: new object[] { 1, "Football" });

            migrationBuilder.InsertData(
                table: "Outfits_db",
                columns: new[] { "outfit_id", "outfit_brand_name", "outfit_no", "player_id", "outfit_type" },
                values: new object[] { 1, "Adidas", (short)42, 1, 0 });

            migrationBuilder.InsertData(
                table: "Teams_db",
                columns: new[] { "team_id", "team_name" },
                values: new object[] { 1, "Galatasaray" });

            migrationBuilder.InsertData(
                table: "Players_db",
                columns: new[] { "player_id", "player_age", "branch_id", "player_name", "outfit_id", "player_price", "team_id" },
                values: new object[] { 1, 30, 1, "Mauro Icardi", 1, 300000000m, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Players_db_branch_id",
                table: "Players_db",
                column: "branch_id");

            migrationBuilder.CreateIndex(
                name: "IX_Players_db_team_id",
                table: "Players_db",
                column: "team_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_db_Branch_db_branch_id",
                table: "Players_db",
                column: "branch_id",
                principalTable: "Branch_db",
                principalColumn: "branch_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_db_Outfits_db_player_id",
                table: "Players_db",
                column: "player_id",
                principalTable: "Outfits_db",
                principalColumn: "outfit_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_db_Teams_db_team_id",
                table: "Players_db",
                column: "team_id",
                principalTable: "Teams_db",
                principalColumn: "team_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_db_Branch_db_branch_id",
                table: "Players_db");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_db_Outfits_db_player_id",
                table: "Players_db");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_db_Teams_db_team_id",
                table: "Players_db");

            migrationBuilder.DropTable(
                name: "Branch_db");

            migrationBuilder.DropTable(
                name: "Outfits_db");

            migrationBuilder.DropTable(
                name: "Teams_db");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Players_db",
                table: "Players_db");

            migrationBuilder.DropIndex(
                name: "IX_Players_db_branch_id",
                table: "Players_db");

            migrationBuilder.DropIndex(
                name: "IX_Players_db_team_id",
                table: "Players_db");

            migrationBuilder.DeleteData(
                table: "Players_db",
                keyColumn: "player_id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "branch_id",
                table: "Players_db");

            migrationBuilder.DropColumn(
                name: "outfit_id",
                table: "Players_db");

            migrationBuilder.DropColumn(
                name: "team_id",
                table: "Players_db");

            migrationBuilder.RenameTable(
                name: "Players_db",
                newName: "Players");

            migrationBuilder.RenameColumn(
                name: "player_price",
                table: "Players",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "player_name",
                table: "Players",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "player_age",
                table: "Players",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "player_id",
                table: "Players",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Players",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "BranchName",
                table: "Players",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TeamName",
                table: "Players",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Players",
                table: "Players",
                column: "Id");
        }
    }
}
