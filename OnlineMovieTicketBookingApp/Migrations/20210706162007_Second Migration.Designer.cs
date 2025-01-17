﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineMovieTicketBookingApp.Models;

namespace OnlineMovieTicketBookingApp.Migrations
{
    [DbContext(typeof(CinemaContext))]
    [Migration("20210706162007_Second Migration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineMovieTicketBookingApp.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_Of_Birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Bishan Street 13 Singapore 570123",
                            Date_Of_Birth = new DateTime(1990, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "janedoe@email.com",
                            First_Name = "Jane",
                            Gender = "Female",
                            Last_Name = "Doe",
                            Password = "password123",
                            Phone = "91234567",
                            Username = "janedoe"
                        });
                });

            modelBuilder.Entity("OnlineMovieTicketBookingApp.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Customer_Id")
                        .HasColumnType("int");

                    b.Property<int>("Movie_Id")
                        .HasColumnType("int");

                    b.Property<int>("Show_Id")
                        .HasColumnType("int");

                    b.Property<float>("Total_Price")
                        .HasColumnType("real");

                    b.Property<int>("Total_Tickets")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Customer_Id");

                    b.HasIndex("Movie_Id");

                    b.HasIndex("Show_Id");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("OnlineMovieTicketBookingApp.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_Of_Birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Password")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("OnlineMovieTicketBookingApp.Models.Hall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Total_Seats")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Halls");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Total_Seats = 40
                        },
                        new
                        {
                            Id = 2,
                            Total_Seats = 40
                        },
                        new
                        {
                            Id = 3,
                            Total_Seats = 40
                        },
                        new
                        {
                            Id = 4,
                            Total_Seats = 40
                        },
                        new
                        {
                            Id = 5,
                            Total_Seats = 40
                        });
                });

            modelBuilder.Entity("OnlineMovieTicketBookingApp.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age_Rating")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BgImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cast")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Distributor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Release_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Run_Time")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Synopsis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Ticket_Price")
                        .HasColumnType("real");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trailer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age_Rating = "PG",
                            BgImage = "/MovieBackgrounds/Cruella.jpg",
                            Cast = "Emma Stone, Emma Thompson , Joel Fry, Paul Walter Hauser, Emily Beecham, Mark Strong, Kirby Howell-Baptiste",
                            Director = "Craig Gillespie",
                            Distributor = "Walt Disney Pictures",
                            Genre = "Comedy",
                            Language = "English",
                            Poster = "/MoviePosters/CruellaPoster.jpg",
                            Release_Date = new DateTime(2021, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Run_Time = 134,
                            Status = "Now Showing",
                            Synopsis = "A live action prequel feature film that tells the story of a young Cruella de Vil, the villain from 101 Dalmations. Cruella, which is set in 1970s London amidst the punk rock revolution, follows a young grifter named Estella (Emma Stone), a clever and creative girl determined to make a name for herself with her designs. She befriends a pair of young thieves who appreciate her appetite for mischief, and together they are able to build a life for themselves on the London streets. With their help and her creativity and wit, Estella catches the eye of fashion legend Baroness von Hellman (Emma Thompson) through her fiery flair. But their relationship sets in motion a course of events and revelations that will cause Estella to embrace her wicked side and become the raucous, fashionable and revenge-bent Cruella.",
                            Ticket_Price = 9f,
                            Title = "Disney's Cruella",
                            Trailer = "/MovieTrailers/DisneysCruella.mp4"
                        },
                        new
                        {
                            Id = 2,
                            Age_Rating = "NC16 - Horror",
                            BgImage = "/MovieBackgrounds/TheConjuring3.jpg",
                            Cast = "Patrick Wilson, Vera Farmiga, Ruairi O'Connor, Sarah Catherine Hook, Julian Hilliard",
                            Director = "Michael Chaves",
                            Distributor = "Warner Bros.",
                            Genre = "Horror",
                            Language = "English",
                            Poster = "/MoviePosters/ConjuringPoster.jpg",
                            Release_Date = new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Run_Time = 112,
                            Status = "Now Showing",
                            Synopsis = "The Conjuring: The Devil Made Me Do It reveals a chilling story of terror, murder and unknown evil that shocked even experienced real-life paranormal investigators Ed and Lorraine Warren. One of the most sensational cases from their files, it starts with a fight for the soul of a young boy, then takes them beyond anything they’d ever seen before, to mark the first time in U.S. history that a murder suspect would claim demonic possession as a defense.",
                            Ticket_Price = 9f,
                            Title = "The Conjuring: The Devil Made Me Do It",
                            Trailer = "/MovieTrailers/TheConjuring3.mp4"
                        },
                        new
                        {
                            Id = 3,
                            Age_Rating = "M18 - Coarse Language & Violence",
                            BgImage = "/MovieBackgrounds/HitmanWifeBodyguard.jpg",
                            Cast = "Ryan Reynolds, Samuel L Jackson, Salma Hayek, Antonio Banderas, Morgan Freeman",
                            Director = "Patrick Hughesz",
                            Distributor = "Golden Village Pictures",
                            Genre = "Action",
                            Language = "English",
                            Poster = "/MoviePosters/HitmansWifesBodyguardPoster.jpg",
                            Release_Date = new DateTime(2021, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Run_Time = 100,
                            Status = "Now Showing",
                            Synopsis = "The world’s most lethal odd couple – bodyguard Michael Bryce (Ryan Reynolds) and hitman Darius Kincaid (Samuel L. Jackson) – are back on another life-threatening mission. Still unlicensed and under scrutiny, Bryce is forced into action by Darius’s even more volatile wife, the infamous international con artist Sonia Kincaid (Salma Hayek). As Bryce is driven over the edge by his two most dangerous protectees, the trio get in over their heads in a global plot and soon find that they are all that stand between Europe and total chaos. Joining in the fun and deadly mayhem are Antonio Banderas as a vengeful and powerful madman and Morgan Freeman as… well, you’ll have to see.",
                            Ticket_Price = 9f,
                            Title = "Hitman's Wife's Bodyguard",
                            Trailer = "/MovieTrailers/HitmansWifesBodyguard.mp4"
                        },
                        new
                        {
                            Id = 4,
                            Age_Rating = "PG13 - Some Violence",
                            BgImage = "/MovieBackgrounds/FastFurious9.jpg",
                            Cast = "Vin Diesel, Charlize Theron, Michelle Rodriguez, John Cena, Tyrese Gibson",
                            Director = "Justin Lin",
                            Distributor = "United International Pictures",
                            Genre = "Action",
                            Language = "English",
                            Poster = "/MoviePosters/Fast&Furious9Poster.jpg",
                            Release_Date = new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Run_Time = 143,
                            Status = "Now Showing",
                            Synopsis = "Vin Diesel’s Dom Toretto is leading a quiet life off the grid with Letty and his son, little Brian, but they know that danger always lurks just over their peaceful horizon. This time, that threat will force Dom to confront the sins of his past if he’s going to save those he loves most. His crew joins together to stop a world-shattering plot led by the most skilled assassin and high-performance driver they’ve ever encountered: a man who also happens to be Dom’s forsaken brother, Jakob (John Cena).",
                            Ticket_Price = 9f,
                            Title = "Fast & Furious 9: The Fast Saga",
                            Trailer = "/MovieTrailers/FastFurious9.mp4"
                        },
                        new
                        {
                            Id = 5,
                            Age_Rating = "PG13 - Some Violence",
                            BgImage = "/MovieBackgrounds/BlackWidow.jpg",
                            Cast = "Scarlett Johansson, Florence Pugh, David Harbour, Rachel Weisz",
                            Director = "Cate Shortland",
                            Distributor = "Walt Disney Pictures",
                            Genre = "Action",
                            Language = "English",
                            Poster = "/MoviePosters/BlackWidowPoster.jpg",
                            Release_Date = new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Run_Time = 134,
                            Status = "Coming Soon",
                            Synopsis = "Scarlett Johansson reprises her role as Natasha/Black Widow in Marvel Studios' action-packed spy thriller Black Widow- the first film in Phase Four of the Marvel Cinematic Universe. Florence Pugh stars as Yelena, David Harbour as Alexei aka The Red Guardian and Rachel Weisz as Melina. Directed by Cate Shortland and produced by Kevin Feige.",
                            Ticket_Price = 9f,
                            Title = "Marvel Studios' Black Widow",
                            Trailer = "/MovieTrailers/BlackWidow.mp4"
                        },
                        new
                        {
                            Id = 6,
                            Age_Rating = "TBA",
                            BgImage = "/MovieBackgrounds/JungleCruise2.jpg",
                            Cast = "Emily Blunt, Dwayne Johnson, Paul Giamatti, Jesse Plemons , Andy Nyman",
                            Director = "Jaume Collet-Serra",
                            Distributor = "Walt Disney Pictures",
                            Genre = "Adventure",
                            Language = "English",
                            Poster = "/MoviePosters/JungleCruisePoster.jpg",
                            Release_Date = new DateTime(2021, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Run_Time = 127,
                            Status = "Coming Soon",
                            Synopsis = "Based on Disneyland's popular theme park ride in which a small riverboat, equipped with a hilarious tour guide, takes a group of travelers through a jungle filled with dangerous animals and reptiles.",
                            Ticket_Price = 9f,
                            Title = "Disney's Jungle Cruise",
                            Trailer = "/MovieTrailers/JungleCruise.mp4"
                        },
                        new
                        {
                            Id = 7,
                            Age_Rating = "TBA",
                            BgImage = "/MovieBackgrounds/TheSuicideSquad.jpg",
                            Cast = "Sylvester Stallone, Idris Elba, Margot Robbie, John Cena, Viola Davis, Joel Kinnaman, Jai Courtney, Peter Capaldi",
                            Director = "James Gunn",
                            Distributor = "Warner Bros.",
                            Genre = "Action",
                            Language = "English",
                            Poster = "/MoviePosters/TheSuicideSquadPoster.jpg",
                            Release_Date = new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Run_Time = 120,
                            Status = "Coming Soon",
                            Synopsis = "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve prison join the super-secret, super-shady Task Force X as they are dropped off at the remote, enemy-infused island of Corto Maltese.",
                            Ticket_Price = 9f,
                            Title = "The Suicide Squad",
                            Trailer = "/MovieTrailers/TheSuicideSquad.mp4"
                        });
                });

            modelBuilder.Entity("OnlineMovieTicketBookingApp.Models.Show", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date_And_Time")
                        .HasColumnType("datetime2");

                    b.Property<int>("Hall_Id")
                        .HasColumnType("int");

                    b.Property<int>("Movie_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Hall_Id");

                    b.HasIndex("Movie_Id");

                    b.ToTable("Shows");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date_And_Time = new DateTime(2021, 6, 30, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 1,
                            Movie_Id = 1
                        },
                        new
                        {
                            Id = 2,
                            Date_And_Time = new DateTime(2021, 6, 30, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 1,
                            Movie_Id = 1
                        },
                        new
                        {
                            Id = 3,
                            Date_And_Time = new DateTime(2021, 6, 30, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 1,
                            Movie_Id = 1
                        },
                        new
                        {
                            Id = 4,
                            Date_And_Time = new DateTime(2021, 6, 30, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 1,
                            Movie_Id = 1
                        },
                        new
                        {
                            Id = 5,
                            Date_And_Time = new DateTime(2021, 6, 30, 20, 30, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 1,
                            Movie_Id = 1
                        },
                        new
                        {
                            Id = 6,
                            Date_And_Time = new DateTime(2021, 6, 30, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 2,
                            Movie_Id = 2
                        },
                        new
                        {
                            Id = 7,
                            Date_And_Time = new DateTime(2021, 6, 30, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 2,
                            Movie_Id = 2
                        },
                        new
                        {
                            Id = 8,
                            Date_And_Time = new DateTime(2021, 6, 30, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 2,
                            Movie_Id = 2
                        },
                        new
                        {
                            Id = 9,
                            Date_And_Time = new DateTime(2021, 6, 30, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 2,
                            Movie_Id = 2
                        },
                        new
                        {
                            Id = 10,
                            Date_And_Time = new DateTime(2021, 6, 30, 20, 30, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 2,
                            Movie_Id = 2
                        },
                        new
                        {
                            Id = 11,
                            Date_And_Time = new DateTime(2021, 6, 30, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 3,
                            Movie_Id = 3
                        },
                        new
                        {
                            Id = 20,
                            Date_And_Time = new DateTime(2021, 7, 7, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 5,
                            Movie_Id = 1
                        },
                        new
                        {
                            Id = 21,
                            Date_And_Time = new DateTime(2021, 7, 7, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 5,
                            Movie_Id = 1
                        },
                        new
                        {
                            Id = 22,
                            Date_And_Time = new DateTime(2021, 7, 7, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 5,
                            Movie_Id = 1
                        },
                        new
                        {
                            Id = 23,
                            Date_And_Time = new DateTime(2021, 7, 7, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 5,
                            Movie_Id = 1
                        },
                        new
                        {
                            Id = 24,
                            Date_And_Time = new DateTime(2021, 7, 7, 20, 30, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 5,
                            Movie_Id = 1
                        },
                        new
                        {
                            Id = 25,
                            Date_And_Time = new DateTime(2021, 7, 7, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 3,
                            Movie_Id = 2
                        },
                        new
                        {
                            Id = 26,
                            Date_And_Time = new DateTime(2021, 7, 7, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 3,
                            Movie_Id = 2
                        },
                        new
                        {
                            Id = 27,
                            Date_And_Time = new DateTime(2021, 7, 7, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 3,
                            Movie_Id = 2
                        },
                        new
                        {
                            Id = 28,
                            Date_And_Time = new DateTime(2021, 7, 7, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 3,
                            Movie_Id = 2
                        },
                        new
                        {
                            Id = 29,
                            Date_And_Time = new DateTime(2021, 7, 7, 20, 30, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 3,
                            Movie_Id = 2
                        },
                        new
                        {
                            Id = 30,
                            Date_And_Time = new DateTime(2021, 7, 7, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 1,
                            Movie_Id = 3
                        },
                        new
                        {
                            Id = 31,
                            Date_And_Time = new DateTime(2021, 7, 7, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 1,
                            Movie_Id = 3
                        },
                        new
                        {
                            Id = 32,
                            Date_And_Time = new DateTime(2021, 7, 7, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 1,
                            Movie_Id = 3
                        },
                        new
                        {
                            Id = 33,
                            Date_And_Time = new DateTime(2021, 7, 7, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 1,
                            Movie_Id = 3
                        },
                        new
                        {
                            Id = 34,
                            Date_And_Time = new DateTime(2021, 7, 7, 20, 30, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 1,
                            Movie_Id = 3
                        },
                        new
                        {
                            Id = 35,
                            Date_And_Time = new DateTime(2021, 7, 7, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 2,
                            Movie_Id = 4
                        },
                        new
                        {
                            Id = 36,
                            Date_And_Time = new DateTime(2021, 7, 7, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 2,
                            Movie_Id = 4
                        },
                        new
                        {
                            Id = 37,
                            Date_And_Time = new DateTime(2021, 7, 7, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 2,
                            Movie_Id = 4
                        },
                        new
                        {
                            Id = 38,
                            Date_And_Time = new DateTime(2021, 7, 7, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 2,
                            Movie_Id = 4
                        },
                        new
                        {
                            Id = 39,
                            Date_And_Time = new DateTime(2021, 7, 7, 20, 30, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 2,
                            Movie_Id = 4
                        },
                        new
                        {
                            Id = 40,
                            Date_And_Time = new DateTime(2021, 7, 7, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 4,
                            Movie_Id = 5
                        },
                        new
                        {
                            Id = 41,
                            Date_And_Time = new DateTime(2021, 7, 7, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 4,
                            Movie_Id = 5
                        },
                        new
                        {
                            Id = 42,
                            Date_And_Time = new DateTime(2021, 7, 7, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 4,
                            Movie_Id = 5
                        },
                        new
                        {
                            Id = 43,
                            Date_And_Time = new DateTime(2021, 7, 7, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 4,
                            Movie_Id = 5
                        },
                        new
                        {
                            Id = 44,
                            Date_And_Time = new DateTime(2021, 7, 7, 20, 30, 0, 0, DateTimeKind.Unspecified),
                            Hall_Id = 4,
                            Movie_Id = 5
                        });
                });

            modelBuilder.Entity("OnlineMovieTicketBookingApp.Models.Ticket", b =>
                {
                    b.Property<int>("ticket_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("customer_id")
                        .HasColumnType("int");

                    b.Property<int>("hall_id")
                        .HasColumnType("int");

                    b.Property<int>("hall_number")
                        .HasColumnType("int");

                    b.Property<int>("seat_id")
                        .HasColumnType("int");

                    b.Property<int>("seat_number")
                        .HasColumnType("int");

                    b.Property<DateTime>("show_datetime")
                        .HasColumnType("datetime2");

                    b.Property<int>("show_id")
                        .HasColumnType("int");

                    b.Property<double>("ticket_price")
                        .HasColumnType("float");

                    b.HasKey("ticket_id");

                    b.HasIndex("customer_id");

                    b.HasIndex("show_id");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("OnlineMovieTicketBookingApp.Models.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("OnlineMovieTicketBookingApp.Models.Booking", b =>
                {
                    b.HasOne("OnlineMovieTicketBookingApp.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("Customer_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineMovieTicketBookingApp.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("Movie_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineMovieTicketBookingApp.Models.Show", "Show")
                        .WithMany()
                        .HasForeignKey("Show_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Movie");

                    b.Navigation("Show");
                });

            modelBuilder.Entity("OnlineMovieTicketBookingApp.Models.Show", b =>
                {
                    b.HasOne("OnlineMovieTicketBookingApp.Models.Hall", "Hall")
                        .WithMany()
                        .HasForeignKey("Hall_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineMovieTicketBookingApp.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("Movie_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hall");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("OnlineMovieTicketBookingApp.Models.Ticket", b =>
                {
                    b.HasOne("OnlineMovieTicketBookingApp.Models.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("customer_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineMovieTicketBookingApp.Models.Show", "show")
                        .WithMany()
                        .HasForeignKey("show_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");

                    b.Navigation("show");
                });
#pragma warning restore 612, 618
        }
    }
}
