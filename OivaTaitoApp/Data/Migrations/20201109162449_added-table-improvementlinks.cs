using Microsoft.EntityFrameworkCore.Migrations;

namespace OivaTaitoApp.Data.Migrations
{
    public partial class addedtableimprovementlinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImprovementLinks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkUrl = table.Column<string>(maxLength: 300, nullable: false),
                    LinkTitle = table.Column<string>(maxLength: 100, nullable: false),
                    EvalImprovementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImprovementLinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImprovementLinks_EvalImprovements_EvalImprovementId",
                        column: x => x.EvalImprovementId,
                        principalTable: "EvalImprovements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ImprovementLinks",
                columns: new[] { "Id", "EvalImprovementId", "LinkTitle", "LinkUrl" },
                values: new object[,]
                {
                    { 1, 1, "Video: Miksi tavoitteita on tärkeä asettaa ja miten ne saavutetaan?", "https://www.youtube.com/watch?v=gSkTEgGaFXE" },
                    { 24, 8, "Podcast: Mitä on todellinen rohkeus?", "https://play.acast.com/s/aamukahvilla/f0f9f0ba-fe8f-4830-a9fb-0de7599e3b05" },
                    { 25, 9, "Video: Leena Jokinen, Turun Yliopisto - Tulevaisuuden työmarkkinoilla vaadittava osaaminen", "https://www.youtube.com/watch?v=UxZyYvsSauk" },
                    { 26, 9, "Video: Perttu Pölönen – Tulevaisuuden tärkein taito", "https://www.youtube.com/watch?v=RKHsA8D7-bU&t=41s" },
                    { 27, 9, "STM - Työelämä muuttuu - mitä työelämävalmiuksia tarvitsemme?", "https://stm.fi/artikkeli/-/asset_publisher/tyoelama-muuttuu-mita-tyoelamavalmiuksia-tarvitsemme-" },
                    { 28, 9, "SITRAn julkaisuja – Eväitä työelämään", "https://www.sitra.fi/julkaisut/evaita-tyoelamaan/" },
                    { 29, 9, "Podcast: Sunnuntaibrunssi – vieraana Perttu Pölönen", "https://radioplay.fi/podcast/sunnuntaibrunssi/listen/2025608/" },
                    { 30, 10, "Video: Seitsemän vetovihjettä verkostoitumiseen - Pasi Rautio", "https://www.youtube.com/watch?v=oMTuBo_jHjI" },
                    { 31, 10, "Video: 3 vinkkiä verkostoitumiseen | InHunt Group,", "https://www.youtube.com/watch?v=Xc7rWMtt65E" },
                    { 23, 8, "Blogi: Miten uskaltaa ottaa elämässä riskejä?", "https://www.lily.fi/blogit/on-my-way/miten-uskaltaa-ottaa-elamassa-riskeja/" },
                    { 32, 10, "Someta duuniin verkkokurssi", "https://sometaduuniin.fi" },
                    { 34, 11, "Blogi: Digitaaliset urataidot avaavat uusia verkostoja", "https://uralehti.fi/ammattilaiset/digitaaliset-urataidot-avaavat-uusia-verkostoja/" },
                    { 35, 12, "Video: Kamalan ihana Amerikka – Kansainvälisyys tuo sivistystä!", "https://www.youtube.com/watch?v=h7yPTK8i_Jg" },
                    { 36, 12, "XAMK, Kansainvälisyysosaaminen yhä vahvemmin osaksi opintoja", "https://read.xamk.fi/2017/koulutus/kansainvalisyysosaaminen-yha-vahvemmin-osaksi-opintoja/" },
                    { 37, 12, "Savon sanomat, Kansainvälisyys on mahdollisuus – sinulle, minulle, meille", "https://blogit.savonsanomat.fi/liiketta-liiketoimintaan/kansainvalisyys-on-mahdollisuus-sinulle-minulle-meille/" },
                    { 38, 13, "Blogi: Mistä itsetunto muodostuu ja kuinka sitä voi parantaa?", "https://www.mielipalvelut.fi/artikkelit/mista-itsetunto-muodostuu-ja-kuinka-sita-voi-parantaa/" },
                    { 39, 13, "Blogi: Työssä jaksaminen koostuu pienistä tekijöistä – 10 vinkkiä", "https://lifted.fi/blogi/tyohyvinvointi/tyossa-jaksaminen/" },
                    { 40, 13, "Keva: Huolehdi omasta työhyvinvoinnistasi", "https://www.keva.fi/henkiloasiakkaalle/heikentynyt-tyokyky/oma-tyohyvinvointi/" },
                    { 41, 13, "Podcast: Onko burnout uusi normaali, joka on tullut työelämään jäädäkseen?", "https://open.spotify.com/episode/12HXEhgMwBum2txn8uhmtE" },
                    { 33, 11, "Video: Miten digitalisaatio muuttaa työskentelyä ja osaamisen kehittämistä", "https://www.youtube.com/watch?v=CJBnCd1XOvI" },
                    { 42, 13, "Podcast: Kokonaisvaltaisen hyvinvoinnin ihanuus ja kamaluus", "https://play.acast.com/s/aamukahvilla/f6ac234a-57dc-45e4-9bae-47fe939a6b3e" },
                    { 22, 8, "Blogi: Riskien ottaminen ja miksi se on tärkeää bisnesmaailmassa", "https://ertuki.fi/riskien-ottaminen-ja-miksi-se-on-tarkeaa-bisnesmaailmassa/" },
                    { 20, 7, "Video: Näkökulma, Essi Ahtola: Elämä on tiimityötä", "https://www.youtube.com/watch?v=oCdKiy5lwzE" },
                    { 2, 1, "Video: Tavoitteiden asettaminen – KIRMA", "https://www.youtube.com/watch?v=xCfyg7SewkY" },
                    { 3, 2, "Video: Osaamisen kehittäminen – Ida Mielityinen", "https://www.youtube.com/watch?v=niHcxuzOW94" },
                    { 4, 2, "Video: Uudet organisoitumismuodot ja itsensä johtaminen – LUT", "https://www.youtube.com/watch?v=X5DOWi3MbPI" },
                    { 5, 2, "Blogi: Joustavassa työssä tarvittavat taidot", "https://etajohtaminen.fi/joustavassa-tyossa-tarvittavat-taidot/" },
                    { 6, 3, "Video: Työelämätaidot osa III – Itsetuntemus", "https://www.youtube.com/watch?v=SbEQebZFEtA" },
                    { 7, 3, "Video: Kolme vinkkiä itsensä johtamiseen", "https://www.youtube.com/watch?v=uhZq2n1XfkY" },
                    { 8, 3, "Partiolaisten ohjeet oman johtajuuden itsearviointiin", "https://www.partio.fi/wp-content/uploads/2018/11/Johtajuuden_itsearviointity%C3%B6kalu.pdf" },
                    { 9, 3, "Podcast: Osaamisen aika – Onko osaaminen onnen lähde?", "https://www.sitra.fi/artikkelit/onko-osaaminen-onnen-lahde/" },
                    { 21, 7, "Blogi: Brainstorming - Miten keksiä uusi idea tyhjästä?", "https://blog.smoothlynow.com/brainstorming" },
                    { 10, 4, "Video: Riku Rantala & Tunna Milonoff: Media- ja lähdekritiikki / Media and Source Criticism", "https://www.youtube.com/watch?v=NGoYJAryARc" },
                    { 12, 5, "Video: Työelämätaidot osa II – Vuorovaikutus", "https://www.youtube.com/watch?v=iQms4At4SUM" },
                    { 13, 5, "Video (podcast): Taituri-podcast: Humanistispeksi työelämätaitojen ja opintojen näkökulmasta", "https://www.youtube.com/watch?v=buXt0xNQya4" },
                    { 14, 5, "Blogi: Yhteistyötaidot ovat tulevaisuustaitoja", "https://www.juuriharja.fi/blogi/yhteistyotaidot-ovat-tulevaisuustaitoja" },
                    { 15, 5, "Podcast: Jos asiantuntija kaatuu metsässä – eli yhdessä oppiminen ja osaaminen", "https://soundcloud.com/osaamiskomitea/jos-asiantuntija-kaatuu-metsassa-eli-yhdessa-oppiminen-ja-osaaminen" },
                    { 16, 6, "Video: Ismo Jokinen - Esiintymis- ja viestintätaitojen merkitys työelämässä – Speakersforum", "https://www.youtube.com/watch?v=1E29chrxRuE" },
                    { 17, 6, "Video: Opettele neljä viestinnän keinoa, ettei sanomasi saa surmaansa", "https://www.youtube.com/watch?v=G0k--QXvDa4" },
                    { 18, 6, "Video: Esiintymisvalmennusvinkkejä - Niina Sainius", "https://www.youtube.com/watch?v=3Gi1WMSnq04" },
                    { 19, 6, "OPH: Vuorovaikutus ja viestintätaidot", "https://www.oph.fi/fi/koulutus-ja-tutkinnot/vuorovaikutus-ja-viestintataidot" },
                    { 11, 4, "Video: Lähdekritiikki", "https://www.youtube.com/watch?v=wltECqudWTs" },
                    { 43, 13, "Mielenterveys:", "https://www.mielenterveystalo.fi/" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImprovementLinks_EvalImprovementId",
                table: "ImprovementLinks",
                column: "EvalImprovementId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImprovementLinks");
        }
    }
}
