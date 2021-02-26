using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OivaTaitoApp.Data.Models;

namespace OivaTaitoApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Question> Questions { get; set; }

        public DbSet<QuestionSet> QuestionSets { get; set; }
        
        public DbSet<QuestionCategory> QuestionCategories { get; set; }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<SelfEvaluation> SelfEvaluations { get; set; }

        public DbSet<EvalFeedback> EvalFeedbacks { get; set; }

        public DbSet<EvalImprovement> EvalImprovements { get; set; }

        public DbSet<SelfEvalResult> SelfEvalResults { get; set; }

        public DbSet<ImprovementLink> ImprovementLinks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>()
                .HasIndex(au => au.GoogleId)
                .IsUnique();

            #region Data Seeding

            #region Question Categories

            builder.Entity<QuestionCategory>().HasData(
                new QuestionCategory() { Id = 1, Identifier = "A", Title = "Oman osaamisen kehittäminen ja johtaminen", ColorHex = "00C9B8" },
                new QuestionCategory() { Id = 2, Identifier = "B", Title = "Tiedon hankinta ja analysointi", ColorHex = "FCD200" },
                new QuestionCategory() { Id = 3, Identifier = "C", Title = "Yhteistyötaidot ja viestintä", ColorHex = "66C46D" },
                new QuestionCategory() { Id = 4, Identifier = "D", Title = "Innovointi ja luova ongelmanratkaisu", ColorHex = "FE5E54" },
                new QuestionCategory() { Id = 5, Identifier = "E", Title = "Tulevaisuustaidot: urasuunnittelu, yrittäjyys, digitaalisuus, monikulttuurisuus, kestävä kehitys", ColorHex = "FFB3C1" },
                new QuestionCategory() { Id = 6, Identifier = "F", Title = "Itseluottamus ja hyvinvointi työssä", ColorHex = "519cd2" }
                );

            #endregion

            #region Question Sets

            // Category A (ID = 1)
            builder.Entity<QuestionSet>().HasData(
                new QuestionSet() { Id = 1, Identifier = "1", Title = "Tavoitteellinen työskentely ja organisointitaidot", QuestionCategoryId = 1 },
                new QuestionSet() { Id = 2, Identifier = "2", Title = "Työskentelytaidot", QuestionCategoryId = 1 },
                new QuestionSet() { Id = 3, Identifier = "3", Title = "Oman työskentelyn johtaminen", QuestionCategoryId = 1 }
                );

            // Cat B (ID = 2)
            builder.Entity<QuestionSet>().HasData(
                new QuestionSet() { Id = 4, Identifier = "1", Title = "Tiedon hankinta ja analysointi", QuestionCategoryId = 2 }
                );

            // Cat C (ID = 3)
            builder.Entity<QuestionSet>().HasData(
                new QuestionSet() { Id = 5, Identifier = "1", Title = "Yhteistyötaidot", QuestionCategoryId = 3 },
                new QuestionSet() { Id = 6, Identifier = "2", Title = "Viestintä- ja kommunikaatiotaidot", QuestionCategoryId = 3 }
                );

            // Cat D (ID = 4)
            builder.Entity<QuestionSet>().HasData(
                new QuestionSet() { Id = 7, Identifier = "1", Title = "Ongelmanratkaisutaidot ja innovointi", QuestionCategoryId = 4 },
                new QuestionSet() { Id = 8, Identifier = "2", Title = "Riskinottokyky / Riskien hallinta", QuestionCategoryId = 4 }
                );

            // Cat E (ID = 5)
            builder.Entity<QuestionSet>().HasData(
                new QuestionSet() { Id = 9, Identifier = "1", Title = "Tulevaisuustaidot", QuestionCategoryId = 5 },
                new QuestionSet() { Id = 10, Identifier = "2", Title = "Urataidot", QuestionCategoryId = 5 },
                new QuestionSet() { Id = 11, Identifier = "3", Title = "Digitaaliset työskentelytaidot", QuestionCategoryId = 5 },
                new QuestionSet() { Id = 12, Identifier = "4", Title = "Kansainvälisyys", QuestionCategoryId = 5 }
                );

            // Cat F (ID = 6)
            builder.Entity<QuestionSet>().HasData(
                new QuestionSet() { Id = 13, Identifier = "1", Title = "Itseluottamus ja hyvinvointi työssä", QuestionCategoryId = 6 }
                );

            #endregion

            #region Questions

            // Category A, Set 1 (ID = 1)
            builder.Entity<Question>().HasData(
                new Question() { Id = 1, Identifier = "A", Content = "Perehdyn opiskelusuunnitelmani tavoitteisiin", QuestionSetId = 1 },
                new Question() { Id = 2, Identifier = "B", Content = "Asetan työskentelylleni aikataulutavoitteita", QuestionSetId = 1 },
                new Question() { Id = 3, Identifier = "C", Content = "Osaan suunnitella ja aikatauluttaa opintojani", QuestionSetId = 1 },
                new Question() { Id = 4, Identifier = "D", Content = "Saan työni valmiiksi aikataulussa", QuestionSetId = 1 },
                new Question() { Id = 5, Identifier = "E", Content = "Pystyn selviytymään useasta yhtäaikaisesta opiskelutehtävästä ajallaan", QuestionSetId = 1 },
                new Question() { Id = 6, Identifier = "F", Content = "Haluan oppia oman alani asiantuntijaksi", QuestionSetId = 1 }
                );

            // Cat A, Set 2 (ID = 2)
            builder.Entity<Question>().HasData(
                new Question() { Id = 7, Identifier = "A", Content = "Osaan käyttää itselleni sopivimpia työskentelymuotoja", QuestionSetId = 2 },
                new Question() { Id = 8, Identifier = "B", Content = "Keskityn oppimiseni kannalta tärkeimpiin asioihin", QuestionSetId = 2 },
                new Question() { Id = 9, Identifier = "C", Content = "Pystyn suunnitelmalliseen ja tavoitteelliseen työskentelyyn", QuestionSetId = 2 },
                new Question() { Id = 10, Identifier = "D", Content = "Osaan työskennellä joustavasti muuttuvissa tilanteissa", QuestionSetId = 2 },
                new Question() { Id = 11, Identifier = "E", Content = "Pystyn itsenäiseen kriittiseen ajatteluun", QuestionSetId = 2 },
                new Question() { Id = 12, Identifier = "F", Content = "Pystyn tekemään itsenäisiä päätöksiä", QuestionSetId = 2 },
                new Question() { Id = 13, Identifier = "G", Content = "Pystyn suoriutumaan alani käytännön työtehtävistä", QuestionSetId = 2 },
                new Question() { Id = 14, Identifier = "H", Content = "Osaan arvioida oman toimintani vaikutuksia", QuestionSetId = 2 },
                new Question() { Id = 15, Identifier = "I", Content = "Siedän haasteita ja muutoksia työskentelyssäni", QuestionSetId = 2 }
                );

            // Cat A, Set 3 (ID = 3)
            builder.Entity<Question>().HasData(
                new Question() { Id = 16, Identifier = "A", Content = "Työskentelen omaa alaani kunnioittaen ja olen rehellinen", QuestionSetId = 3 },
                new Question() { Id = 17, Identifier = "B", Content = "Ymmärrän oman alani eettiset periaatteet", QuestionSetId = 3 },
                new Question() { Id = 18, Identifier = "C", Content = "Otan vastuun omasta työstäni", QuestionSetId = 3 },
                new Question() { Id = 19, Identifier = "D", Content = "Huomatessani työhöni/työyhteisööni vaikuttavia epäkohtia, pyrin korjaamaan niitä", QuestionSetId = 3 },
                new Question() { Id = 20, Identifier = "E", Content = "Työyhteisöni voi luottaa, että teen työni kunnolla", QuestionSetId = 3 },
                new Question() { Id = 21, Identifier = "F", Content = "Noudatan yhteisiä pelisääntöjä ja sopimuksia", QuestionSetId = 3 },
                new Question() { Id = 22, Identifier = "G", Content = "Osaan tehdä työni tehokkaasti huomioiden erilaisia näkökulmia", QuestionSetId = 3 },
                new Question() { Id = 23, Identifier = "H", Content = "Pystyn arvioimaan oman osaamiseni kehittymistä", QuestionSetId = 3 },
                new Question() { Id = 24, Identifier = "I", Content = "Olen valmis kehittämään itseäni saamani palautteen kautta", QuestionSetId = 3 },
                new Question() { Id = 25, Identifier = "J", Content = "En lannistu helposti", QuestionSetId = 3 }
                );

            // Cat B, Set 1 (ID = 4)
            builder.Entity<Question>().HasData(
                new Question() { Id = 26, Identifier = "A", Content = "Osaan etsiä omaan alaani liittyvää luotettavaa tietoa", QuestionSetId = 4 },
                new Question() { Id = 27, Identifier = "B", Content = "Ymmärrän tekijänoikeudet ja noudatan niitä", QuestionSetId = 4 },
                new Question() { Id = 28, Identifier = "C", Content = "Osaan analysoida ja soveltaa alaani liittyvää tieteellistä tietoa", QuestionSetId = 4 },
                new Question() { Id = 29, Identifier = "D", Content = "Osaan arvioida kriittisesti lähteiden luotettavuutta.", QuestionSetId = 4 },
                new Question() { Id = 30, Identifier = "E", Content = "Tunnen oman alani tärkeimmät toimijat ja seuraan alani kehitystä", QuestionSetId = 4 }
                );

            // Cat C, Set 1 (ID = 5)
            builder.Entity<Question>().HasData(
                new Question() { Id = 31, Identifier = "A", Content = "Minulla on hyvät vuorovaikutustaidot", QuestionSetId = 5 },
                new Question() { Id = 32, Identifier = "B", Content = "Osaan työskennellä asiakaslähtöisesti", QuestionSetId = 5 },
                new Question() { Id = 33, Identifier = "C", Content = "Olen empaattinen ja huomioin työyhteisöni jäsenet", QuestionSetId = 5 },
                new Question() { Id = 34, Identifier = "D", Content = "Osaan antaa kehittävää palautetta", QuestionSetId = 5 },
                new Question() { Id = 35, Identifier = "E", Content = "Olen valmis jakamaan osaamistani ja ideoitani tiimissä", QuestionSetId = 5 },
                new Question() { Id = 36, Identifier = "F", Content = "Huolehdin, että tiimin työskentely on tavoitteellista", QuestionSetId = 5 },
                new Question() { Id = 37, Identifier = "G", Content = "Otan huomioon kriittisen ja kehittävän palautteen", QuestionSetId = 5 },
                new Question() { Id = 38, Identifier = "H", Content = "Olen tasapuolinen kaikkia tiimini jäseniä kohtaan", QuestionSetId = 5 },
                new Question() { Id = 39, Identifier = "I", Content = "Kannustan muita tiimini jäseniä yhteisten tavoitteiden saavuttamiseksi", QuestionSetId = 5 },
                new Question() { Id = 40, Identifier = "J", Content = "Pyrin ratkaisemaan tiimityöskentelyyn liittyviä haasteita", QuestionSetId = 5 },
                new Question() { Id = 41, Identifier = "K", Content = "Autan muita tarvittaessa", QuestionSetId = 5 },
                new Question() { Id = 42, Identifier = "L", Content = "Osaan toimia yhteistyössä muiden alojen ammattilaisten kanssa", QuestionSetId = 5 }
                );

            // Cat C, Set 2 (ID = 6)
            builder.Entity<Question>().HasData(
                new Question() { Id = 43, Identifier = "A", Content = "Osaan esitellä työni tuloksia ymmärrettävästi", QuestionSetId = 6 },
                new Question() { Id = 44, Identifier = "B", Content = "Osaan kuvata omaa osaamistani monipuolisesti", QuestionSetId = 6 },
                new Question() { Id = 45, Identifier = "C", Content = "Osaan viestiä ammatillisesti vieraalla kielellä (a-kieli)", QuestionSetId = 6 },
                new Question() { Id = 46, Identifier = "D", Content = "Osaan viestiä ammatillisesti toisella kotimaisella kielellä", QuestionSetId = 6 },
                new Question() { Id = 47, Identifier = "E", Content = "Osaan esiintyä vaikuttavasti", QuestionSetId = 6 },
                new Question() { Id = 48, Identifier = "F", Content = "Uskallan pitää puoliani sekä perustella näkökantaani", QuestionSetId = 6 },
                new Question() { Id = 49, Identifier = "G", Content = "Osaan ilmaista itseäni kirjallisesti", QuestionSetId = 6 },
                new Question() { Id = 50, Identifier = "H", Content = "Osaan suunnitella ja toteuttaa viestintää eri viestintävälineitä hyödyntämällä", QuestionSetId = 6 }
                );

            // Cat D, Set 1 (ID = 7)
            builder.Entity<Question>().HasData(
                new Question() { Id = 51, Identifier = "A", Content = "Huomatessani ongelmia pyrin löytämään niihin ratkaisuvaihtoehtoja", QuestionSetId = 7 },
                new Question() { Id = 52, Identifier = "B", Content = "Olen kriittinen pohtiessani jo olemassa olevien ratkaisujen toimivuutta", QuestionSetId = 7 },
                new Question() { Id = 53, Identifier = "C", Content = "Osaan ratkaista ammatillisia ongelmia", QuestionSetId = 7 },
                new Question() { Id = 54, Identifier = "D", Content = "Osaan hyödyntää aiemmin opittua uudessa tilanteessa", QuestionSetId = 7 },
                new Question() { Id = 55, Identifier = "E", Content = "Olen kekseliäs ja kehitän uusia ideoita", QuestionSetId = 7 },
                new Question() { Id = 56, Identifier = "F", Content = "Osaan suunnitella ideoistani toimintakelpoisia ratkaisuja", QuestionSetId = 7 },
                new Question() { Id = 57, Identifier = "G", Content = "Tunnistan mahdollisuuksia, joissa voin laajentaa ammatillisen toimintani rajoja", QuestionSetId = 7 },
                new Question() { Id = 58, Identifier = "H", Content = "Haluan kehittää omaa alaani", QuestionSetId = 7 },
                new Question() { Id = 59, Identifier = "I", Content = "Haluan olla innovoimassa oman alani kehittymistä yhteistyössä muiden alojen kanssa", QuestionSetId = 7 }
                );

            // Cat D, Set 2 (ID = 8)
            builder.Entity<Question>().HasData(
                new Question() { Id = 60, Identifier = "A", Content = "Uskon omaan tekemiseeni ja uskallan kokeilla vaihtoehtoisia toimintatapoja", QuestionSetId = 8 },
                new Question() { Id = 61, Identifier = "B", Content = "Luotan omaan ammatilliseen osaamiseeni", QuestionSetId = 8 },
                new Question() { Id = 62, Identifier = "C", Content = "Tunnistan alaani liittyviä riskejä", QuestionSetId = 8 },
                new Question() { Id = 63, Identifier = "D", Content = "Toimin alaani liittyvien riskien hallitsemiseksi", QuestionSetId = 8 }
                );

            // Cat E, Set 1 (ID = 9)
            builder.Entity<Question>().HasData(
                new Question() { Id = 64, Identifier = "A", Content = "Osaan varautua alani muutoksiin", QuestionSetId = 9 },
                new Question() { Id = 65, Identifier = "B", Content = "Olen kiinnostunut osaamiseni kehittämisestä", QuestionSetId = 9 },
                new Question() { Id = 66, Identifier = "C", Content = "Osaan viedä muutoksia eteenpäin yhteisössäni", QuestionSetId = 9 },
                new Question() { Id = 67, Identifier = "D", Content = "Tunnen kestävän kehityksen periaatteet ja osaan soveltaa niitä alallani", QuestionSetId = 9 },
                new Question() { Id = 68, Identifier = "E", Content = "Osaan tuottaa ymmärrettävää tietoa tulevaisuuden tarpeisiin", QuestionSetId = 9 },
                new Question() { Id = 69, Identifier = "F", Content = "Ymmärrän oman alani osana globaalia maailmaa", QuestionSetId = 9 },
                new Question() { Id = 70, Identifier = "G", Content = "Haluan olla vaikuttamassa oman alani kehittämiseen osana muuta yhteiskunnallista kehitystä", QuestionSetId = 9 }
                );

            // Cat E, Set 2 (ID = 10)
            builder.Entity<Question>().HasData(
                new Question() { Id = 71, Identifier = "A", Content = "Kehitän omaa ammatillista osaamistani työharjoitteluiden tai työkokemuksen kautta", QuestionSetId = 10 },
                new Question() { Id = 72, Identifier = "B", Content = "Kasvatan ammatillisia verkostojani jo opintojeni aikana", QuestionSetId = 10 },
                new Question() { Id = 73, Identifier = "C", Content = "Opinnäytetyöni tukee ammatillista kehittymistäni", QuestionSetId = 10 },
                new Question() { Id = 74, Identifier = "D", Content = "Tunnistan osaamiseni ja osaan hakea sitä vastaavia työtehtäviä", QuestionSetId = 10 },
                new Question() { Id = 75, Identifier = "E", Content = "Osaan projektien hallintaa ja hyödyntää siihen kuuluvia työkaluja", QuestionSetId = 10 },
                new Question() { Id = 76, Identifier = "F", Content = "Osaan kehittää, organisoida ja hallita omaa liiketoimintaa", QuestionSetId = 10 },
                new Question() { Id = 77, Identifier = "G", Content = "Asetan uratavoitteita ja pyrin niitä kohti", QuestionSetId = 10 },
                new Question() { Id = 78, Identifier = "H", Content = "Kehitän työelämätaitojani", QuestionSetId = 10 },
                new Question() { Id = 79, Identifier = "I", Content = "Seuraan oman alani ja osaamiseeni liittyviä työmahdollisuuksia aktiivisesti", QuestionSetId = 10 },
                new Question() { Id = 80, Identifier = "J", Content = "Osallistun oman alan tapahtumiin ja seminaareihin", QuestionSetId = 10 },
                new Question() { Id = 81, Identifier = "K", Content = "Ennakoin urallani kohtaamiani muutoksia", QuestionSetId = 10 }
                );

            // Cat E, Set 3 (ID = 11)
            builder.Entity<Question>().HasData(
                new Question() { Id = 82, Identifier = "A", Content = "Osaan käyttää oman alani kannalta keskeisiä digitaalisia työkaluja", QuestionSetId = 11 },
                new Question() { Id = 83, Identifier = "B", Content = "Osaan käsitellä oman alani dataa", QuestionSetId = 11 },
                new Question() { Id = 84, Identifier = "C", Content = "Osaan suojata oman digitaalisen identiteettini", QuestionSetId = 11 },
                new Question() { Id = 85, Identifier = "D", Content = "Osaan luoda ja jakaa digitaalisia sisältöjä", QuestionSetId = 11 },
                new Question() { Id = 86, Identifier = "E", Content = "Osaan käyttää digitaalisia työkaluja yhteistyöhön ja viestintään", QuestionSetId = 11 },
                new Question() { Id = 87, Identifier = "F", Content = "Osaan toimia turvallisesti digitaalisissa ympäristöissä", QuestionSetId = 11 },
                new Question() { Id = 88, Identifier = "G", Content = "Osaan toimia digitaalisessa ympäristössä toisia kunnioittaen", QuestionSetId = 11 },
                new Question() { Id = 89, Identifier = "H", Content = "Osaan arvioida kriittisesti digitaalisten sisältöjen luotettavuutta", QuestionSetId = 11 }
                );

            // Cat E, Set 4 (ID = 12)
            builder.Entity<Question>().HasData(
                new Question() { Id = 90, Identifier = "A", Content = "Ymmärrän erilaisia kulttuuritaustoja ja osaan huomioida niiden merkitystä vuorovaikutuksessa", QuestionSetId = 12 },
                new Question() { Id = 91, Identifier = "B", Content = "Osaan toimia monikulttuurisessa ympäristössä toisia kunnioittavasti", QuestionSetId = 12 },
                new Question() { Id = 92, Identifier = "C", Content = "Tunnistan alani kansainväliset verkostot.", QuestionSetId = 12 },
                new Question() { Id = 93, Identifier = "D", Content = "Kasvatan ammatillista verkostoani kansainvälisesti", QuestionSetId = 12 },
                new Question() { Id = 94, Identifier = "E", Content = "Osaan toimia monenlaisissa yhteisöissä riippumatta sijainnista tai kielestä", QuestionSetId = 12 },
                new Question() { Id = 95, Identifier = "F", Content = "Seuraan globaalia mediaa", QuestionSetId = 12 }
                );

            // Cat F, Set 1 (ID = 13)
            builder.Entity<Question>().HasData(
                new Question() { Id = 96, Identifier = "A", Content = "Pidän huolta fyysisestä kunnostani", QuestionSetId = 13 },
                new Question() { Id = 97, Identifier = "B", Content = "Lepään ja nukun tarpeeksi", QuestionSetId = 13 },
                new Question() { Id = 98, Identifier = "C", Content = "Syön terveellisesti", QuestionSetId = 13 },
                new Question() { Id = 99, Identifier = "D", Content = "Minulla on läheisiä ihmissuhteita ja varaan niille aikaa", QuestionSetId = 13 },
                new Question() { Id = 100, Identifier = "E", Content = "Koen onnistumisen tunteita", QuestionSetId = 13 },
                new Question() { Id = 101, Identifier = "F", Content = "Koen olevani hyväksytty", QuestionSetId = 13 },
                new Question() { Id = 102, Identifier = "G", Content = "Vietän mielekästä vapaa-aikaa ja rentoudun minulle tärkeiden asioiden parissa", QuestionSetId = 13 },
                new Question() { Id = 103, Identifier = "H", Content = "Olen oma-aloitteinen", QuestionSetId = 13 },
                new Question() { Id = 104, Identifier = "I", Content = "Otan vastuuta tekemisistäni", QuestionSetId = 13 },
                new Question() { Id = 105, Identifier = "J", Content = "Luotan itseeni alani osaajana", QuestionSetId = 13 },
                new Question() { Id = 106, Identifier = "K", Content = "Pystyn suoriutumaan työtehtävistäni paineen alla", QuestionSetId = 13 },
                new Question() { Id = 107, Identifier = "L", Content = "Tiedän, mistä voin tarvittaessa kysyä ja saada apua", QuestionSetId = 13 }
                );

            #endregion

            #region Evaluation Feedbacks

            #region Cat A
            //Cat A, Set 1 (ID = 1)
            builder.Entity<EvalFeedback>().HasData(
                new EvalFeedback() { Id = 1, MinPts = 0, MaxPts = 2,
                    FeedbackContent = "Työelämä, joka koostuu yhä useammin projektimuotoisista työtehtävistä, vaatii työntekijöiltä hyviä organisointitaitoja sekä pysymistä tavoitteissa ja dead lineissa. Organisointitaitoja voit parantaa näillä vinkeillä.",
                    QuestionSetId = 1 },

                new EvalFeedback() { Id = 2, MinPts = 2.1f, MaxPts = 3.5f,
                    FeedbackContent = "Olet selvästi jo tottunut organisoimaan työtäsi ja tavoitteellinen työskentely on sinulle tuttua. Voit kuitenkin vielä kehittää itseäsi mm. näillä vinkeillä.",
                    QuestionSetId = 1 },

                new EvalFeedback() { Id = 3, MinPts = 3.6f, MaxPts = 4.5f,
                    FeedbackContent = "Taidat olla ammattilainen organisoinnissa ja tavoitteisiin pääsemisessä. Jos kuitenkin koet, että haluaisit vielä kehittää itseäsi, tsekkaa vinkit täältä.",
                    QuestionSetId = 1 },

                new EvalFeedback() { Id = 4, MinPts = 4.6f, MaxPts = 5,
                    FeedbackContent = "KonMarikin kalpenee sinun organisointitaitojesi rinnalla. Jatka hyvää työtä!",
                    QuestionSetId = 1 }
                );

            //Cat A, Set 2 (ID = 2)
            builder.Entity<EvalFeedback>().HasData(
                new EvalFeedback()
                {
                    Id = 5, MinPts = 0, MaxPts = 2,
                    FeedbackContent = "Olet ehkä vasta siirtynyt opiskelemaan korkea-asteelle tai itsenäinen työskentely ei ole sinulle tuttua. Mutta ei hätää, työskentelytaitoja, kuten kaikkia taitoja, voi kehittää. Voit tsekata vinkkejä täältä.",
                    QuestionSetId = 2
                },

                new EvalFeedback()
                {
                    Id = 6, MinPts = 2.1f, MaxPts = 3.5f,
                    FeedbackContent = "Taidat jo tuntea itsellesi sopivimmat työskentelytavat ja kykenet itsenäiseen työhön sekä päätöksentekoon. Voit kuitenkin vielä parantaa osaamistasi näissä taidoissa näiden vinkkien avulla.",
                    QuestionSetId = 2
                },

                new EvalFeedback()
                {
                    Id = 7, MinPts = 3.6f, MaxPts = 4.5f,
                    FeedbackContent = "Olet tottunut tekijä ja ehkä oletkin ollut työelämässä jo useamman vuoden. Aina voi kuitenkin kehittää omaa osaamistaan ja vinkkejä saa täältä.",
                    QuestionSetId = 2
                },

                new EvalFeedback()
                {
                    Id = 8, MinPts = 4.6f, MaxPts = 5,
                    FeedbackContent = "Olet itsenäinen tehopakkaus, joka saa hommat hoidettua. Hienoa, jatka hyvää työtä.",
                    QuestionSetId = 2
                }
                );

            //Cat A, Set 3 (ID = 3)
            builder.Entity<EvalFeedback>().HasData(
                new EvalFeedback()
                {
                    Id = 9, MinPts = 0, MaxPts = 2,
                    FeedbackContent = "Oman työskentelyn johtaminen on yksi tärkeimmistä työelämätaidoista, sillä projektityöt vaativat vastuun ottamista omasta työskentelystä. Myös työyhteisössä toimimisen osaaminen on tärkeää. Olet vasta alussa, mutta voit kehittää itsesi johtamista näillä vinkeillä.",
                    QuestionSetId = 3
                },

                new EvalFeedback()
                {
                    Id = 10, MinPts = 2.1f, MaxPts = 3.5f,
                    FeedbackContent = "Osaat jo ottaa vastuuta ja työyhteisösi voi luottaa, että hoidat tehtäväsi kunnialla. Sinulla on kuitenkin vielä kehitettävää itsesi johtamisessa. Katso vinkit täältä.",
                    QuestionSetId = 3
                },

                new EvalFeedback()
                {
                    Id = 11, MinPts = 3.6f, MaxPts = 4.5f,
                    FeedbackContent = "Olet vastuullinen ja luotettava osa työyhteisöä ja tunnet alasi eettiset periaatteet. Jos kuitenkin koet tarvetta kehittää vielä itseäsi, katso vinkit täältä.",
                    QuestionSetId = 3
                },

                new EvalFeedback()
                {
                    Id = 12, MinPts = 4.6f, MaxPts = 5,
                    FeedbackContent = "Olet työporukan luottopakki, joka suoriutuu tehtävistä erinomaisesti. Jatka hyvää työtä!",
                    QuestionSetId = 3
                }
                );

            #endregion

            #region Cat B

            //Cat B, Set 1 (ID = 4)
            builder.Entity<EvalFeedback>().HasData(
                new EvalFeedback()
                {
                    Id = 13,
                    MinPts = 0,
                    MaxPts = 2,
                    FeedbackContent = "Tietoa syntyy nopeammin kuin koskaan ennen, jonka takia tiedon hankinta ja analysointitaitojen merkitys vain kasvaa työelämässä. Sinulla on vielä petrattavaa näissä taidoissa, mutta näillä vinkeillä pääset eteenpäin!",
                    QuestionSetId = 4
                },

                new EvalFeedback()
                {
                    Id = 14,
                    MinPts = 2.1f,
                    MaxPts = 3.5f,
                    FeedbackContent = "Osaat etsiä ja analysoida omaan alaasi liittyvää tietoa, mutta sinulla on vielä kehitettävää. Katso vinkkejä täältä.",
                    QuestionSetId = 4
                },

                new EvalFeedback()
                {
                    Id = 15,
                    MinPts = 3.6f,
                    MaxPts = 4.5f,
                    FeedbackContent = "Olet selvästi edistynyt tiedon hankinta- ja analysointitaidoissa, mutta jos haluat vielä kehittää itseäsi, katso vinkit täältä.",
                    QuestionSetId = 4
                },

                new EvalFeedback()
                {
                    Id = 16,
                    MinPts = 4.6f,
                    MaxPts = 5,
                    FeedbackContent = "Olet tiedon haun Sherlock Holmes! Jatka hyvää työtä!",
                    QuestionSetId = 4
                }
                );

            #endregion

            #region Cat C

            //Cat C, Set 1 (ID = 5)
            builder.Entity<EvalFeedback>().HasData(
                new EvalFeedback()
                {
                    Id = 17,
                    MinPts = 0,
                    MaxPts = 2,
                    FeedbackContent = "Tiimi- ja ryhmätyöskentely on uusi normi työpaikoilla tänään. Sen vuoksi yhteistyötaitojen merkitys korostuu vahvasti työelämäosaamisena. Sinulla on vielä kehitettävää taidoissasi, mutta vinkkejä löydät täältä.",
                    QuestionSetId = 5
                },

                new EvalFeedback()
                {
                    Id = 18,
                    MinPts = 2.1f,
                    MaxPts = 3.5f,
                    FeedbackContent = "Olet tottunut tiimityöntekijä ja osaat työskennellä osana ryhmää. Voit kuitenkin kehittää itseäsi näillä vinkeillä.",
                    QuestionSetId = 5
                },

                new EvalFeedback()
                {
                    Id = 19,
                    MinPts = 3.6f,
                    MaxPts = 4.5f,
                    FeedbackContent = "Olet kokenut tiimityön ammattilainen. Jos kuitenkin haluat vielä kehittää itseäsi, katso vinkit täältä.",
                    QuestionSetId = 5
                },

                new EvalFeedback()
                {
                    Id = 20,
                    MinPts = 4.6f,
                    MaxPts = 5,
                    FeedbackContent = "Tiimityöskentely on sinulle ominaisin tapa työskennellä ja selviät tiimissä kuin tiimissä. Jatka hyvää työtä!",
                    QuestionSetId = 5
                }
                );

            //Cat C, Set 2 (ID = 6)
            builder.Entity<EvalFeedback>().HasData(
                new EvalFeedback()
                {
                    Id = 21,
                    MinPts = 0,
                    MaxPts = 2,
                    FeedbackContent = "Viestinnän merkitystä työelämässä ei voi ylikorostaa ja viestintä- ja kommunikaatiotaitojen osaaminen on yleistä työelämäosaamista parhaimmillaan. Olet vielä vasta-alkaja viestinnässä, mutta kehitä taitojasi näiden vinkkien avulla.",
                    QuestionSetId = 6
                },

                new EvalFeedback()
                {
                    Id = 22,
                    MinPts = 2.1f,
                    MaxPts = 3.5f,
                    FeedbackContent = "Olet jo jonkin verran kokenut viestijä, mutta osaamisessasi on vielä kehitettävää. Näillä vinkeillä kehität itsestäsi viestinnän ammattilaisen.",
                    QuestionSetId = 6
                },

                new EvalFeedback()
                {
                    Id = 23,
                    MinPts = 3.6f,
                    MaxPts = 4.5f,
                    FeedbackContent = "Viestit ja kommunikoit sujuvasti. Et jännitä vuorovaikutustilanteita tai suoriudut niistä kunnialla läpi. Jos kuitenkin haluat vielä kehittää itseäsi viestijänä, katso nämä vinkit läpi.",
                    QuestionSetId = 6
                },

                new EvalFeedback()
                {
                    Id = 24,
                    MinPts = 4.6f,
                    MaxPts = 5,
                    FeedbackContent = "Olet viestinnän moniottelija, joka selviää kaikenlaisista vuorovaikutustilanteista ammattilaisen itsevarmuudella. Jatka hyvää työtä!",
                    QuestionSetId = 6
                }
                );

            #endregion

            #region Cat D

            //Cat D, Set 1 (ID = 7)
            builder.Entity<EvalFeedback>().HasData(
                new EvalFeedback()
                {
                    Id = 25,
                    MinPts = 0,
                    MaxPts = 2,
                    FeedbackContent = "Maailma on täynnä viheliäisiä ongelmia ja työtehtävät keskittyvät entistä enemmän asiakkaiden ongelmien ratkaisuun. Ongelmanratkaisu ja luovuus myös käyvät käsi kädessä. Et ole vielä kokenut ongelmanratkaisija, mutta voit kehittää osaamistasi näillä vinkeillä.",
                    QuestionSetId = 7
                },

                new EvalFeedback()
                {
                    Id = 26,
                    MinPts = 2.1f,
                    MaxPts = 3.5f,
                    FeedbackContent = "Olet jo kokenut ongelmanratkaisija ja uskallat luoda uutta. Voit kuitenkin kehittää itseäsi näillä vinkeillä.",
                    QuestionSetId = 7
                },

                new EvalFeedback()
                {
                    Id = 27,
                    MinPts = 3.6f,
                    MaxPts = 4.5f,
                    FeedbackContent = "Ongelmanratkaisu on sinulle arkipäivää ja keksit luoviakin ratkaisuja viheliäisiin ongelmiin. Jos koet vielä haluavasi kehittää taitojasi, tsekkaa nämä vinkit.",
                    QuestionSetId = 7
                },

                new EvalFeedback()
                {
                    Id = 28,
                    MinPts = 4.6f,
                    MaxPts = 5,
                    FeedbackContent = "Olet luova ratkaisija, joka tuo oman visionsa esille ja selättää vaikeatkin haasteet. Jatka hyvää työtä!",
                    QuestionSetId = 7
                }
                );

            //Cat D, Set 2 (ID = 8)
            builder.Entity<EvalFeedback>().HasData(
                new EvalFeedback()
                {
                    Id = 29,
                    MinPts = 0,
                    MaxPts = 2,
                    FeedbackContent = "Luottamus omaan tekemiseen sekä päätösten teko ja riskien otto kuuluvat osaksi työelämää. Et välttämättä luota vielä omaan osaamiseesi, mutta katso täältä vinkit, joilla voit kehittää näitä taitoja.",
                    QuestionSetId = 8
                },

                new EvalFeedback()
                {
                    Id = 30,
                    MinPts = 2.1f,
                    MaxPts = 3.5f,
                    FeedbackContent = "Alat tuntea omaa osaamistasi ja uskallat ottaa jonkin verran myös ammatillisia riskejä. Voit kuitenkin vielä kehittyä näissä taidoissa, täältä saat siihen hyviä vinkkejä.",
                    QuestionSetId = 8
                },

                new EvalFeedback()
                {
                    Id = 31,
                    MinPts = 3.6f,
                    MaxPts = 4.5f,
                    FeedbackContent = "Alat olla harjaantunut riskien ottaja ja tiedät oman osaamisesi rajat. Jos haluat vielä kehittää itseäsi, katso täältä vinkit.",
                    QuestionSetId = 8
                },

                new EvalFeedback()
                {
                    Id = 32,
                    MinPts = 4.6f,
                    MaxPts = 5,
                    FeedbackContent = "Tunnet oman osaamisesi kuin omat taskusi eikä riskien ottaminen pelota sinua. Jatka hyvää työtä!",
                    QuestionSetId = 8
                }
                );

            #endregion

            #region Cat E

            //Cat E, Set 1 (ID = 9)
            builder.Entity<EvalFeedback>().HasData(
                new EvalFeedback()
                {
                    Id = 33,
                    MinPts = 0,
                    MaxPts = 2,
                    FeedbackContent = "Megatrendit, globaalit ilmiöt ja teknologinen kehitys tulevat mullistamaan yhteiskuntia ja samalla työelämän, joten tulevaisuuteen varautuminen ja tulevaisuustaitojen kehittäminen on tärkeää. Olet vielä vasta-alkaja tulevaisuustaidoissa, mutta voit ottaa osaamista haltuun näillä vinkeillä.",
                    QuestionSetId = 9
                },

                new EvalFeedback()
                {
                    Id = 34,
                    MinPts = 2.1f,
                    MaxPts = 3.5f,
                    FeedbackContent = "Huomaat omaa alaasi muuttavat tulevaisuustrendit ja osaat jo hiukan ennakoida niitä työsi kannalta. Voit kuitenkin kehittää tulevaisuusosaamistasi vielä lisää näiden vinkkien avulla.",
                    QuestionSetId = 9
                },

                new EvalFeedback()
                {
                    Id = 35,
                    MinPts = 3.6f,
                    MaxPts = 4.5f,
                    FeedbackContent = "Tunnet hyvin alaasi kohtaavia megatrendejä ja millaista osaamista tulevaisuuden työelämä sinulta vaatii. Myös kestävän kehityksen periaatteet ovat sinulle tuttuja. Tulevaisuusosaamista voi kuitenkin vielä kehittää esimerkiksi näiden vinkkien avulla.",
                    QuestionSetId = 9
                },

                new EvalFeedback()
                {
                    Id = 36,
                    MinPts = 4.6f,
                    MaxPts = 5,
                    FeedbackContent = "Pohdit tulevaisuutta viikoittain ja olet varautunut sen mukanaan tuomiin haasteisiin. Omaat hyvät tulevaisuustaidot ja pelon sijaan odotat innolla, mitä tulevaisuus tuo mukanaan.",
                    QuestionSetId = 9
                }
                );

            //Cat E, Set 2 (ID = 10)
            builder.Entity<EvalFeedback>().HasData(
                new EvalFeedback()
                {
                    Id = 37,
                    MinPts = 0,
                    MaxPts = 2,
                    FeedbackContent = "Ammatillinen verkostoituminen jo opintojen aikana tukee urasuunnittelua ja aktiivinen uratapahtumiin osallistuminen sekä työharjoitteluihin ja opinnäytetyöhön panostaminen auttavat kaikki oman osaamisen tunnistamista ja täten urasuunnittelua. Olet vielä urasi alkutaipaleella, mutta tsekkaa täältä vinkit, kuinka voit tukea omaa uraosaamistasi.",
                    QuestionSetId = 10
                },

                new EvalFeedback()
                {
                    Id = 38,
                    MinPts = 2.1f,
                    MaxPts = 3.5f,
                    FeedbackContent = "Olet jo kasvattanut ammatillisia verkostojasi ja sinulle alkaa valjeta, mitä haluat saavuttaa omalla urallasi. Katso täältä vinkit, joilla voit edelleen kehittää osaamistasi.",
                    QuestionSetId = 10
                },

                new EvalFeedback()
                {
                    Id = 39,
                    MinPts = 3.6f,
                    MaxPts = 4.5f,
                    FeedbackContent = "Urasuunnitelmasi alkavat olla selvillä ja osaat hyödyntää verkostojasi esimerkiksi työnhaussa. Koet varmuuden tunnetta tulevaisuuden urasi suhteen. Vielä voit kuitenkin myös kehittää osaamistasi näillä vinkeillä.",
                    QuestionSetId = 10
                },

                new EvalFeedback()
                {
                    Id = 40,
                    MinPts = 4.6f,
                    MaxPts = 5,
                    FeedbackContent = "Olet verkostoitumisen ammattilainen ja sinulla on laaja kontaktiverkko, josta saat aina apua urasi kannalta. Jatka hyvää työtä!",
                    QuestionSetId = 10
                }
                );

            //Cat E, Set 3 (ID = 11)
            builder.Entity<EvalFeedback>().HasData(
                new EvalFeedback()
                {
                    Id = 41,
                    MinPts = 0,
                    MaxPts = 2,
                    FeedbackContent = "Digityökalut ja työskentely digitaalisessa ympäristössä ovat läsnä kaikissa ammateissa. Siksi on tärkeä omata hyvät ja monipuoliset digitaidot. Olet vielä ehkä hiukan epävarma digikäyttäjä, mutta näillä vinkeillä voit kehittää osaamistasi.",
                    QuestionSetId = 11
                },

                new EvalFeedback()
                {
                    Id = 42,
                    MinPts = 2.1f,
                    MaxPts = 3.5f,
                    FeedbackContent = "Digityöskentely alkaa olla sinulle tuttua ja koet olevasi varma peruskäyttäjä. Voit kuitenkin kehittää vielä osaamistasi muun muassa näillä vinkeillä.",
                    QuestionSetId = 11
                },

                new EvalFeedback()
                {
                    Id = 43,
                    MinPts = 3.6f,
                    MaxPts = 4.5f,
                    FeedbackContent = "Digitaalisuus on sinulle luontevaa ja omaksut uusiakin työkaluja suht nopeasti. Jos koet vielä kehittämisen tarvetta, tsekkaa vinkit täältä.",
                    QuestionSetId = 11
                },

                new EvalFeedback()
                {
                    Id = 44,
                    MinPts = 4.6f,
                    MaxPts = 5,
                    FeedbackContent = "Olet diginatiivi työntekijä, joka liikkuu sujuvasti alustalta toiselle. Jatka hyvää työtä!",
                    QuestionSetId = 11
                }
                );

            //Cat E, Set 4 (ID = 12)
            builder.Entity<EvalFeedback>().HasData(
                new EvalFeedback()
                {
                    Id = 45,
                    MinPts = 0,
                    MaxPts = 2,
                    FeedbackContent = "Monesti tiimityöskentely tai projektityö saattaa tapahtua kansainvälisissä tiimeissä. Siksi toimiminen eri kulttuuri- ja kielitaustoista tulevien ihmisten kanssa on tärkeä taito osata. Olet vielä kansainvälisyytesi alussa, mutta voit kehittää omaa kansainvälisyysosaamistasi näillä vinkeillä.",
                    QuestionSetId = 12
                },

                new EvalFeedback()
                {
                    Id = 46,
                    MinPts = 2.1f,
                    MaxPts = 3.5f,
                    FeedbackContent = "Sinulla on jo jonkin verran kansainvälisiä tuttavia ja olet ehkä osallistunut johonkin kansainväliseen projektiin. Kansainvälisyydessäsi on kuitenkin vielä potentiaalia kehittyä, joten tsekkaa vinkit täältä.",
                    QuestionSetId = 12
                },

                new EvalFeedback()
                {
                    Id = 47,
                    MinPts = 3.6f,
                    MaxPts = 4.5f,
                    FeedbackContent = "Monikulttuurisuus alkaa olla sinulle tuttua ja osaat toimia hyvin eri taustan omaavien ihmisten kanssa. Jos koet vielä tarvetta kehittää omaa kansainvälisyysosaamistasi, katso vinkit täältä.",
                    QuestionSetId = 12
                },

                new EvalFeedback()
                {
                    Id = 48,
                    MinPts = 4.6f,
                    MaxPts = 5,
                    FeedbackContent = "Olet kansainvälisessä ympäristössä kuin kala vedessä ja osaat toimia useilla eri kielillä monenlaisissa eri projekteissa. Jatka hyvää työtä!",
                    QuestionSetId = 12
                }
                );

            #endregion

            #region Cat F

            //Cat F, Set 1 (ID = 13)
            builder.Entity<EvalFeedback>().HasData(
                new EvalFeedback()
                {
                    Id = 49,
                    MinPts = 0,
                    MaxPts = 2,
                    FeedbackContent = "Jotta työtä jaksaa tehdä, myös omasta hyvinvoinnista on huolehdittava. Terveellinen ruokavalio sekä riittävä uni ja liikunta takaavat niin fyysisen kuin psyykkisen jaksamisen työpaikalla. Sinun kannattaisi kiinnittää enemmän huomiota omaan hyvinvointiisi ja priorisoida terveytesi ennen kaikkea.",
                    QuestionSetId = 13
                },

                new EvalFeedback()
                {
                    Id = 50,
                    MinPts = 2.1f,
                    MaxPts = 3.5f,
                    FeedbackContent = "Tunnistat hyvinvoinnin ja terveyden merkityksen työstä suoriutumisen kannalta. Sinulla on kuitenkin vielä kehitettävää omassa hyvinvoinnissasi. Täältä voit löytää vinkkejä siihen.",
                    QuestionSetId = 13
                },

                new EvalFeedback()
                {
                    Id = 51,
                    MinPts = 3.6f,
                    MaxPts = 4.5f,
                    FeedbackContent = "Osaat pitää huolta omasta hyvinvoinnistasi ja ymmärrät priorisoida sitä esimerkiksi töiden edelle. Täältä löydät vielä vinkkejä, jos koet tarvetta kehittää omaa hyvinvointiasi.",
                    QuestionSetId = 13
                },

                new EvalFeedback()
                {
                    Id = 52,
                    MinPts = 4.6f,
                    MaxPts = 5,
                    FeedbackContent = "Hyvinvointisi on sinulle ykkösprioriteetti ja myös huolehdit siitä asian vaatimalla tavalla. Jatka hyvää työtä!",
                    QuestionSetId = 13
                }
                );

            #endregion

            #endregion

            #region Evaluation Improvements

            builder.Entity<EvalImprovement>().HasData(
                new EvalImprovement() { Id = 1,
                    ImprovementContent = "Tavoitteellista työskentelyä sekä organisointitaitoja voit kehittää asettamalla itsellesi realistisia tavoitteita opinnoissasi tai työssäsi ja sitoutumalla niihin. Tee aikataulusuunnitelma valmistumiseesi tai jonkin pienemmän projektin ympärille ja pyri pitäytymään tavoitteessasi. Suunnittele myös tehtävämäärän jakautuminen eri päiville, esimerkiksi viikkokalenterin tekeminen aina seuraavaa viikkoa varten auttaa jäsentämään tulevan viikon työmäärää sekä purkaa stressiä, kun olet varautunut etukäteen viikon tapahtumiin. Kun saat jonkin projektin päätökseen, arvioi suoritustasi ja pohdi, mitä olisit voinut / halunnut tehdä toisin ja missä puolestaan onnistuit. Jokainen projekti on arvokas oppimiskokemus ja aikaa kannattaa käyttää myös suorituksen reflektointiin.",
                    ImprovementVideoUrl = "https://www.youtube.com/embed/UFnw4os5HQQ",
                    QuestionSetId = 1 }
                );

            builder.Entity<EvalImprovement>().HasData(
                new EvalImprovement()
                {
                    Id = 2,
                    ImprovementContent = "Työskentelytaitoja voit kehittää ottamalla osaa erilaisiin aktiviteetteihin. Hyödynnä opintojen aikana mahdollisuudet osallistua tapahtumajärjestämiseen, järjestötoimintaan, projektitöihin tai vaikka hankkeen avustaviin työtehtäviin. Mitä monipuolisempaa kokemusta haalit opintojesi aikana erilaisista töistä, sitä paremmat työskentelyvalmiudet sinulla on työskennellä erilaisissa tehtävissä, erilaisissa organisaatioissa ja erilaisissa tiimeissä. Olemalla avoin, positiivinen ja joustava sopeudut paremmin muutokseen ja erilaisiin työtehtäviin. Työ on paras opettaja kuhunkin työtehtävään, mutta valmiuksia työskennellä eri tavoin on mahdollista kehittää osoittamalla motivaatiota sekä osallistumalla mahdollisimman monenlaisiin projekteihin.",
                    ImprovementVideoUrl = "https://www.youtube.com/embed/3T3VYmro58o",
                    QuestionSetId = 2
                }
                );

            builder.Entity<EvalImprovement>().HasData(
                new EvalImprovement()
                {
                    Id = 3,
                    ImprovementContent = "Itsensä johtaminen on yksi tärkeimmistä taidoista, joka yksilön tulee osata työelämässä, joka ei kulje enää lineaarista polkua pitkin vaan on pikemminkin verkosto erilaisia mahdollisuuksia. Oman työskentelyn johtamista voi kehittää omien intohimojensa kautta. Mieti, mistä olet intohimoinen ja kulje intohimoasi kohti. Työtehtävät voivat olla hyvinkin erilaisia urasi varrella, mutta löytämällä elämänsä punaisen langan, voi kehittää itseään ja asettaa itselleen tavoitteita, vaikka työnantaja vaihtuisi kahden vuoden välein. Tärkeää on myös osata reflektoida aiemmin koettua ja opittua ja kehittää itseään omien kokemusten kautta. Mitä haluaisit tehdä toisin tai missä olet onnistunut todella hyvin elämäsi aikana? Oman asiantuntijaidentiteetin löytäminen on myös tärkeä osa itsensä johtamista. Kun identiteetti on selvä, on helpompaa myös johtaa itseään. Missä sinä olet asiantuntija tai miltä haluat, että tuleva asiantuntija sinä näyttää?",
                    ImprovementVideoUrl = "https://www.youtube.com/embed/B1NkiFrxctE",
                    QuestionSetId = 3
                }
                );

            builder.Entity<EvalImprovement>().HasData(
                new EvalImprovement()
                {
                    Id = 4,
                    ImprovementContent = "Tiedon hankintataidot ovat kuin pyörällä ajo, kun sen kerran oppii, sen muistaa lopun ikänsä, mutta ammattilaiseksi voi tulla vain sitkeällä harjoittelulla. Voit kehittää tiedon hankintataitoja kirjoittamalla mahdollisimman paljon ja monenlaisia tekstejä, joissa hyödynnät myös erilaisia lähteitä. Päiväkirja on perinteinen tapa harjoittaa niin kirjoitus- kuin tiedon hankinta- ja analysointitaitoja, mutta voit kokeilla myös pitää asiantuntijablogia, jossa kirjoitat omaan asiantuntijuuteesi liittyvistä teemoista itsellesi mielekkäällä tavalla. Myös raporttien, esseiden ja muiden harjoitustöiden tekeminen kehittää tiedon hankintaa. Voit myös toimia vertaismentorina opiskelukavereillesi tai voitte pitää yhdessä luku- tai kirjoituspiiriä, jossa arvioitte kriittisesti lukemaanne tai kirjoittamaanne. Oman ajatteluhorisontin laajentaminen muiden kanssa kehittää kriittistä ajattelua.",
                    ImprovementVideoUrl = "https://www.youtube.com/embed/3SUWplkXaHI",
                    QuestionSetId = 4
                }
                );

            builder.Entity<EvalImprovement>().HasData(
                new EvalImprovement()
                {
                    Id = 5,
                    ImprovementContent = "Sosiaaliset- sekä yhteistyötaidot korostuvat nykypäivänä entistä enemmän. Tulevalla työpaikallasi voi olla eri kulttuuritaustan omaavia ihmisiä tai voit joutua työskentelemään osana tiimiä, jolloin oman työn tulokset ovat tiimin tuloksia. Tällaisessa työskentelyssä yhteistyötaidot korostuvat ja voit kehittää niitä esimerkiksi osallistumalla erilaisiin projekteihin tai tapahtumajärjestämiseen, joita tehdään usein tiimeissä. Myös vapaaehtoistyö voi auttaa kehittämään yhteistyötaitoja, voit esimerkiksi lähteä ulkomaille kansainväliseen vapaaehtoistyöhön tai toimia Suomessa vapaaehtoisena. Kohtaamalla eri taustoista tulevia ihmisiä ennakkoluulottomasti ja avoimella asenteella, kehität omia yhteistyötaitojasi, mutta saatat myös sattumalta laajentaa elämänpiiriäsi ja saada uusia ystäviä. Aina yhteistyö ei ole kuitenkaan ruusuilla tanssimista ja kannattaakin toimia välillä jossain projektissa tiimin vetäjänä. Jos konflikteja tai ristiriitatilanteita nousee esille, pyri ratkaisemaan ne yhdessä muiden kanssa. Reflektoi myös aiempia tiimityökokemuksiasi ja mieti, mitä olisit voinut tehdä toisin ja missä puolestaan onnistuit mielestäsi hyvin.",
                    ImprovementVideoUrl = "https://www.youtube.com/embed/hjRco3g4trc",
                    QuestionSetId = 5
                }
                );

            builder.Entity<EvalImprovement>().HasData(
                new EvalImprovement()
                {
                    Id = 6,
                    ImprovementContent = "Viestintätaitoja voit kehittää viestimällä. Pidä blogia, osallistu oman alasi seminaareihin tai tapahtumiin, ylläpidä jonkin organisaation some-tiliä tai luo omaa asiantuntijabrändiäsi hyödyntämällä sosiaalista mediaa ja muita työkaluja. Jos teet opinnäytetyötä tai muuta tutkimusta, käy kertomassa ja esitelmöimässä aiheesta. Yleensä oppilaitoksissa on useita mahdollisuuksia päästä esiintymään ja viestimään. Myös tapahtumajärjestäminen on hyvä mahdollisuus kehittää viestintä- ja esiintymistaitoja. Voit vaikka toimia tapahtumajuontajana. Korkeakoulussa viestintä, kommunikaatio- ja esiintymistaitojen kehittämiseen on paljon matalan kynnyksen mahdollisuuksia ja kannattaa yrittää hyödyntää niitä. Kukaan ei ole vakuuttava viestijä tai esiintyjä vaan parhaatkin puhujat ovat tulleet parhaiksi harjoittelemalla ja tekemällä satoja tai jopa tuhansia toistoja. Myös kansainvälisiin seminaareihin tai tapahtumiin kannattaa osallistua, sillä ne antavat mahdollisuuden kehittää viestintätaitoja vierailla kielillä. Oman kielitaidon riittävyyttä ei kannata pelätä, sillä kukaan ei ole täydellinen ja tärkeintä on ymmärretyksi tuleminen.",
                    ImprovementVideoUrl = "https://www.youtube.com/embed/8AxhI4gFCdg",
                    QuestionSetId = 6
                }
                );

            builder.Entity<EvalImprovement>().HasData(
                new EvalImprovement()
                {
                    Id = 7,
                    ImprovementContent = "Ongelmia ja haasteita on maailma pullollaan. Onkin tärkeää miettiä, miten haasteet ratkaistaan. Ongelmanratkaisutaitoja voit kehittää osallistumalla erilaisiin kehittämishankkeisiin tai esimerkiksi Hackathoneihin, joissa ideana on ratkaista monimutkaisia haasteita monialaisissa tiimeissä. Ongelmia ei kannata pelätä, vaan kannattaa olla oma-aloitteinen ja aktiivinen ja tarttua haasteisiin. Tekemällä jotain asioiden eteen, voi vaikuttaa enemmän kuin ajattelemalla, että joku muu hoitaa. Tässä auttavat myös intohimot. Kun olet intohimoinen jostain asiasta, keskitä energiasi ratkaisemaan haasteita, jotka estävät intohimoasi toteutumasta. Muista, että ei ole yhtä oikeaa ratkaisua vaan ongelmat ovat moniuloitteisia ja ne voidaan ratkaista monella eri tavalla. Tärkeintä on yrittää.",
                    ImprovementVideoUrl = "https://www.youtube.com/embed/TETeXwC6GrM",
                    QuestionSetId = 7
                }
                );

            builder.Entity<EvalImprovement>().HasData(
                new EvalImprovement()
                {
                    Id = 8,
                    ImprovementContent = "Kun olet muodostanut käsityksen omasta asiantuntijuudestasi ja tunnet oman ammatti-identiteettisi, sinun on helpompi myös ottaa riskejä työelämässä. Jos luotat itseesi ja omiin taitoihisi, myös riskien ottaminen helpottuu. Riskien ottaminen ei kuitenkaan tarkoita elämistä vaaran vyöhykkeellä, vaan sellaisten päätösten tekemistä, joiden takana uskallat seisoa, vaikka muut saattaisivatkin tuomita ideasi. Tärkeintä on, että luotat itseesi. Toki kaikki riskit eivät kannata, mutta koulumaailma antaa hyvät mahdollisuudet harjoittaa riskinottokykyä turvallisessa ympäristössä. Jos saat tehtäväksesi jonkin projektin, tee se täysin uudella tavalla, ja pysy päätöksesi takana. Jos riskin ottaminen ei kannattanut, reflektoi ja mieti, mitä olisit voinut tehdä toisin. Jos projekti taas onnistui, reflektoi kokemusta ja mieti, miten voisit kehittää uuttaa ideaasi edelleen.",
                    ImprovementVideoUrl = "https://www.youtube.com/embed/n9THEiZW0-I",
                    QuestionSetId = 8
                }
                );

            builder.Entity<EvalImprovement>().HasData(
                new EvalImprovement()
                {
                    Id = 9,
                    ImprovementContent = "Maailma muuttuu nopeammin kuin koskaan ennen. Siksi on tärkeää myös ymmärtää tulevaisuutta sekä millaisia taitoja tulevaisuuden ymmärtäminen vaatii. Varaa kalenteristasi joka viikko aikaa noin 10-15 minuuttia, jolloin pohdit tulevaisuutta. Miltä tulevaisuus näyttää, mitä teknologinen kehitys tarkoittaa omalla alallani, millaisia taitoja tarvitsen tulevaisuudessa alallani, mikä vaikutus megatrendeillä (esim. ilmastonmuutos, kaupungistuminen, tekoäly) on omaan uraani, mitä haluan saavuttaa elämässäni pitkällä aikavälillä, missä näen itseni 10, 20 tai 30 vuoden päästä? Tulevaisuudesta on paljon tutkimusta ja sitä on saatavilla esimerkiksi kirjoissa, podcasteissa ja videoissa. Tulevaisuuteen tutustuminen myös hälventää ennakkoluuloja ja pelkoja, joita siihen liittyy ja auttaa sinua varautumaan paremmin tuleviin haasteisiin. Tulevaisuusosaaminen on yksi tulevaisuuden ydinkompetensseista.",
                    ImprovementVideoUrl = "https://www.youtube.com/embed/XsiaeWenc-k",
                    QuestionSetId = 9
                }
                );

            builder.Entity<EvalImprovement>().HasData(
                new EvalImprovement()
                {
                    Id = 10,
                    ImprovementContent = "Urataitoja on helpoin kehittää osallistumalla erilaisiin tapahtumiin sekä verkostoitumalla oman alan ammatti-ihmisten kanssa. Aseta itsellesi tavoitteita omalla urallasi ja pyri niitä kohti. Vaikka työkenttä on pirstaleinen, pidä intohimosi punaisena lankana läpi uran, jolloin oman ammatti-identiteetin kehittäminen on helpompaa. Osallistu alumni- tai mentorointitoimintaan ja keskustele ihmisten kanssa heidän urapoluistaan. Urataidot ovat käytännössä kokoelma kaikkia aiemmin arvioimiasi taitoja ja niiden kaikkien kehittäminen tukee myös omaa urasuunnitteluasi. Mitä monipuolisempi kokemus sinulla on erilaisista työtehtävistä ja -projekteista, sitä paremmat urataidot sinulla on ja olet valmiimpi myös erilaisiin haasteisiin urallasi.",
                    ImprovementVideoUrl = "https://www.youtube.com/embed/nmmpNNqYmU8",
                    QuestionSetId = 10
                }
                );

            builder.Entity<EvalImprovement>().HasData(
                new EvalImprovement()
                {
                    Id = 11,
                    ImprovementContent = "Digitalisaatio on osa jokaista työpaikkaa jo nyt. Siksi onkin tärkeää omata hyvät digityötaidot. Käytä opintojesi aikana aktiivisesti eri työkaluja ja alustoja, joita sinulla on saatavilla koulusi toimesta. Älä pelkää kokeilla erilaisia sovelluksia ja pyri hyödyntämään mahdollisimman paljon erilaisia digityövälineitä projekteissa. Mitä nopeammin ja helpommin omaksut erilaiset digitaaliset työskentelytavat- ja välineet, sitä helpompaa tuleva työelämä on sinulle. Kartuta myös ymmärrystäsi sellaisista asioista kuin tekoäly tai koodaaminen. Ne tulevat osaltaan vaikuttamaan hyvin paljon tulevaan työelämään ja niiden perusymmärrys helpottaa työskentelyä tulevaisuudessa alalla kuin alalla. Jos oppilaitoksesi järjestää kursseja liittyen teknologiaan tai digitalisaatioon, osallistu niihin, vaikka ne eivät vielä olisikaan alasi kannalta relevantteja. Jo nyt traktori voi hoitaa peltotyöt itsenäisesti GPS-datan avulla tai lääkäri voi pitää etävastaanottoa pienen paikkakunnan terveyskeskuksessa. Se, miten paljon digitalisaatio tulee muokkaamaan yhteiskuntaa, on vasta alkuvaiheessa.",
                    ImprovementVideoUrl = "https://www.youtube.com/embed/p627YgMMMvA",
                    QuestionSetId = 11
                }
                );

            builder.Entity<EvalImprovement>().HasData(
                new EvalImprovement()
                {
                    Id = 12,
                    ImprovementContent = "Kansainvälisyyttä voit kehittää helposti esimerkiksi lähtemällä vaihtoon opintojesi aikana tai osallistumalla johonkin kansainväliseen projektiin tai hankkeeseen, joita on käynnissä koko ajan kaikissa suomalaisissa korkeakouluissa. Voit myös toimia tuutorina Suomeen saapuville kansainvälisille opiskelijoille, mikä on hyvä mahdollisuus kansainvälistyä, jos sinulla ei ole mahdollisuutta lähteä itse vaihtoon. Voit myös osallistua kansainväliseen vapaaehtoistyöhön, jolloin pääset työskentelemään hyvinkin erilaisista taustoista tulevien ihmisten kanssa. Kannattaa myös osallistua oman alan kansainvälisiin seminaareihin, joissa on mahdollisuus verkostoitua ammatillisesti kansainvälisesti. Omasta kielitaidosta ei kannata kantaa liikaa huolta, sillä tärkeintä on ymmärretyksi tuleminen.",
                    ImprovementVideoUrl = "https://www.youtube.com/embed/DW4Gj2QpRtY",
                    QuestionSetId = 12
                }
                );

            builder.Entity<EvalImprovement>().HasData(
                new EvalImprovement()
                {
                    Id = 13,
                    ImprovementContent = "Voit tutustua aiheeseen lisää \"Kehitysehdotukset\" sivulle listattujen linkkien kautta.",
                    ImprovementVideoUrl = "",
                    QuestionSetId = 13
                }
                );

            #endregion

            #region Improvement Links

            // improvement ID = 1
            builder.Entity<ImprovementLink>().HasData(
                new ImprovementLink() { Id = 1, EvalImprovementId = 1, LinkTitle = "Video: Miksi tavoitteita on tärkeä asettaa ja miten ne saavutetaan?", LinkUrl = "https://www.youtube.com/watch?v=gSkTEgGaFXE" },
                new ImprovementLink() { Id = 2, EvalImprovementId = 1, LinkTitle = "Video: Tavoitteiden asettaminen – KIRMA", LinkUrl = "https://www.youtube.com/watch?v=xCfyg7SewkY" }
                );
            // improvement ID = 2
            builder.Entity<ImprovementLink>().HasData(
                new ImprovementLink() { Id = 3, EvalImprovementId = 2, LinkTitle = "Video: Osaamisen kehittäminen – Ida Mielityinen", LinkUrl = "https://www.youtube.com/watch?v=niHcxuzOW94" },
                new ImprovementLink() { Id = 4, EvalImprovementId = 2, LinkTitle = "Video: Uudet organisoitumismuodot ja itsensä johtaminen – LUT", LinkUrl = "https://www.youtube.com/watch?v=X5DOWi3MbPI" },
                new ImprovementLink() { Id = 5, EvalImprovementId = 2, LinkTitle = "Blogi: Joustavassa työssä tarvittavat taidot", LinkUrl = "https://etajohtaminen.fi/joustavassa-tyossa-tarvittavat-taidot/" }
                );
            // improvement ID = 3
            builder.Entity<ImprovementLink>().HasData(
                new ImprovementLink() { Id = 6, EvalImprovementId = 3, LinkTitle = "Video: Työelämätaidot osa III – Itsetuntemus", LinkUrl = "https://www.youtube.com/watch?v=SbEQebZFEtA" },
                new ImprovementLink() { Id = 7, EvalImprovementId = 3, LinkTitle = "Video: Kolme vinkkiä itsensä johtamiseen", LinkUrl = "https://www.youtube.com/watch?v=uhZq2n1XfkY" },
                new ImprovementLink() { Id = 8, EvalImprovementId = 3, LinkTitle = "Partiolaisten ohjeet oman johtajuuden itsearviointiin", LinkUrl = "https://www.partio.fi/wp-content/uploads/2018/11/Johtajuuden_itsearviointity%C3%B6kalu.pdf" },
                new ImprovementLink() { Id = 9, EvalImprovementId = 3, LinkTitle = "Podcast: Osaamisen aika – Onko osaaminen onnen lähde?", LinkUrl = "https://www.sitra.fi/artikkelit/onko-osaaminen-onnen-lahde/" }
                );
            // improvement ID = 4
            builder.Entity<ImprovementLink>().HasData(
                new ImprovementLink() { Id = 10, EvalImprovementId = 4, LinkTitle = "Video: Riku Rantala & Tunna Milonoff: Media- ja lähdekritiikki / Media and Source Criticism", LinkUrl = "https://www.youtube.com/watch?v=NGoYJAryARc" },
                new ImprovementLink() { Id = 11, EvalImprovementId = 4, LinkTitle = "Video: Lähdekritiikki", LinkUrl = "https://www.youtube.com/watch?v=wltECqudWTs" }
                );
            // improvement ID = 5
            builder.Entity<ImprovementLink>().HasData(
                new ImprovementLink() { Id = 12, EvalImprovementId = 5, LinkTitle = "Video: Työelämätaidot osa II – Vuorovaikutus", LinkUrl = "https://www.youtube.com/watch?v=iQms4At4SUM" },
                new ImprovementLink() { Id = 13, EvalImprovementId = 5, LinkTitle = "Video (podcast): Taituri-podcast: Humanistispeksi työelämätaitojen ja opintojen näkökulmasta", LinkUrl = "https://www.youtube.com/watch?v=buXt0xNQya4" },
                new ImprovementLink() { Id = 14, EvalImprovementId = 5, LinkTitle = "Blogi: Yhteistyötaidot ovat tulevaisuustaitoja", LinkUrl = "https://www.juuriharja.fi/blogi/yhteistyotaidot-ovat-tulevaisuustaitoja" },
                new ImprovementLink() { Id = 15, EvalImprovementId = 5, LinkTitle = "Podcast: Jos asiantuntija kaatuu metsässä – eli yhdessä oppiminen ja osaaminen", LinkUrl = "https://soundcloud.com/osaamiskomitea/jos-asiantuntija-kaatuu-metsassa-eli-yhdessa-oppiminen-ja-osaaminen" }
                );
            // improvement ID = 6
            builder.Entity<ImprovementLink>().HasData(
                new ImprovementLink() { Id = 16, EvalImprovementId = 6, LinkTitle = "Video: Ismo Jokinen - Esiintymis- ja viestintätaitojen merkitys työelämässä – Speakersforum", LinkUrl = "https://www.youtube.com/watch?v=1E29chrxRuE" },
                new ImprovementLink() { Id = 17, EvalImprovementId = 6, LinkTitle = "Video: Opettele neljä viestinnän keinoa, ettei sanomasi saa surmaansa", LinkUrl = "https://www.youtube.com/watch?v=G0k--QXvDa4" },
                new ImprovementLink() { Id = 18, EvalImprovementId = 6, LinkTitle = "Video: Esiintymisvalmennusvinkkejä - Niina Sainius", LinkUrl = "https://www.youtube.com/watch?v=3Gi1WMSnq04" },
                new ImprovementLink() { Id = 19, EvalImprovementId = 6, LinkTitle = "OPH: Vuorovaikutus ja viestintätaidot", LinkUrl = "https://www.oph.fi/fi/koulutus-ja-tutkinnot/vuorovaikutus-ja-viestintataidot" }
                );
            // improvement ID = 7
            builder.Entity<ImprovementLink>().HasData(
                new ImprovementLink() { Id = 20, EvalImprovementId = 7, LinkTitle = "Video: Näkökulma, Essi Ahtola: Elämä on tiimityötä", LinkUrl = "https://www.youtube.com/watch?v=oCdKiy5lwzE" },
                new ImprovementLink() { Id = 21, EvalImprovementId = 7, LinkTitle = "Blogi: Brainstorming - Miten keksiä uusi idea tyhjästä?", LinkUrl = "https://blog.smoothlynow.com/brainstorming" }
                );
            // improvement ID = 8
            builder.Entity<ImprovementLink>().HasData(
                new ImprovementLink() { Id = 22, EvalImprovementId = 8, LinkTitle = "Blogi: Riskien ottaminen ja miksi se on tärkeää bisnesmaailmassa", LinkUrl = "https://ertuki.fi/riskien-ottaminen-ja-miksi-se-on-tarkeaa-bisnesmaailmassa/" },
                new ImprovementLink() { Id = 23, EvalImprovementId = 8, LinkTitle = "Blogi: Miten uskaltaa ottaa elämässä riskejä?", LinkUrl = "https://www.lily.fi/blogit/on-my-way/miten-uskaltaa-ottaa-elamassa-riskeja/" },
                new ImprovementLink() { Id = 24, EvalImprovementId = 8, LinkTitle = "Podcast: Mitä on todellinen rohkeus?", LinkUrl = "https://play.acast.com/s/aamukahvilla/f0f9f0ba-fe8f-4830-a9fb-0de7599e3b05" }
                );
            // improvement ID = 9
            builder.Entity<ImprovementLink>().HasData(
                new ImprovementLink() { Id = 25, EvalImprovementId = 9, LinkTitle = "Video: Leena Jokinen, Turun Yliopisto - Tulevaisuuden työmarkkinoilla vaadittava osaaminen", LinkUrl = "https://www.youtube.com/watch?v=UxZyYvsSauk" },
                new ImprovementLink() { Id = 26, EvalImprovementId = 9, LinkTitle = "Video: Perttu Pölönen – Tulevaisuuden tärkein taito", LinkUrl = "https://www.youtube.com/watch?v=RKHsA8D7-bU&t=41s" },
                new ImprovementLink() { Id = 27, EvalImprovementId = 9, LinkTitle = "STM - Työelämä muuttuu - mitä työelämävalmiuksia tarvitsemme?", LinkUrl = "https://stm.fi/artikkeli/-/asset_publisher/tyoelama-muuttuu-mita-tyoelamavalmiuksia-tarvitsemme-" },
                new ImprovementLink() { Id = 28, EvalImprovementId = 9, LinkTitle = "SITRAn julkaisuja – Eväitä työelämään", LinkUrl = "https://www.sitra.fi/julkaisut/evaita-tyoelamaan/" },
                new ImprovementLink() { Id = 29, EvalImprovementId = 9, LinkTitle = "Podcast: Sunnuntaibrunssi – vieraana Perttu Pölönen", LinkUrl = "https://radioplay.fi/podcast/sunnuntaibrunssi/listen/2025608/" }
                );
            // improvement ID = 10
            builder.Entity<ImprovementLink>().HasData(
                new ImprovementLink() { Id = 30, EvalImprovementId = 10, LinkTitle = "Video: Seitsemän vetovihjettä verkostoitumiseen - Pasi Rautio", LinkUrl = "https://www.youtube.com/watch?v=oMTuBo_jHjI" },
                new ImprovementLink() { Id = 31, EvalImprovementId = 10, LinkTitle = "Video: 3 vinkkiä verkostoitumiseen | InHunt Group,", LinkUrl = "https://www.youtube.com/watch?v=Xc7rWMtt65E" },
                new ImprovementLink() { Id = 32, EvalImprovementId = 10, LinkTitle = "Someta duuniin verkkokurssi", LinkUrl = "https://sometaduuniin.fi" }
                );
            // improvement ID = 11
            builder.Entity<ImprovementLink>().HasData(
                new ImprovementLink() { Id = 33, EvalImprovementId = 11, LinkTitle = "Video: Miten digitalisaatio muuttaa työskentelyä ja osaamisen kehittämistä", LinkUrl = "https://www.youtube.com/watch?v=CJBnCd1XOvI" },
                new ImprovementLink() { Id = 34, EvalImprovementId = 11, LinkTitle = "Blogi: Digitaaliset urataidot avaavat uusia verkostoja", LinkUrl = "https://uralehti.fi/ammattilaiset/digitaaliset-urataidot-avaavat-uusia-verkostoja/" }
                );
            // improvement ID = 12
            builder.Entity<ImprovementLink>().HasData(
                new ImprovementLink() { Id = 35, EvalImprovementId = 12, LinkTitle = "Video: Kamalan ihana Amerikka – Kansainvälisyys tuo sivistystä!", LinkUrl = "https://www.youtube.com/watch?v=h7yPTK8i_Jg" },
                new ImprovementLink() { Id = 36, EvalImprovementId = 12, LinkTitle = "XAMK, Kansainvälisyysosaaminen yhä vahvemmin osaksi opintoja", LinkUrl = "https://read.xamk.fi/2017/koulutus/kansainvalisyysosaaminen-yha-vahvemmin-osaksi-opintoja/" },
                new ImprovementLink() { Id = 37, EvalImprovementId = 12, LinkTitle = "Savon sanomat, Kansainvälisyys on mahdollisuus – sinulle, minulle, meille", LinkUrl = "https://blogit.savonsanomat.fi/liiketta-liiketoimintaan/kansainvalisyys-on-mahdollisuus-sinulle-minulle-meille/" }
                );
            // improvement ID = 13
            builder.Entity<ImprovementLink>().HasData(
                new ImprovementLink() { Id = 38, EvalImprovementId = 13, LinkTitle = "Blogi: Mistä itsetunto muodostuu ja kuinka sitä voi parantaa?", LinkUrl = "https://www.mielipalvelut.fi/artikkelit/mista-itsetunto-muodostuu-ja-kuinka-sita-voi-parantaa/" },
                new ImprovementLink() { Id = 39, EvalImprovementId = 13, LinkTitle = "Blogi: Työssä jaksaminen koostuu pienistä tekijöistä – 10 vinkkiä", LinkUrl = "https://lifted.fi/blogi/tyohyvinvointi/tyossa-jaksaminen/" },
                new ImprovementLink() { Id = 40, EvalImprovementId = 13, LinkTitle = "Keva: Huolehdi omasta työhyvinvoinnistasi", LinkUrl = "https://www.keva.fi/henkiloasiakkaalle/heikentynyt-tyokyky/oma-tyohyvinvointi/" },
                new ImprovementLink() { Id = 41, EvalImprovementId = 13, LinkTitle = "Podcast: Onko burnout uusi normaali, joka on tullut työelämään jäädäkseen?", LinkUrl = "https://open.spotify.com/episode/12HXEhgMwBum2txn8uhmtE" },
                new ImprovementLink() { Id = 42, EvalImprovementId = 13, LinkTitle = "Podcast: Kokonaisvaltaisen hyvinvoinnin ihanuus ja kamaluus", LinkUrl = "https://play.acast.com/s/aamukahvilla/f6ac234a-57dc-45e4-9bae-47fe939a6b3e" },
                new ImprovementLink() { Id = 43, EvalImprovementId = 13, LinkTitle = "Mielenterveys:", LinkUrl = "https://www.mielenterveystalo.fi/" }
                );

            #endregion

            #endregion
        }
    }
}
