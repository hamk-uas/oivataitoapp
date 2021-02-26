using Microsoft.EntityFrameworkCore.Migrations;

namespace OivaTaitoApp.Data.Migrations
{
    public partial class ModifiedEvalimprovementdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "FeedbackContent",
                value: "Työelämä, joka koostuu yhä useammin projektimuotoisista työtehtävistä, vaatii työntekijöiltä hyviä organisointitaitoja sekä pysymistä tavoitteissa ja dead lineissa. Organisointitaitoja voit parantaa näillä vinkeillä.");

            migrationBuilder.UpdateData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 17,
                column: "FeedbackContent",
                value: "Tiimi- ja ryhmätyöskentely on uusi normi työpaikoilla tänään. Sen vuoksi yhteistyötaitojen merkitys korostuu vahvasti työelämäosaamisena. Sinulla on vielä kehitettävää taidoissasi, mutta vinkkejä löydät täältä.");

            migrationBuilder.UpdateData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 18,
                column: "FeedbackContent",
                value: "Olet tottunut tiimityöntekijä ja osaat työskennellä osana ryhmää. Voit kuitenkin kehittää itseäsi näillä vinkeillä.");

            migrationBuilder.UpdateData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 19,
                column: "FeedbackContent",
                value: "Olet kokenut tiimityön ammattilainen. Jos kuitenkin haluat vielä kehittää itseäsi, katso vinkit täältä.");

            migrationBuilder.UpdateData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 20,
                column: "FeedbackContent",
                value: "Tiimityöskentely on sinulle ominaisin tapa työskennellä ja selviät tiimissä kuin tiimissä. Jatka hyvää työtä!");

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
                value: "Viestit ja kommunikoit sujuvasti. Et jännitä vuorovaikutustilanteita tai suoriudut niistä kunnialla läpi. Jos kuitenkin haluat vielä kehittää itseäsi viestijänä, katso nämä vinkit läpi.");

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
                column: "ImprovementContent",
                value: "Voit tutustua aiheeseen lisää \"Kehitysehdotukset\" sivulle listattujen linkkien kautta.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "FeedbackContent",
                value: "Työelämä, joka koostuu yhä useammin projektimuotoisista työtehtävistä, vaatii työntekijöiltä hyviä organisointitaitoja sekä pysymistä tavoitteissa ja dead lineissa. Organisointitaitoja voit parantaa näillä vinkeillä");

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
                column: "ImprovementContent",
                value: "Voit tutustua aiheeseen lisää päävalikon linkkien kautta.");
        }
    }
}
