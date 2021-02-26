using Microsoft.EntityFrameworkCore.Migrations;

namespace OivaTaitoApp.Data.Migrations
{
    public partial class AddEvalFeedbackEvalImprovementTablesContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EvalFeedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MinPts = table.Column<float>(nullable: false),
                    MaxPts = table.Column<float>(nullable: false),
                    FeedbackContent = table.Column<string>(maxLength: 500, nullable: false),
                    QuestionSetId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvalFeedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvalFeedbacks_QuestionSets_QuestionSetId",
                        column: x => x.QuestionSetId,
                        principalTable: "QuestionSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvalImprovements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImprovementContent = table.Column<string>(maxLength: 2000, nullable: false),
                    ImprovementVideoUrl = table.Column<string>(maxLength: 300, nullable: true),
                    QuestionSetId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvalImprovements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvalImprovements_QuestionSets_QuestionSetId",
                        column: x => x.QuestionSetId,
                        principalTable: "QuestionSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EvalFeedbacks",
                columns: new[] { "Id", "FeedbackContent", "MaxPts", "MinPts", "QuestionSetId" },
                values: new object[,]
                {
                    { 1, "Työelämä, joka koostuu yhä useammin projektimuotoisista työtehtävistä, vaatii työntekijöiltä hyviä organisointitaitoja sekä pysymistä tavoitteissa ja dead lineissa. Organisointitaitoja voit parantaa näillä vinkeillä", 2f, 0f, 1 },
                    { 2, "Olet selvästi jo tottunut organisoimaan työtäsi ja tavoitteellinen työskentely on sinulle tuttua. Voit kuitenkin vielä kehittää itseäsi mm. näillä vinkeillä.", 3.5f, 2.1f, 1 },
                    { 3, "Taidat olla ammattilainen organisoinnissa ja tavoitteisiin pääsemisessä. Jos kuitenkin koet, että haluaisit vielä kehittää itseäsi, tsekkaa vinkit täältä.", 4.5f, 3.6f, 1 },
                    { 4, "KonMarikin kalpenee sinun organisointitaitojesi rinnalla. Jatka hyvää työtä!", 5f, 4.6f, 1 }
                });

            migrationBuilder.InsertData(
                table: "EvalImprovements",
                columns: new[] { "Id", "ImprovementContent", "ImprovementVideoUrl", "QuestionSetId" },
                values: new object[] { 1, "Tavoitteellista työskentelyä sekä organisointitaitoja voit kehittää asettamalla itsellesi realistisia tavoitteita opinnoissasi tai työssäsi ja sitoutumalla niihin. Tee aikataulusuunnitelma valmistumiseesi tai jonkin pienemmän projektin ympärille ja pyri pitäytymään tavoitteessasi. Suunnittele myös tehtävämäärän jakautuminen eri päiville, esimerkiksi viikkokalenterin tekeminen aina seuraavaa viikkoa varten auttaa jäsentämään tulevan viikon työmäärää sekä purkaa stressiä, kun olet varautunut etukäteen viikon tapahtumiin. Kun saat jonkin projektin päätökseen, arvioi suoritustasi ja pohdi, mitä olisit voinut / halunnut tehdä toisin ja missä puolestaan onnistuit. Jokainen projekti on arvokas oppimiskokemus ja aikaa kannattaa käyttää myös suorituksen reflektointiin.", null, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_EvalFeedbacks_QuestionSetId",
                table: "EvalFeedbacks",
                column: "QuestionSetId");

            migrationBuilder.CreateIndex(
                name: "IX_EvalImprovements_QuestionSetId",
                table: "EvalImprovements",
                column: "QuestionSetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EvalFeedbacks");

            migrationBuilder.DropTable(
                name: "EvalImprovements");
        }
    }
}
