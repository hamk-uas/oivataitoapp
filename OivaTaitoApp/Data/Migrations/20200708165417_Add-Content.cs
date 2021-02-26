using Microsoft.EntityFrameworkCore.Migrations;

namespace OivaTaitoApp.Data.Migrations
{
    public partial class AddContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "QuestionCategories",
                columns: new[] { "Id", "Identifier", "Title" },
                values: new object[,]
                {
                    { 1, "A", "Oman osaamisen kehittäminen ja johtaminen" },
                    { 2, "B", "Tiedon hankinta ja analysointi" },
                    { 3, "C", "Yhteistyötaidot ja viestintä" },
                    { 4, "D", "Innovointi ja luova ongelmanratkaisu" },
                    { 5, "E", "Tulevaisuustaidot: urasuunnittelu, yrittäjyys, digitaalisuus, monikulttuurisuus, kestävä kehitys" },
                    { 6, "f", "Itseluottamus ja hyvinvointi työssä" }
                });

            migrationBuilder.InsertData(
                table: "QuestionSets",
                columns: new[] { "Id", "Identifier", "QuestionCategoryId", "Title" },
                values: new object[] { 1, "1", 1, "Tavoitteellinen työskentely ja organisointitaidot" });

            migrationBuilder.InsertData(
                table: "QuestionSets",
                columns: new[] { "Id", "Identifier", "QuestionCategoryId", "Title" },
                values: new object[] { 2, "2", 1, "Työskentelytaidot" });

            migrationBuilder.InsertData(
                table: "QuestionSets",
                columns: new[] { "Id", "Identifier", "QuestionCategoryId", "Title" },
                values: new object[] { 3, "3", 1, "Oman työskentelyn johtaminen" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "Identifier", "QuestionSetId" },
                values: new object[,]
                {
                    { 1, "Perehdyn opiskelusuunnitelmani tavoitteisiin", "A", 1 },
                    { 23, "Pystyn arvioimaan oman osaamiseni kehittymistä", "H", 3 },
                    { 22, "Osaan tehdä työni tehokkaasti huomioiden erilaisia näkökulmia", "G", 3 },
                    { 21, "Noudatan yhteisiä pelisääntöjä ja sopimuksia", "F", 3 },
                    { 20, "Työyhteisöni voi luottaa, että teen työni kunnolla", "E", 3 },
                    { 19, "Huomatessani työhöni/työyhteisööni vaikuttavia epäkohtia, pyrin korjaamaan niitä", "D", 3 },
                    { 18, "Otan vastuun omasta työstäni", "C", 3 },
                    { 17, "Ymmärrän oman alani eettiset periaatteet", "B", 3 },
                    { 16, "Työskentelen omaa alaani kunnioittaen ja olen rehellinen", "A", 3 },
                    { 15, "Siedän haasteita ja muutoksia työskentelyssäni", "I", 2 },
                    { 14, "Osaan arvioida oman toimintani vaikutuksia", "H", 2 },
                    { 24, "Olen valmis kehittämään itseäni saamani palautteen kautta", "I", 3 },
                    { 13, "Pystyn suoriutumaan alani käytännön työtehtävistä", "G", 2 },
                    { 11, "Pystyn itsenäiseen kriittiseen ajatteluun", "E", 2 },
                    { 10, "Osaan työskennellä joustavasti muuttuvissa tilanteissa", "D", 2 },
                    { 9, "Pystyn suunnitelmalliseen ja tavoitteelliseen työskentelyyn", "C", 2 },
                    { 8, "Keskityn oppimiseni kannalta tärkeimpiin asioihin", "B", 2 },
                    { 7, "Osaan käyttää itselleni sopivimpia työskentelymuotoja", "A", 2 },
                    { 6, "Haluan oppia oman alani asiantuntijaksi", "F", 1 },
                    { 5, "Pystyn selviytymään useasta yhtäaikaisesta opiskelutehtävästä ajallaan", "E", 1 },
                    { 4, "Saan työni valmiiksi aikataulussa", "D", 1 },
                    { 3, "Osaan suunnitella ja aikatauluttaa opintojani", "C", 1 },
                    { 2, "Asetan työskentelylleni aikataulutavoitteita", "B", 1 },
                    { 12, "Pystyn tekemään itsenäisiä päätöksiä", "F", 2 },
                    { 25, "En lannistu helposti", "J", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "QuestionCategories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
