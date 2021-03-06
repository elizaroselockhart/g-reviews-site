// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewsSite;

namespace ReviewsSite.Migrations
{
    [DbContext(typeof(VideoGameContext))]
    partial class VideoGameContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewsSite.Models.Platform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Platforms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "PC"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Xbox"
                        },
                        new
                        {
                            Id = 3,
                            Name = "PS4"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Switch"
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Usercomment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VideoGameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VideoGameId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Rating = 4.0,
                            Usercomment = "I don't think there are many,if any, other games where you can play as a communist,schizophrenic,disco,cop.",
                            Username = "AweSome495",
                            VideoGameId = 1
                        },
                        new
                        {
                            Id = 6,
                            Rating = 4.5,
                            Usercomment = "I would die for Kim Kitsuragi",
                            Username = "Bort",
                            VideoGameId = 1
                        },
                        new
                        {
                            Id = 7,
                            Rating = 4.0,
                            Usercomment = "I don't think there are many,if any, other games where you can play as a communist, schizophrenic, disco, cop.",
                            Username = "anarky",
                            VideoGameId = 1
                        },
                        new
                        {
                            Id = 8,
                            Rating = 5.0,
                            Usercomment = "Disco Elysium is genius, one of the best games ever. Must play this if you like good writing and tabletop RPGs",
                            Username = "Denky",
                            VideoGameId = 1
                        },
                        new
                        {
                            Id = 2,
                            Rating = 4.5,
                            Usercomment = "let's just say i finished this game in every way possible & i'm about to play it again on pc",
                            Username = "SINA - VF - 02",
                            VideoGameId = 2
                        },
                        new
                        {
                            Id = 9,
                            Rating = 5.0,
                            Usercomment = "A MUST-PLAY to fans of pretty much any genre of games. Anything more I'd wouldnt even begin to describe the magnificence of the gameplay, the environment, and all of the other elements",
                            Username = "MammadYmir",
                            VideoGameId = 2
                        },
                        new
                        {
                            Id = 10,
                            Rating = 5.0,
                            Usercomment = "A mix between Skyrim & the newer Hitman games. Underrated masterpiece",
                            Username = "Vox",
                            VideoGameId = 2
                        },
                        new
                        {
                            Id = 11,
                            Rating = 5.0,
                            Usercomment = "If this game was a guy, I'll marry him.",
                            Username = "Wracky <3 Y",
                            VideoGameId = 2
                        },
                        new
                        {
                            Id = 3,
                            Rating = 3.0,
                            Usercomment = "there was no cake :((((((((((((((((((((((((((((((((((((",
                            Username = "Barack Obama",
                            VideoGameId = 3
                        },
                        new
                        {
                            Id = 12,
                            Rating = 4.0,
                            Usercomment = "very neat! very cool! enjoyed every second despite the immense stress GLaDOS caused me in those last couple levels.",
                            Username = "VIC",
                            VideoGameId = 3
                        },
                        new
                        {
                            Id = 13,
                            Rating = 1.0,
                            Usercomment = "The cake is a lieee!!!!!",
                            Username = "AshDragon",
                            VideoGameId = 3
                        },
                        new
                        {
                            Id = 14,
                            Rating = 3.5,
                            Usercomment = "Great game good puzzle solving and challenging",
                            Username = "Stellaris",
                            VideoGameId = 3
                        },
                        new
                        {
                            Id = 4,
                            Rating = 4.5,
                            Usercomment = "I wish I could erase my memory and play this game again.",
                            Username = "J. Jonah. Jameson",
                            VideoGameId = 4
                        },
                        new
                        {
                            Id = 15,
                            Rating = 4.0,
                            Usercomment = "Fantastic puzzle game with a philosophy minigame hidden within",
                            Username = "YT_KameHameNah",
                            VideoGameId = 4
                        },
                        new
                        {
                            Id = 16,
                            Rating = 4.5,
                            Usercomment = "The Talos principle is a very good puzzle game. The gameplay is okay but the story is amazing. It's both challenging and engaging",
                            Username = "Sloppy Joe",
                            VideoGameId = 4
                        },
                        new
                        {
                            Id = 17,
                            Rating = 4.0,
                            Usercomment = "will make you think long and hard the next time you fail a captcha test",
                            Username = "Jacquee Mameet",
                            VideoGameId = 4
                        },
                        new
                        {
                            Id = 18,
                            Rating = 4.0,
                            Usercomment = "Good game to play when you're having an existential crisis",
                            Username = "bug",
                            VideoGameId = 4
                        },
                        new
                        {
                            Id = 5,
                            Rating = 5.0,
                            Usercomment = "Best game to ever be created, must play, starting off almost getting ur head chopped off to then have guards distracted by a fu@!*ng dragon, then go on to become the dragon born and go on so many amazing quest and side quest into this huge open world map w DLC's of vampires its just, PERFECTION!!",
                            Username = "1Jhovany",
                            VideoGameId = 5
                        },
                        new
                        {
                            Id = 19,
                            Rating = 5.0,
                            Usercomment = "side quests and the pretty environment keep me coming back. When you use mods the game can become a completely different game, so there's always something to check out.",
                            Username = "DrMiro",
                            VideoGameId = 5
                        },
                        new
                        {
                            Id = 20,
                            Rating = 5.0,
                            Usercomment = "Ruined my life. Five stars.",
                            Username = "Rob N",
                            VideoGameId = 5
                        },
                        new
                        {
                            Id = 21,
                            Rating = 4.5,
                            Usercomment = "All these DLC's make me feel alive",
                            Username = "Pee Wee Herman",
                            VideoGameId = 5
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.VideoGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReleaseDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VideoGames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A non-traditional roleplaying game set in Revachol, a large city still recovering from a war decades prior to the game's start, with players taking the role of an amnesiac detective who has been tasked with solving a murder mystery.",
                            Name = "Disco Elysium: The Final Cut",
                            PictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/0/0d/Disco_Elysium_Poster.jpeg/220px-Disco_Elysium_Poster.jpeg",
                            ReleaseDate = "30 March 2021",
                            VideoURL = "https://www.youtube.com/embed/YV2lp6p_gXw"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A first-person immersive stealth sim set in the fictional, plague-ridden industrial city of Dunwall, Dishonored follows the story of Corvo Attano, bodyguard to the Empress of the Isles. He is framed for her murder and forced to become an assassin, seeking revenge on those who conspired against him.",
                            Name = "Dishonored",
                            PictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/6/65/Dishonored_box_art_Bethesda.jpg/220px-Dishonored_box_art_Bethesda.jpg",
                            ReleaseDate = "9 October 2012",
                            VideoURL = "https://www.youtube.com/embed/-XbQgdSlsd0"
                        },
                        new
                        {
                            Id = 3,
                            Description = "A critically acclaimed, unique first-person puzzle platformer Portal consists primarily of a series of puzzles that must be solved by teleporting the player's character and simple objects using \"the Aperture Science Handheld Portal Device\", a device that can create inter-spatial portals between two flat planes. The player-character, Chell, is challenged and taunted by an artificial intelligence named GLaDOS (Genetic Lifeform and Disk Operating System) to complete each puzzle in the Aperture Science Enrichment Center using the portal gun with the promise of receiving cake when all the puzzles are completed.",
                            Name = "Portal",
                            PictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9f/Portal_standalonebox.jpg/220px-Portal_standalonebox.jpg",
                            ReleaseDate = "10 October, 2007",
                            VideoURL = "https://www.youtube.com/embed/TluRVBhmf8w"
                        },
                        new
                        {
                            Id = 4,
                            Description = "The Talos Principle is a narrative-based puzzle game, played from a first- or third-person perspective. The player takes the role of a robot with a seemingly human consciousness as they explore a number of environments that include over 120 puzzles. These environments interlock greenery, desert, and stone ruins with futuristic technology.",
                            Name = "The Talos Principle",
                            PictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/a/ac/The_Talos_Principle.jpg/220px-The_Talos_Principle.jpg",
                            ReleaseDate = "11 December 2014",
                            VideoURL = "https://www.youtube.com/embed/iAVh4_wnOIw"
                        },
                        new
                        {
                            Id = 5,
                            Description = "This famed open-world action role-playing game takes place in the titular Skyrim province of Tamriel. The game's main story revolves around the player's character, the Dragonborn, on their quest to defeat Alduin the World-Eater, a dragon who is prophesied to destroy the world.",
                            Name = "The Elder Scrolls V: Skyrim",
                            PictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/1/15/The_Elder_Scrolls_V_Skyrim_cover.png/220px-The_Elder_Scrolls_V_Skyrim_cover.png",
                            ReleaseDate = "11 November 2011",
                            VideoURL = "https://www.youtube.com/embed/JSRtYpNRoN0"
                        });
                });

            modelBuilder.Entity("ReviewsSite.VideoGamePlatform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PlatformId")
                        .HasColumnType("int");

                    b.Property<int>("VideoGameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlatformId");

                    b.HasIndex("VideoGameId");

                    b.ToTable("VideoGamePlatforms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PlatformId = 1,
                            VideoGameId = 1
                        },
                        new
                        {
                            Id = 2,
                            PlatformId = 2,
                            VideoGameId = 2
                        },
                        new
                        {
                            Id = 3,
                            PlatformId = 4,
                            VideoGameId = 3
                        },
                        new
                        {
                            Id = 4,
                            PlatformId = 4,
                            VideoGameId = 4
                        },
                        new
                        {
                            Id = 5,
                            PlatformId = 1,
                            VideoGameId = 5
                        },
                        new
                        {
                            Id = 6,
                            PlatformId = 2,
                            VideoGameId = 1
                        },
                        new
                        {
                            Id = 7,
                            PlatformId = 3,
                            VideoGameId = 5
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.HasOne("ReviewsSite.Models.VideoGame", "VideoGame")
                        .WithMany("Reviews")
                        .HasForeignKey("VideoGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VideoGame");
                });

            modelBuilder.Entity("ReviewsSite.VideoGamePlatform", b =>
                {
                    b.HasOne("ReviewsSite.Models.Platform", "Platform")
                        .WithMany("VideoGames")
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReviewsSite.Models.VideoGame", "VideoGame")
                        .WithMany("Platforms")
                        .HasForeignKey("VideoGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Platform");

                    b.Navigation("VideoGame");
                });

            modelBuilder.Entity("ReviewsSite.Models.Platform", b =>
                {
                    b.Navigation("VideoGames");
                });

            modelBuilder.Entity("ReviewsSite.Models.VideoGame", b =>
                {
                    b.Navigation("Platforms");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
