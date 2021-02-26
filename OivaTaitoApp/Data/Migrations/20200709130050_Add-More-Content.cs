using Microsoft.EntityFrameworkCore.Migrations;

namespace OivaTaitoApp.Data.Migrations
{
    public partial class AddMoreContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "QuestionCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Identifier",
                value: "F");

            migrationBuilder.InsertData(
                table: "QuestionSets",
                columns: new[] { "Id", "Identifier", "QuestionCategoryId", "Title" },
                values: new object[,]
                {
                    { 4, "1", 2, "Tiedon hankinta ja analysointi" },
                    { 5, "1", 3, "Yhteistyötaidot" },
                    { 6, "2", 3, "Viestintä- ja kommunikaatiotaidot" },
                    { 7, "1", 4, "Ongelmanratkaisutaidot ja innovointi" },
                    { 8, "2", 4, "Riskinottokyky / Riskien hallinta" },
                    { 9, "1", 5, "Tulevaisuustaidot" },
                    { 10, "2", 5, "Urataidot" },
                    { 11, "3", 5, "Digitaaliset työskentelytaidot" },
                    { 12, "4", 5, "Kansainvälisyys" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "Identifier", "QuestionSetId" },
                values: new object[,]
                {
                    { 26, "Osaan etsiä omaan alaani liittyvää luotettavaa tietoa", "A", 4 },
                    { 47, "Osaan esiintyä vaikuttavasti", "E", 6 },
                    { 48, "Uskallan pitää puoliani sekä perustella näkökantaani", "F", 6 },
                    { 49, "Osaan ilmaista itseäni kirjallisesti", "G", 6 },
                    { 50, "Osaan suunnitella ja toteuttaa viestintää eri viestintävälineitä hyödyntämällä", "H", 6 },
                    { 51, "Huomatessani ongelmia pyrin löytämään niihin ratkaisuvaihtoehtoja", "A", 7 },
                    { 52, "Olen kriittinen pohtiessani jo olemassa olevien ratkaisujen toimivuutta", "B", 7 },
                    { 53, "Osaan ratkaista ammatillisia ongelmia", "C", 7 },
                    { 54, "Osaan hyödyntää aiemmin opittua uudessa tilanteessa", "D", 7 },
                    { 55, "Olen kekseliäs ja kehitän uusia ideoita", "E", 7 },
                    { 56, "Osaan suunnitella ideoistani toimintakelpoisia ratkaisuja", "F", 7 },
                    { 57, "Tunnistan mahdollisuuksia, joissa voin laajentaa ammatillisen toimintani rajoja", "G", 7 },
                    { 58, "Haluan kehittää omaa alaani", "H", 7 },
                    { 59, "Haluan olla innovoimassa oman alani kehittymistä yhteistyössä muiden alojen kanssa", "I", 7 },
                    { 60, "Uskon omaan tekemiseeni ja uskallan kokeilla vaihtoehtoisia toimintatapoja", "A", 8 },
                    { 61, "Luotan omaan ammatilliseen osaamiseeni.", "B", 8 },
                    { 46, "Osaan viestiä ammatillisesti toisella kotimaisella kielellä", "D", 6 },
                    { 45, "Osaan viestiä ammatillisesti vieraalla kielellä (a-kieli)", "C", 6 },
                    { 44, "Osaan kuvata omaa osaamistani monipuolisesti", "B", 6 },
                    { 43, "Osaan esitellä työni tuloksia ymmärrettävästi", "A", 6 },
                    { 27, "Ymmärrän tekijänoikeudet ja noudatan niitä", "B", 4 },
                    { 28, "Osaan analysoida ja soveltaa alaani liittyvää tieteellistä tietoa", "C", 4 },
                    { 29, "Osaan arvioida kriittisesti lähteiden luotettavuutta.", "D", 4 },
                    { 30, "Tunnen oman alani tärkeimmät toimijat ja seuraan alani kehitystä", "E", 4 },
                    { 31, "Minulla on hyvät vuorovaikutustaidot", "A", 5 },
                    { 32, "Osaan työskennellä asiakaslähtöisesti", "B", 5 },
                    { 33, "Olen empaattinen ja huomioin työyhteisöni jäsenet", "C", 5 },
                    { 62, "Tunnistan alaani liittyviä riskejä", "C", 8 },
                    { 34, "Osaan antaa kehittävää palautetta", "D", 5 },
                    { 36, "Huolehdin, että tiimin työskentely on tavoitteellista", "F", 5 },
                    { 37, "Otan huomioon kriittisen ja kehittävän palautteen", "G", 5 },
                    { 38, "Olen tasapuolinen kaikkia tiimini jäseniä kohtaan", "H", 5 },
                    { 39, "Kannustan muita tiimini jäseniä yhteisten tavoitteiden saavuttamiseksi", "I", 5 },
                    { 40, "Pyrin ratkaisemaan tiimityöskentelyyn liittyviä haasteita", "J", 5 },
                    { 41, "Autan muita tarvittaessa", "K", 5 },
                    { 42, "Osaan toimia yhteistyössä muiden alojen ammattilaisten kanssa", "L", 5 },
                    { 35, "Olen valmis jakamaan osaamistani ja ideoitani tiimissä", "E", 5 },
                    { 63, "Toimin alaani liittyvien riskien hallitsemiseksi", "D", 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "QuestionCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Identifier",
                value: "f");
        }
    }
}
