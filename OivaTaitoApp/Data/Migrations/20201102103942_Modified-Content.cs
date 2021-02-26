using Microsoft.EntityFrameworkCore.Migrations;

namespace OivaTaitoApp.Data.Migrations
{
    public partial class ModifiedContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 17,
                column: "FeedbackContent",
                value: "Viestinnän merkitystä työelämässä ei voi ylikorostaa ja viestintä- ja kommunikaatiotaitojen osaaminen on yleistä työelämäosaamista parhaimmillaan. Olet vielä vasta-alkaja viestinnässä, mutta kehitä taitojasi näiden vinkkien avulla.");

            migrationBuilder.UpdateData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 18,
                column: "FeedbackContent",
                value: "Olet jo jonkin verran kokenut viestijä, mutta osaamisessasi on vielä kehitettävää. Näillä vinkeillä kehität itsestäsi viestinnän ammattilaisen.");

            migrationBuilder.UpdateData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 19,
                column: "FeedbackContent",
                value: "Viestit ja kommunikoit sujuvasti sekä suomeksi että vierailla kielillä. Et jännitä vuorovaikutustilanteita tai suoriudut niistä kunnialla läpi. Jos kuitenkin haluat vielä kehittää itseäsi viestijänä, katso nämä vinkit läpi.");

            migrationBuilder.UpdateData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 20,
                column: "FeedbackContent",
                value: "Olet viestinnän moniottelija, joka selviää kaikenlaisista vuorovaikutustilanteista ammattilaisen itsevarmuudella. Jatka hyvää työtä!");

            migrationBuilder.UpdateData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 21,
                column: "FeedbackContent",
                value: "Tietoa syntyy nopeammin kuin koskaan ennen, jonka takia tiedon hankinta ja analysointitaitojen merkitys vain kasvaa työelämässä. Sinulla on vielä petrattavaa näissä taidoissa, mutta näillä vinkeillä pääset eteenpäin!");

            migrationBuilder.UpdateData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 22,
                column: "FeedbackContent",
                value: "Osaat etsiä ja analysoida omaan alaasi liittyvää tietoa, mutta sinulla on vielä kehitettävää. Katso vinkkejä täältä.");

            migrationBuilder.UpdateData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 23,
                column: "FeedbackContent",
                value: "Olet selvästi edistynyt tiedon hankinta- ja analysointitaidoissa, mutta jos haluat vielä kehittää itseäsi, katso vinkit täältä.");

            migrationBuilder.UpdateData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 24,
                column: "FeedbackContent",
                value: "Olet tiedon haun Sherlock Holmes! Jatka hyvää työtä!");

            migrationBuilder.UpdateData(
                table: "EvalImprovements",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImprovementVideoUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "QuestionCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "ColorHex",
                value: "519cd2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 17,
                column: "FeedbackContent",
                value: "Tietoa syntyy nopeammin kuin koskaan ennen, jonka takia tiedon hankinta ja analysointitaitojen merkitys vain kasvaa työelämässä. Sinulla on vielä petrattavaa näissä taidoissa, mutta näillä vinkeillä pääset eteenpäin!");

            migrationBuilder.UpdateData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 18,
                column: "FeedbackContent",
                value: "Osaat etsiä ja analysoida omaan alaasi liittyvää tietoa, mutta sinulla on vielä kehitettävää. Katso vinkkejä täältä.");

            migrationBuilder.UpdateData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 19,
                column: "FeedbackContent",
                value: "Olet selvästi edistynyt tiedon hankinta- ja analysointitaidoissa, mutta jos haluat vielä kehittää itseäsi, katso vinkit täältä.");

            migrationBuilder.UpdateData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 20,
                column: "FeedbackContent",
                value: "Olet tiedon haun Sherlock Holmes! Jatka hyvää työtä!");

            migrationBuilder.UpdateData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 21,
                column: "FeedbackContent",
                value: "Viestinnän merkitystä työelämässä ei voi ylikorostaa ja viestintä- ja kommunikaatiotaitojen osaaminen on yleistä työelämäosaamista parhaimmillaan. Olet vielä vasta-alkaja viestinnässä, mutta kehitä taitojasi näiden vinkkien avulla.");

            migrationBuilder.UpdateData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 22,
                column: "FeedbackContent",
                value: "Olet jo jonkin verran kokenut viestijä, mutta osaamisessasi on vielä kehitettävää. Näillä vinkeillä kehität itsestäsi viestinnän ammattilaisen.");

            migrationBuilder.UpdateData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 23,
                column: "FeedbackContent",
                value: "Viestit ja kommunikoit sujuvasti sekä suomeksi että vierailla kielillä. Et jännitä vuorovaikutustilanteita tai suoriudut niistä kunnialla läpi. Jos kuitenkin haluat vielä kehittää itseäsi viestijänä, katso nämä vinkit läpi.");

            migrationBuilder.UpdateData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 24,
                column: "FeedbackContent",
                value: "Olet viestinnän moniottelija, joka selviää kaikenlaisista vuorovaikutustilanteista ammattilaisen itsevarmuudella. Jatka hyvää työtä!");

            migrationBuilder.UpdateData(
                table: "EvalImprovements",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImprovementVideoUrl",
                value: "https://www.youtube.com/embed/Y2sSaAtyW2Y");

            migrationBuilder.UpdateData(
                table: "QuestionCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "ColorHex",
                value: "215880");
        }
    }
}
