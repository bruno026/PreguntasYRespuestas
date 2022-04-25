using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[] { 1, "bcorrea024" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[] { 2, "anaC001" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "ActiveGame", "CurrentDificultiyLevel", "ScoreId", "UserId" },
                values: new object[,]
                {
                    { 1, false, 1, 1, 1 },
                    { 2, false, 1, 2, 1 },
                    { 3, false, 0, 3, 1 },
                    { 4, false, 0, 4, 1 },
                    { 7, false, 0, 7, 1 },
                    { 8, false, 2, 8, 1 },
                    { 9, false, 0, 9, 1 },
                    { 5, false, 4, 5, 2 },
                    { 6, false, 1, 6, 2 },
                    { 10, false, 3, 10, 2 },
                    { 11, false, 2, 11, 2 }
                });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "GameId", "Id", "Points" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 0 },
                    { 4, 4, 0 },
                    { 7, 7, 0 },
                    { 8, 8, 2 },
                    { 9, 9, 0 },
                    { 5, 5, 4 },
                    { 6, 6, 1 },
                    { 10, 10, 3 },
                    { 11, 11, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "GameId", "Id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "GameId", "Id" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "GameId", "Id" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "GameId", "Id" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "GameId", "Id" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "GameId", "Id" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "GameId", "Id" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "GameId", "Id" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "GameId", "Id" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "GameId", "Id" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumns: new[] { "GameId", "Id" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
