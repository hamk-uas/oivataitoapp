using Microsoft.EntityFrameworkCore.Migrations;

namespace OivaTaitoApp.Data.Migrations
{
    public partial class AddedMoreContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "QuestionSets",
                columns: new[] { "Id", "Identifier", "QuestionCategoryId", "Title" },
                values: new object[] { 13, "1", 6, "Itseluottamus ja hyvinvointi työssä" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "Identifier", "QuestionSetId" },
                values: new object[,]
                {
                    { 65, "Olen kiinnostunut osaamiseni kehittämisestä.", "B", 9 },
                    { 94, "Osaan toimia monenlaisissa yhteisöissä riippumatta sijainnista tai kielestä.", "E", 12 },
                    { 93, "Kasvatan ammatillista verkostoani kansainvälisesti.", "D", 12 },
                    { 92, "Tunnistan alani kansainväliset verkostot.", "C", 12 },
                    { 91, "Osaan toimia monikulttuurisessa ympäristössä toisia kunnioittavasti.", "B", 12 },
                    { 90, "Ymmärrän erilaisia kulttuuritaustoja ja osaan huomioida niiden merkitystä vuorovaikutuksessa.", "A", 12 },
                    { 89, "Osaan arvioida kriittisesti digitaalisten sisältöjen luotettavuutta.", "H", 11 },
                    { 88, "Osaan toimia digitaalisessa ympäristössä toisia kunnioittaen.", "G", 11 },
                    { 87, "Osaan toimia turvallisesti digitaalisissa ympäristöissä.", "F", 11 },
                    { 86, "Osaan käyttää digitaalisia työkaluja yhteistyöhön ja viestintään.", "E", 11 },
                    { 85, "Osaan luoda ja jakaa digitaalisia sisältöjä.", "D", 11 },
                    { 84, "Osaan suojata oman digitaalisen identiteettini.", "C", 11 },
                    { 83, "Osaan käsitellä oman alani dataa.", "B", 11 },
                    { 82, "Osaan käyttää oman alani kannalta keskeisiä digitaalisia työkaluja.", "A", 11 },
                    { 81, "Ennakoin urallani kohtaamiani muutoksia.", "K", 10 },
                    { 80, "Osallistun oman alan tapahtumiin ja seminaareihin.", "J", 10 },
                    { 79, "Seuraan oman alani ja osaamiseeni liittyviä työmahdollisuuksia aktiivisesti.", "I", 10 },
                    { 78, "Kehitän työelämätaitojani.", "H", 10 },
                    { 77, "Asetan uratavoitteita ja pyrin niitä kohti.", "G", 10 },
                    { 76, "Osaan kehittää, organisoida ja hallita omaa liiketoimintaa.", "F", 10 },
                    { 75, "Osaan projektien hallintaa ja hyödyntää siihen kuuluvia työkaluja.", "E", 10 },
                    { 74, "Tunnistan osaamiseni ja osaan hakea sitä vastaavia työtehtäviä.", "D", 10 },
                    { 73, "Opinnäytetyöni tukee ammatillista kehittymistäni.", "C", 10 },
                    { 72, "Kasvatan ammatillisia verkostojani jo opintojeni aikana.", "B", 10 },
                    { 71, "Kehitän omaa ammatillista osaamistani työharjoitteluiden tai työkokemuksen kautta.", "A", 10 },
                    { 70, "Haluan olla vaikuttamassa oman alani kehittämiseen osana muuta yhteiskunnallista kehitystä.", "G", 9 },
                    { 69, "Ymmärrän oman alani osana globaalia maailmaa.", "F", 9 },
                    { 68, "Osaan tuottaa ymmärrettävää tietoa tulevaisuuden tarpeisiin.", "E", 9 },
                    { 67, "Tunnen kestävän kehityksen periaatteet ja osaan soveltaa niitä alallani.", "D", 9 },
                    { 66, "Osaan viedä muutoksia eteenpäin yhteisössäni.", "C", 9 },
                    { 95, "Seuraan globaalia mediaa.", "F", 12 },
                    { 64, "Osaan varautua alani muutoksiin.", "A", 9 }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "Identifier", "QuestionSetId" },
                values: new object[,]
                {
                                { 105, "Luotan itseeni alani osaajana.", "J", 13 },
                                { 104, "Otan vastuuta tekemisistäni.", "I", 13 },
                                { 103, "Olen oma-aloitteinen.", "H", 13 },
                                { 102, "Vietän mielekästä vapaa-aikaa ja rentoudun minulle tärkeiden asioiden parissa.", "G", 13 },
                                { 101, "Koen olevani hyväksytty.", "F", 13 },
                                { 99, "Minulla on läheisiä ihmissuhteita ja varaan niille aikaa.", "D", 13 },
                                { 106, "Pystyn suoriutumaan työtehtävistäni paineen alla.", "K", 13 },
                                { 98, "Syön terveellisesti.", "C", 13 },
                                { 97, "Lepään ja nukun tarpeeksi.", "B", 13 },
                                { 96, "Pidän huolta fyysisestä kunnostani.", "A", 13 },
                                { 100, "Koen onnistumisen tunteita.", "E", 13 },
                                { 107, "Tiedän, mistä voin tarvittaessa kysyä ja saada apua.", "L", 13 }
                });

            migrationBuilder.InsertData(
                table: "EvalFeedbacks",
                columns: new[] { "Id", "FeedbackContent", "MaxPts", "MinPts", "QuestionSetId" },
                values: new object[,]
                {
                    { 5, "Olet ehkä vasta siirtynyt opiskelemaan korkea-asteelle tai itsenäinen työskentely ei ole sinulle tuttua. Mutta ei hätää, työskentelytaitoja, kuten kaikkia taitoja, voi kehittää. Voit tsekata vinkkejä täältä.", 2f, 0f, 2 },
                    { 29, "Luottamus omaan tekemiseen sekä päätösten teko ja riskien otto kuuluvat osaksi työelämää. Et välttämättä luota vielä omaan osaamiseesi, mutta katso täältä vinkit, joilla voit kehittää näitä taitoja.", 2f, 0f, 8 },
                    { 30, "Alat tuntea omaa osaamistasi ja uskallat ottaa jonkin verran myös ammatillisia riskejä. Voit kuitenkin vielä kehittyä näissä taidoissa, täältä saat siihen hyviä vinkkejä.", 3.5f, 2.1f, 8 },
                    { 31, "Alat olla harjaantunut riskien ottaja ja tiedät oman osaamisesi rajat. Jos haluat vielä kehittää itseäsi, katso täältä vinkit.", 4.5f, 3.6f, 8 },
                    { 32, "Tunnet oman osaamisesi kuin omat taskusi eikä riskien ottaminen pelota sinua. Jatka hyvää työtä!", 5f, 4.6f, 8 },
                    { 33, "Megatrendit, globaalit ilmiöt ja teknologinen kehitys tulevat mullistamaan yhteiskuntia ja samalla työelämän, joten tulevaisuuteen varautuminen ja tulevaisuustaitojen kehittäminen on tärkeää. Olet vielä vasta-alkaja tulevaisuustaidoissa, mutta voit ottaa osaamista haltuun näillä vinkeillä.", 2f, 0f, 9 },
                    { 34, "Huomaat omaa alaasi muuttavat tulevaisuustrendit ja osaat jo hiukan ennakoida niitä työsi kannalta. Voit kuitenkin kehittää tulevaisuusosaamistasi vielä lisää näiden vinkkien avulla.", 3.5f, 2.1f, 9 },
                    { 35, "Tunnet hyvin alaasi kohtaavia megatrendejä ja millaista osaamista tulevaisuuden työelämä sinulta vaatii. Myös kestävän kehityksen periaatteet ovat sinulle tuttuja. Tulevaisuusosaamista voi kuitenkin vielä kehittää esimerkiksi näiden vinkkien avulla.", 4.5f, 3.6f, 9 },
                    { 36, "Pohdit tulevaisuutta viikoittain ja olet varautunut sen mukanaan tuomiin haasteisiin. Omaat hyvät tulevaisuustaidot ja pelon sijaan odotat innolla, mitä tulevaisuus tuo mukanaan.", 5f, 4.6f, 9 },
                    { 37, "Ammatillinen verkostoituminen jo opintojen aikana tukee urasuunnittelua ja aktiivinen uratapahtumiin osallistuminen sekä työharjoitteluihin ja opinnäytetyöhön panostaminen auttavat kaikki oman osaamisen tunnistamista ja täten urasuunnittelua. Olet vielä urasi alkutaipaleella, mutta tsekkaa täältä vinkit, kuinka voit tukea omaa uraosaamistasi.", 2f, 0f, 10 },
                    { 38, "Olet jo kasvattanut ammatillisia verkostojasi ja sinulle alkaa valjeta, mitä haluat saavuttaa omalla urallasi. Katso täältä vinkit, joilla voit edelleen kehittää osaamistasi.", 3.5f, 2.1f, 10 },
                    { 39, "Urasuunnitelmasi alkavat olla selvillä ja osaat hyödyntää verkostojasi esimerkiksi työnhaussa. Koet varmuuden tunnetta tulevaisuuden urasi suhteen. Vielä voit kuitenkin myös kehittää osaamistasi näillä vinkeillä.", 4.5f, 3.6f, 10 },
                    { 40, "Olet verkostoitumisen ammattilainen ja sinulla on laaja kontaktiverkko, josta saat aina apua urasi kannalta. Jatka hyvää työtä!", 5f, 4.6f, 10 },
                    { 41, "Digityökalut ja työskentely digitaalisessa ympäristössä ovat läsnä kaikissa ammateissa. Siksi on tärkeä omata hyvät ja monipuoliset digitaidot. Olet vielä ehkä hiukan epävarma digikäyttäjä, mutta näillä vinkeillä voit kehittää osaamistasi.", 2f, 0f, 11 },
                    { 42, "Digityöskentely alkaa olla sinulle tuttua ja koet olevasi varma peruskäyttäjä. Voit kuitenkin kehittää vielä osaamistasi muun muassa näillä vinkeillä.", 3.5f, 2.1f, 11 },
                    { 43, "Digitaalisuus on sinulle luontevaa ja omaksut uusiakin työkaluja suht nopeasti. Jos koet vielä kehittämisen tarvetta, tsekkaa vinkit täältä.", 4.5f, 3.6f, 11 },
                    { 44, "Olet diginatiivi työntekijä, joka liikkuu sujuvasti alustalta toiselle. Jatka hyvää työtä!", 5f, 4.6f, 11 },
                    { 45, "Monesti tiimityöskentely tai projektityö saattaa tapahtua kansainvälisissä tiimeissä. Siksi toimiminen eri kulttuuri- ja kielitaustoista tulevien ihmisten kanssa on tärkeä taito osata. Olet vielä kansainvälisyytesi alussa, mutta voit kehittää omaa kansainvälisyysosaamistasi näillä vinkeillä.", 2f, 0f, 12 },
                    { 46, "Sinulla on jo jonkin verran kansainvälisiä tuttavia ja olet ehkä osallistunut johonkin kansainväliseen projektiin. Kansainvälisyydessäsi on kuitenkin vielä potentiaalia kehittyä, joten tsekkaa vinkit täältä.", 3.5f, 2.1f, 12 },
                    { 47, "Monikulttuurisuus alkaa olla sinulle tuttua ja osaat toimia hyvin eri taustan omaavien ihmisten kanssa. Jos koet vielä tarvetta kehittää omaa kansainvälisyysosaamistasi, katso vinkit täältä.", 4.5f, 3.6f, 12 },
                    { 28, "Olet luova ratkaisija, joka tuo oman visionsa esille ja selättää vaikeatkin haasteet. Jatka hyvää työtä!", 5f, 4.6f, 7 },
                    { 27, "Ongelmanratkaisu on sinulle arkipäivää ja keksit luoviakin ratkaisuja viheliäisiin ongelmiin. Jos koet vielä haluavasi kehittää taitojasi, tsekkaa nämä vinkit.", 4.5f, 3.6f, 7 },
                    { 48, "Olet kansainvälisessä ympäristössä kuin kala vedessä ja osaat toimia useilla eri kielillä monenlaisissa eri projekteissa. Jatka hyvää työtä!", 5f, 4.6f, 12 },
                    { 25, "Maailma on täynnä viheliäisiä ongelmia ja työtehtävät keskittyvät entistä enemmän asiakkaiden ongelmien ratkaisuun. Ongelmanratkaisu ja luovuus myös käyvät käsi kädessä. Et ole vielä kokenut ongelmanratkaisija, mutta voit kehittää osaamistasi näillä vinkeillä.", 2f, 0f, 7 },
                    { 26, "Olet jo kokenut ongelmanratkaisija ja uskallat luoda uutta. Voit kuitenkin kehittää itseäsi näillä vinkeillä.", 3.5f, 2.1f, 7 },
                    { 6, "Taidat jo tuntea itsellesi sopivimmat työskentelytavat ja kykenet itsenäiseen työhön sekä päätöksentekoon. Voit kuitenkin vielä parantaa osaamistasi näissä taidoissa näiden vinkkien avulla.", 3.5f, 2.1f, 2 },
                    { 7, "Olet tottunut tekijä ja ehkä oletkin ollut työelämässä jo useamman vuoden. Aina voi kuitenkin kehittää omaa osaamistaan ja vinkkejä saa täältä.", 4.5f, 3.6f, 2 },
                    { 8, "Olet itsenäinen tehopakkaus, joka saa hommat hoidettua. Hienoa, jatka hyvää työtä.", 5f, 4.6f, 2 },
                    { 9, "Oman työskentelyn johtaminen on yksi tärkeimmistä työelämätaidoista, sillä projektityöt vaativat vastuun ottamista omasta työskentelystä. Myös työyhteisössä toimimisen osaaminen on tärkeää. Olet vasta alussa, mutta voit kehittää itsesi johtamista näillä vinkeillä.", 2f, 0f, 3 },
                    { 11, "Olet vastuullinen ja luotettava osa työyhteisöä ja tunnet alasi eettiset periaatteet. Jos kuitenkin koet tarvetta kehittää vielä itseäsi, katso vinkit täältä.", 4.5f, 3.6f, 3 },
                    { 12, "Olet työporukan luottopakki, joka suoriutuu tehtävistä erinomaisesti. Jatka hyvää työtä!", 5f, 4.6f, 3 },
                    { 13, "Tietoa syntyy nopeammin kuin koskaan ennen, jonka takia tiedon hankinta ja analysointitaitojen merkitys vain kasvaa työelämässä. Sinulla on vielä petrattavaa näissä taidoissa, mutta näillä vinkeillä pääset eteenpäin!", 2f, 0f, 4 },
                    { 14, "Osaat etsiä ja analysoida omaan alaasi liittyvää tietoa, mutta sinulla on vielä kehitettävää. Katso vinkkejä täältä.", 3.5f, 2.1f, 4 },
                    { 10, "Osaat jo ottaa vastuuta ja työyhteisösi voi luottaa, että hoidat tehtäväsi kunnialla. Sinulla on kuitenkin vielä kehitettävää itsesi johtamisessa. Katso vinkit täältä.", 3.5f, 2.1f, 3 },
                    { 16, "Olet tiedon haun Sherlock Holmes! Jatka hyvää työtä!", 5f, 4.6f, 4 },
                    { 17, "Tietoa syntyy nopeammin kuin koskaan ennen, jonka takia tiedon hankinta ja analysointitaitojen merkitys vain kasvaa työelämässä. Sinulla on vielä petrattavaa näissä taidoissa, mutta näillä vinkeillä pääset eteenpäin!", 2f, 0f, 5 },
                    { 18, "Osaat etsiä ja analysoida omaan alaasi liittyvää tietoa, mutta sinulla on vielä kehitettävää. Katso vinkkejä täältä.", 3.5f, 2.1f, 5 },
                    { 19, "Olet selvästi edistynyt tiedon hankinta- ja analysointitaidoissa, mutta jos haluat vielä kehittää itseäsi, katso vinkit täältä.", 4.5f, 3.6f, 5 },
                    { 20, "Olet tiedon haun Sherlock Holmes! Jatka hyvää työtä!", 5f, 4.6f, 5 },
                    { 21, "Viestinnän merkitystä työelämässä ei voi ylikorostaa ja viestintä- ja kommunikaatiotaitojen osaaminen on yleistä työelämäosaamista parhaimmillaan. Olet vielä vasta-alkaja viestinnässä, mutta kehitä taitojasi näiden vinkkien avulla.", 2f, 0f, 6 },
                    { 22, "Olet jo jonkin verran kokenut viestijä, mutta osaamisessasi on vielä kehitettävää. Näillä vinkeillä kehität itsestäsi viestinnän ammattilaisen.", 3.5f, 2.1f, 6 },
                    { 23, "Viestit ja kommunikoit sujuvasti sekä suomeksi että vierailla kielillä. Et jännitä vuorovaikutustilanteita tai suoriudut niistä kunnialla läpi. Jos kuitenkin haluat vielä kehittää itseäsi viestijänä, katso nämä vinkit läpi.", 4.5f, 3.6f, 6 },
                    { 24, "Olet viestinnän moniottelija, joka selviää kaikenlaisista vuorovaikutustilanteista ammattilaisen itsevarmuudella. Jatka hyvää työtä!", 5f, 4.6f, 6 },
                    { 15, "Olet selvästi edistynyt tiedon hankinta- ja analysointitaidoissa, mutta jos haluat vielä kehittää itseäsi, katso vinkit täältä.", 4.5f, 3.6f, 4 }
                });

            migrationBuilder.InsertData(
                table: "EvalImprovements",
                columns: new[] { "Id", "ImprovementContent", "ImprovementVideoUrl", "QuestionSetId" },
                values: new object[,]
                {
                    { 10, "Maailma muuttuu nopeammin kuin koskaan ennen. Siksi on tärkeää myös ymmärtää tulevaisuutta sekä millaisia taitoja tulevaisuuden ymmärtäminen vaatii. Varaa kalenteristasi joka viikko aikaa noin 10-15 minuuttia, jolloin pohdit tulevaisuutta. Miltä tulevaisuus näyttää, mitä teknologinen kehitys tarkoittaa omalla alallani, millaisia taitoja tarvitsen tulevaisuudessa alallani, mikä vaikutus megatrendeillä (esim. ilmastonmuutos, kaupungistuminen, tekoäly) on omaan uraani, mitä haluan saavuttaa elämässäni pitkällä aikavälillä, missä näen itseni 10, 20 tai 30 vuoden päästä? Tulevaisuudesta on paljon tutkimusta ja sitä on saatavilla esimerkiksi kirjoissa, podcasteissa ja videoissa. Tulevaisuuteen tutustuminen myös hälventää ennakkoluuloja ja pelkoja, joita siihen liittyy ja auttaa sinua varautumaan paremmin tuleviin haasteisiin. Tulevaisuusosaaminen on yksi tulevaisuuden ydinkompetensseista.", "https://www.youtube.com/embed/V-kVfGk8Zqs", 10 },
                    { 9, "Kun olet muodostanut käsityksen omasta asiantuntijuudestasi ja tunnet oman ammatti-identiteettisi, sinun on helpompi myös ottaa riskejä työelämässä. Jos luotat itseesi ja omiin taitoihisi, myös riskien ottaminen helpottuu. Riskien ottaminen ei kuitenkaan tarkoita elämistä vaaran vyöhykkeellä, vaan sellaisten päätösten tekemistä, joiden takana uskallat seisoa, vaikka muut saattaisivatkin tuomita ideasi. Tärkeintä on, että luotat itseesi. Toki kaikki riskit eivät kannata, mutta koulumaailma antaa hyvät mahdollisuudet harjoittaa riskinottokykyä turvallisessa ympäristössä. Jos saat tehtäväksesi jonkin projektin, tee se täysin uudella tavalla, ja pysy päätöksesi takana. Jos riskin ottaminen ei kannattanut, reflektoi ja mieti, mitä olisit voinut tehdä toisin. Jos projekti taas onnistui, reflektoi kokemusta ja mieti, miten voisit kehittää uuttaa ideaasi edelleen.", "https://www.youtube.com/embed/V-kVfGk8Zqs", 9 },
                    { 8, "Innovaatio ja luovuus ovat linkittyneet ongelmanratkaisuun. Monimutkaiset ongelmat vaativat luovia ratkaisuja, jotka puolestaan voivat synnyttää uusia innovaatioita. Innovaatio ei ole ainoastaan uusi tuote tai palvelu, jota jokin start up alkaa kehittämään, vaan innovaatio voi olla myös uusi tapa työskennellä tai tehdä asioita. Se voi olla hyvinkin yksinkertainen asia, jota ei vain aiemmin ole osattu ajatella. Innovaatiota ja luovuutta voit kehittää harrastamalla monipuolisesti luovuutta harjoittavia asioita kuten kuvataidetta, kulttuuria tai musiikkia. Voit myös osallistua Hackathoneihin tai vastaaviin tapahtumiin, joissa pääset työskentelemään täysin vieraiden ihmisten kanssa ja tuottamaan ideoita, joita ei olisi missään muualla syntynyt. Luovuus ei ole aina tuottavaa eikä sen tarvitsekaan olla. Joskus on hyvä olla myös ”epätuottava” ja vaikka vaeltaa metsässä kuunnellen luonnon ääniä tai käydä piipahtamassa kotikaupungin museossa ilman sen suurempaa syytä. Spontaanit ja mahdollisimman erilaiset kokemukset altistavat aivomme uusille asioille ja ideoille ja välillä aivotkin kaipaavat jotain täysin uutta. Panosta myös uneen, ravintoon, liikuntaan sekä kokonaisvaltaiseen hyvinvointiin, sillä terve ja levännyt yksilö on kaikista luovimmillaan.", "https://www.youtube.com/embed/V-kVfGk8Zqs", 8 },
                    { 7, "Ongelmia ja haasteita on maailma pullollaan. Onkin tärkeää miettiä, miten haasteet ratkaistaan. Ongelmanratkaisutaitoja voit kehittää osallistumalla erilaisiin kehittämishankkeisiin tai esimerkiksi Hackathoneihin, joissa ideana on ratkaista monimutkaisia haasteita monialaisissa tiimeissä. Ongelmia ei kannata pelätä, vaan kannattaa olla oma-aloitteinen ja aktiivinen ja tarttua haasteisiin. Tekemällä jotain asioiden eteen, voi vaikuttaa enemmän kuin ajattelemalla, että joku muu hoitaa. Tässä auttavat myös intohimot. Kun olet intohimoinen jostain asiasta, keskitä energiasi ratkaisemaan haasteita, jotka estävät intohimoasi toteutumasta. Muista, että ei ole yhtä oikeaa ratkaisua vaan ongelmat ovat moniuloitteisia ja ne voidaan ratkaista monella eri tavalla. Tärkeintä on yrittää.", "https://www.youtube.com/embed/V-kVfGk8Zqs", 7 },
                    { 2, "Työskentelytaitoja voit kehittää ottamalla osaa erilaisiin aktiviteetteihin. Hyödynnä opintojen aikana mahdollisuudet osallistua tapahtumajärjestämiseen, järjestötoimintaan, projektitöihin tai vaikka hankkeen avustaviin työtehtäviin. Mitä monipuolisempaa kokemusta haalit opintojesi aikana erilaisista töistä, sitä paremmat työskentelyvalmiudet sinulla on työskennellä erilaisissa tehtävissä, erilaisissa organisaatioissa ja erilaisissa tiimeissä. Olemalla avoin, positiivinen ja joustava sopeudut paremmin muutokseen ja erilaisiin työtehtäviin. Työ on paras opettaja kuhunkin työtehtävään, mutta valmiuksia työskennellä eri tavoin on mahdollista kehittää osoittamalla motivaatiota sekä osallistumalla mahdollisimman monenlaisiin projekteihin.", "https://www.youtube.com/embed/V-kVfGk8Zqs", 2 },
                    { 5, "Sosiaaliset- sekä yhteistyötaidot korostuvat nykypäivänä entistä enemmän. Tulevalla työpaikallasi voi olla eri kulttuuritaustan omaavia ihmisiä tai voit joutua työskentelemään osana tiimiä, jolloin oman työn tulokset ovat tiimin tuloksia. Tällaisessa työskentelyssä yhteistyötaidot korostuvat ja voit kehittää niitä esimerkiksi osallistumalla erilaisiin projekteihin tai tapahtumajärjestämiseen, joita tehdään usein tiimeissä. Myös vapaaehtoistyö voi auttaa kehittämään yhteistyötaitoja, voit esimerkiksi lähteä ulkomaille kansainväliseen vapaaehtoistyöhön tai toimia Suomessa vapaaehtoisena. Kohtaamalla eri taustoista tulevia ihmisiä ennakkoluulottomasti ja avoimella asenteella, kehität omia yhteistyötaitojasi, mutta saatat myös sattumalta laajentaa elämänpiiriäsi ja saada uusia ystäviä. Aina yhteistyö ei ole kuitenkaan ruusuilla tanssimista ja kannattaakin toimia välillä jossain projektissa tiimin vetäjänä. Jos konflikteja tai ristiriitatilanteita nousee esille, pyri ratkaisemaan ne yhdessä muiden kanssa. Reflektoi myös aiempia tiimityökokemuksiasi ja mieti, mitä olisit voinut tehdä toisin ja missä puolestaan onnistuit mielestäsi hyvin.", "https://www.youtube.com/embed/V-kVfGk8Zqs", 5 },
                    { 4, "Tiedon hankintataidot ovat kuin pyörällä ajo, kun sen kerran oppii, sen muistaa lopun ikänsä, mutta ammattilaiseksi voi tulla vain sitkeällä harjoittelulla. Voit kehittää tiedon hankintataitoja kirjoittamalla mahdollisimman paljon ja monenlaisia tekstejä, joissa hyödynnät myös erilaisia lähteitä. Päiväkirja on perinteinen tapa harjoittaa niin kirjoitus- kuin tiedon hankinta- ja analysointitaitoja, mutta voit kokeilla myös pitää asiantuntijablogia, jossa kirjoitat omaan asiantuntijuuteesi liittyvistä teemoista itsellesi mielekkäällä tavalla. Myös raporttien, esseiden ja muiden harjoitustöiden tekeminen kehittää tiedon hankintaa. Voit myös toimia vertaismentorina opiskelukavereillesi tai voitte pitää yhdessä luku- tai kirjoituspiiriä, jossa arvioitte kriittisesti lukemaanne tai kirjoittamaanne. Oman ajatteluhorisontin laajentaminen muiden kanssa kehittää kriittistä ajattelua.", "https://www.youtube.com/embed/V-kVfGk8Zqs", 4 },
                    { 3, "Itsensä johtaminen on yksi tärkeimmistä taidoista, joka yksilön tulee osata työelämässä, joka ei kulje enää lineaarista polkua pitkin vaan on pikemminkin verkosto erilaisia mahdollisuuksia. Oman työskentelyn johtamista voi kehittää omien intohimojensa kautta. Mieti, mistä olet intohimoinen ja kulje intohimoasi kohti. Työtehtävät voivat olla hyvinkin erilaisia urasi varrella, mutta löytämällä elämänsä punaisen langan, voi kehittää itseään ja asettaa itselleen tavoitteita, vaikka työnantaja vaihtuisi kahden vuoden välein. Tärkeää on myös osata reflektoida aiemmin koettua ja opittua ja kehittää itseään omien kokemusten kautta. Mitä haluaisit tehdä toisin tai missä olet onnistunut todella hyvin elämäsi aikana? Oman asiantuntijaidentiteetin löytäminen on myös tärkeä osa itsensä johtamista. Kun identiteetti on selvä, on helpompaa myös johtaa itseään. Missä sinä olet asiantuntija tai miltä haluat, että tuleva asiantuntija sinä näyttää?", "https://www.youtube.com/embed/V-kVfGk8Zqs", 3 },
                    { 11, "Urataitoja on helpoin kehittää osallistumalla erilaisiin tapahtumiin sekä verkostoitumalla oman alan ammatti-ihmisten kanssa. Aseta itsellesi tavoitteita omalla urallasi ja pyri niitä kohti. Vaikka työkenttä on pirstaleinen, pidä intohimosi punaisena lankana läpi uran, jolloin oman ammatti-identiteetin kehittäminen on helpompaa. Osallistu alumni- tai mentorointitoimintaan ja keskustele ihmisten kanssa heidän urapoluistaan. Urataidot ovat käytännössä kokoelma kaikkia aiemmin arvioimiasi taitoja ja niiden kaikkien kehittäminen tukee myös omaa urasuunnitteluasi. Mitä monipuolisempi kokemus sinulla on erilaisista työtehtävistä ja -projekteista, sitä paremmat urataidot sinulla on ja olet valmiimpi myös erilaisiin haasteisiin urallasi.", "https://www.youtube.com/embed/V-kVfGk8Zqs", 11 },
                    { 6, "Viestintätaitoja voit kehittää viestimällä. Pidä blogia, osallistu oman alasi seminaareihin tai tapahtumiin, ylläpidä jonkin organisaation some-tiliä tai luo omaa asiantuntijabrändiäsi hyödyntämällä sosiaalista mediaa ja muita työkaluja. Jos teet opinnäytetyötä tai muuta tutkimusta, käy kertomassa ja esitelmöimässä aiheesta. Yleensä oppilaitoksissa on useita mahdollisuuksia päästä esiintymään ja viestimään. Myös tapahtumajärjestäminen on hyvä mahdollisuus kehittää viestintä- ja esiintymistaitoja. Voit vaikka toimia tapahtumajuontajana. Korkeakoulussa viestintä, kommunikaatio- ja esiintymistaitojen kehittämiseen on paljon matalan kynnyksen mahdollisuuksia ja kannattaa yrittää hyödyntää niitä. Kukaan ei ole vakuuttava viestijä tai esiintyjä vaan parhaatkin puhujat ovat tulleet parhaiksi harjoittelemalla ja tekemällä satoja tai jopa tuhansia toistoja. Myös kansainvälisiin seminaareihin tai tapahtumiin kannattaa osallistua, sillä ne antavat mahdollisuuden kehittää viestintätaitoja vierailla kielillä. Oman kielitaidon riittävyyttä ei kannata pelätä, sillä kukaan ei ole täydellinen ja tärkeintä on ymmärretyksi tuleminen.", "https://www.youtube.com/embed/V-kVfGk8Zqs", 6 },
                    { 12, "Digitalisaatio on osa jokaista työpaikkaa jo nyt. Siksi onkin tärkeää omata hyvät digityötaidot. Käytä opintojesi aikana aktiivisesti eri työkaluja ja alustoja, joita sinulla on saatavilla koulusi toimesta. Älä pelkää kokeilla erilaisia sovelluksia ja pyri hyödyntämään mahdollisimman paljon erilaisia digityövälineitä projekteissa. Mitä nopeammin ja helpommin omaksut erilaiset digitaaliset työskentelytavat- ja välineet, sitä helpompaa tuleva työelämä on sinulle. Kartuta myös ymmärrystäsi sellaisista asioista kuin tekoäly tai koodaaminen. Ne tulevat osaltaan vaikuttamaan hyvin paljon tulevaan työelämään ja niiden perusymmärrys helpottaa työskentelyä tulevaisuudessa alalla kuin alalla. Jos oppilaitoksesi järjestää kursseja liittyen teknologiaan tai digitalisaatioon, osallistu niihin, vaikka ne eivät vielä olisikaan alasi kannalta relevantteja. Jo nyt traktori voi hoitaa peltotyöt itsenäisesti GPS-datan avulla tai lääkäri voi pitää etävastaanottoa pienen paikkakunnan terveyskeskuksessa. Se, miten paljon digitalisaatio tulee muokkaamaan yhteiskuntaa, on vasta alkuvaiheessa.", "https://www.youtube.com/embed/V-kVfGk8Zqs", 12 }
                });



            migrationBuilder.InsertData(
                table: "EvalFeedbacks",
                columns: new[] { "Id", "FeedbackContent", "MaxPts", "MinPts", "QuestionSetId" },
                values: new object[,]
                {
                    { 49, "Jotta työtä jaksaa tehdä, myös omasta hyvinvoinnista on huolehdittava. Terveellinen ruokavalio sekä riittävä uni ja liikunta takaavat niin fyysisen kuin psyykkisen jaksamisen työpaikalla. Sinun kannattaisi kiinnittää enemmän huomiota omaan hyvinvointiisi ja priorisoida terveytesi ennen kaikkea.", 2f, 0f, 13 },
                    { 50, "Tunnistat hyvinvoinnin ja terveyden merkityksen työstä suoriutumisen kannalta. Sinulla on kuitenkin vielä kehitettävää omassa hyvinvoinnissasi. Täältä voit löytää vinkkejä siihen.", 3.5f, 2.1f, 13 },
                    { 51, "Osaat pitää huolta omasta hyvinvoinnistasi ja ymmärrät priorisoida sitä esimerkiksi töiden edelle. Täältä löydät vielä vinkkejä, jos koet tarvetta kehittää omaa hyvinvointiasi.", 4.5f, 3.6f, 13 },
                    { 52, "Hyvinvointisi on sinulle ykkösprioriteetti ja myös huolehdit siitä asian vaatimalla tavalla. Jatka hyvää työtä!", 5f, 4.6f, 13 }
                });

            migrationBuilder.InsertData(
                table: "EvalImprovements",
                columns: new[] { "Id", "ImprovementContent", "ImprovementVideoUrl", "QuestionSetId" },
                values: new object[] { 13, "Kansainvälisyyttä voit kehittää helposti esimerkiksi lähtemällä vaihtoon opintojesi aikana tai osallistumalla johonkin kansainväliseen projektiin tai hankkeeseen, joita on käynnissä koko ajan kaikissa suomalaisissa korkeakouluissa. Voit myös toimia tuutorina Suomeen saapuville kansainvälisille opiskelijoille, mikä on hyvä mahdollisuus kansainvälistyä, jos sinulla ei ole mahdollisuutta lähteä itse vaihtoon. Voit myös osallistua kansainväliseen vapaaehtoistyöhön, jolloin pääset työskentelemään hyvinkin erilaisista taustoista tulevien ihmisten kanssa. Kannattaa myös osallistua oman alan kansainvälisiin seminaareihin, joissa on mahdollisuus verkostoitua ammatillisesti kansainvälisesti. Omasta kielitaidosta ei kannata kantaa liikaa huolta, sillä tärkeintä on ymmärretyksi tuleminen.", "https://www.youtube.com/embed/V-kVfGk8Zqs", 13 });


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "EvalFeedbacks",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "EvalImprovements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EvalImprovements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EvalImprovements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EvalImprovements",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EvalImprovements",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EvalImprovements",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EvalImprovements",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EvalImprovements",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EvalImprovements",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EvalImprovements",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "EvalImprovements",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EvalImprovements",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "QuestionSets",
                keyColumn: "Id",
                keyValue: 13);
        }
    }
}
