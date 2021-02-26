﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OivaTaitoApp.Data;

namespace OivaTaitoApp.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200708165417_Add-Content")]
    partial class AddContent
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OivaTaitoApp.Data.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GoogleId")
                        .HasColumnType("int")
                        .HasMaxLength(21);

                    b.HasKey("Id");

                    b.HasIndex("GoogleId")
                        .IsUnique();

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("OivaTaitoApp.Data.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Identifier")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("QuestionSetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionSetId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Perehdyn opiskelusuunnitelmani tavoitteisiin",
                            Identifier = "A",
                            QuestionSetId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "Asetan työskentelylleni aikataulutavoitteita",
                            Identifier = "B",
                            QuestionSetId = 1
                        },
                        new
                        {
                            Id = 3,
                            Content = "Osaan suunnitella ja aikatauluttaa opintojani",
                            Identifier = "C",
                            QuestionSetId = 1
                        },
                        new
                        {
                            Id = 4,
                            Content = "Saan työni valmiiksi aikataulussa",
                            Identifier = "D",
                            QuestionSetId = 1
                        },
                        new
                        {
                            Id = 5,
                            Content = "Pystyn selviytymään useasta yhtäaikaisesta opiskelutehtävästä ajallaan",
                            Identifier = "E",
                            QuestionSetId = 1
                        },
                        new
                        {
                            Id = 6,
                            Content = "Haluan oppia oman alani asiantuntijaksi",
                            Identifier = "F",
                            QuestionSetId = 1
                        },
                        new
                        {
                            Id = 7,
                            Content = "Osaan käyttää itselleni sopivimpia työskentelymuotoja",
                            Identifier = "A",
                            QuestionSetId = 2
                        },
                        new
                        {
                            Id = 8,
                            Content = "Keskityn oppimiseni kannalta tärkeimpiin asioihin",
                            Identifier = "B",
                            QuestionSetId = 2
                        },
                        new
                        {
                            Id = 9,
                            Content = "Pystyn suunnitelmalliseen ja tavoitteelliseen työskentelyyn",
                            Identifier = "C",
                            QuestionSetId = 2
                        },
                        new
                        {
                            Id = 10,
                            Content = "Osaan työskennellä joustavasti muuttuvissa tilanteissa",
                            Identifier = "D",
                            QuestionSetId = 2
                        },
                        new
                        {
                            Id = 11,
                            Content = "Pystyn itsenäiseen kriittiseen ajatteluun",
                            Identifier = "E",
                            QuestionSetId = 2
                        },
                        new
                        {
                            Id = 12,
                            Content = "Pystyn tekemään itsenäisiä päätöksiä",
                            Identifier = "F",
                            QuestionSetId = 2
                        },
                        new
                        {
                            Id = 13,
                            Content = "Pystyn suoriutumaan alani käytännön työtehtävistä",
                            Identifier = "G",
                            QuestionSetId = 2
                        },
                        new
                        {
                            Id = 14,
                            Content = "Osaan arvioida oman toimintani vaikutuksia",
                            Identifier = "H",
                            QuestionSetId = 2
                        },
                        new
                        {
                            Id = 15,
                            Content = "Siedän haasteita ja muutoksia työskentelyssäni",
                            Identifier = "I",
                            QuestionSetId = 2
                        },
                        new
                        {
                            Id = 16,
                            Content = "Työskentelen omaa alaani kunnioittaen ja olen rehellinen",
                            Identifier = "A",
                            QuestionSetId = 3
                        },
                        new
                        {
                            Id = 17,
                            Content = "Ymmärrän oman alani eettiset periaatteet",
                            Identifier = "B",
                            QuestionSetId = 3
                        },
                        new
                        {
                            Id = 18,
                            Content = "Otan vastuun omasta työstäni",
                            Identifier = "C",
                            QuestionSetId = 3
                        },
                        new
                        {
                            Id = 19,
                            Content = "Huomatessani työhöni/työyhteisööni vaikuttavia epäkohtia, pyrin korjaamaan niitä",
                            Identifier = "D",
                            QuestionSetId = 3
                        },
                        new
                        {
                            Id = 20,
                            Content = "Työyhteisöni voi luottaa, että teen työni kunnolla",
                            Identifier = "E",
                            QuestionSetId = 3
                        },
                        new
                        {
                            Id = 21,
                            Content = "Noudatan yhteisiä pelisääntöjä ja sopimuksia",
                            Identifier = "F",
                            QuestionSetId = 3
                        },
                        new
                        {
                            Id = 22,
                            Content = "Osaan tehdä työni tehokkaasti huomioiden erilaisia näkökulmia",
                            Identifier = "G",
                            QuestionSetId = 3
                        },
                        new
                        {
                            Id = 23,
                            Content = "Pystyn arvioimaan oman osaamiseni kehittymistä",
                            Identifier = "H",
                            QuestionSetId = 3
                        },
                        new
                        {
                            Id = 24,
                            Content = "Olen valmis kehittämään itseäni saamani palautteen kautta",
                            Identifier = "I",
                            QuestionSetId = 3
                        },
                        new
                        {
                            Id = 25,
                            Content = "En lannistu helposti",
                            Identifier = "J",
                            QuestionSetId = 3
                        });
                });

            modelBuilder.Entity("OivaTaitoApp.Data.Models.QuestionCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Identifier")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("QuestionCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Identifier = "A",
                            Title = "Oman osaamisen kehittäminen ja johtaminen"
                        },
                        new
                        {
                            Id = 2,
                            Identifier = "B",
                            Title = "Tiedon hankinta ja analysointi"
                        },
                        new
                        {
                            Id = 3,
                            Identifier = "C",
                            Title = "Yhteistyötaidot ja viestintä"
                        },
                        new
                        {
                            Id = 4,
                            Identifier = "D",
                            Title = "Innovointi ja luova ongelmanratkaisu"
                        },
                        new
                        {
                            Id = 5,
                            Identifier = "E",
                            Title = "Tulevaisuustaidot: urasuunnittelu, yrittäjyys, digitaalisuus, monikulttuurisuus, kestävä kehitys"
                        },
                        new
                        {
                            Id = 6,
                            Identifier = "f",
                            Title = "Itseluottamus ja hyvinvointi työssä"
                        });
                });

            modelBuilder.Entity("OivaTaitoApp.Data.Models.QuestionSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Identifier")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("QuestionCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("QuestionCategoryId");

                    b.ToTable("QuestionSets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Identifier = "1",
                            QuestionCategoryId = 1,
                            Title = "Tavoitteellinen työskentely ja organisointitaidot"
                        },
                        new
                        {
                            Id = 2,
                            Identifier = "2",
                            QuestionCategoryId = 1,
                            Title = "Työskentelytaidot"
                        },
                        new
                        {
                            Id = 3,
                            Identifier = "3",
                            QuestionCategoryId = 1,
                            Title = "Oman työskentelyn johtaminen"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OivaTaitoApp.Data.Models.Question", b =>
                {
                    b.HasOne("OivaTaitoApp.Data.Models.QuestionSet", "QuestionSet")
                        .WithMany("Questions")
                        .HasForeignKey("QuestionSetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OivaTaitoApp.Data.Models.QuestionSet", b =>
                {
                    b.HasOne("OivaTaitoApp.Data.Models.QuestionCategory", "QuestionCategory")
                        .WithMany("QuestionSets")
                        .HasForeignKey("QuestionCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
