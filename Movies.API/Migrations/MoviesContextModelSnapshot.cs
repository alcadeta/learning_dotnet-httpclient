﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movies.API.Contexts;

namespace Movies.API.Migrations
{
    [DbContext(typeof(MoviesContext))]
    partial class MoviesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Movies.API.Entities.Director", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Directors");

                    b.HasData(
                        new { Id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), FirstName = "Quentin", LastName = "Tarantino" },
                        new { Id = new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), FirstName = "Joel", LastName = "Coen" },
                        new { Id = new Guid("c19099ed-94db-44ba-885b-0ad7205d5e40"), FirstName = "Martin", LastName = "Scorsese" },
                        new { Id = new Guid("0c4dc798-b38b-4a1c-905c-a9e76dbef17b"), FirstName = "David", LastName = "Fincher" },
                        new { Id = new Guid("937b1ba1-7969-4324-9ab5-afb0e4d875e6"), FirstName = "Bryan", LastName = "Singer" },
                        new { Id = new Guid("7a2fbc72-bb33-49de-bd23-c78fceb367fc"), FirstName = "James", LastName = "Cameron" }
                    );
                });

            modelBuilder.Entity("Movies.API.Entities.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(2000);

                    b.Property<Guid>("DirectorId");

                    b.Property<string>("Genre")
                        .HasMaxLength(200);

                    b.Property<DateTimeOffset>("ReleaseDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("DirectorId");

                    b.ToTable("Movies");

                    b.HasData(
                        new { Id = new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"), Description = "The lives of two mob hitmen, a boxer, a gangster's wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", DirectorId = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), Genre = "Crime, Drama", ReleaseDate = new DateTimeOffset(new DateTime(1994, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), Title = "Pulp Fiction" },
                        new { Id = new Guid("6e87f657-f2c1-4d90-9b37-cbe43cc6adb9"), Description = "A middle-aged woman finds herself in the middle of a huge conflict that will either make her a profit or cost her life.", DirectorId = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), Genre = "Crime, Drama", ReleaseDate = new DateTimeOffset(new DateTime(1997, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), Title = "Jackie Brown" },
                        new { Id = new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), Description = "The Dude (Lebowski), mistaken for a millionaire Lebowski, seeks restitution for his ruined rug and enlists his bowling buddies to help get it.", DirectorId = new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), Genre = "Comedy, Crime", ReleaseDate = new DateTimeOffset(new DateTime(1998, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), Title = "The Big Lebowski" },
                        new { Id = new Guid("f9a16fee-4c49-41bb-87a1-bbaad0cd1174"), Description = "A tale of greed, deception, money, power, and murder occur between two best friends: a mafia enforcer and a casino executive, compete against each other over a gambling empire, and over a fast living and fast loving socialite.", DirectorId = new Guid("c19099ed-94db-44ba-885b-0ad7205d5e40"), Genre = "Crime, Drama", ReleaseDate = new DateTimeOffset(new DateTime(1995, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), Title = "Casino" },
                        new { Id = new Guid("bb6a100a-053f-4bf8-b271-60ce3aae6eb5"), Description = "An insomniac office worker and a devil-may-care soapmaker form an underground fight club that evolves into something much, much more.", DirectorId = new Guid("0c4dc798-b38b-4a1c-905c-a9e76dbef17b"), Genre = "Drama", ReleaseDate = new DateTimeOffset(new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), Title = "Fight Club" },
                        new { Id = new Guid("3d2880ae-5ba6-417c-845d-f4ebfd4bcac7"), Description = "A sole survivor tells of the twisty events leading up to a horrific gun battle on a boat, which began when five criminals met at a seemingly random police lineup.", DirectorId = new Guid("937b1ba1-7969-4324-9ab5-afb0e4d875e6"), Genre = "Crime, Thriller", ReleaseDate = new DateTimeOffset(new DateTime(1995, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), Title = "The Usual Suspects" },
                        new { Id = new Guid("26fcbcc4-b7f7-47fc-9382-740c12246b59"), Description = "A cyborg, identical to the one who failed to kill Sarah Connor, must now protect her teenage son, John Connor, from a more advanced and powerful cyborg.", DirectorId = new Guid("7a2fbc72-bb33-49de-bd23-c78fceb367fc"), Genre = "Action, Sci-Fi", ReleaseDate = new DateTimeOffset(new DateTime(1991, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), Title = "Terminator 2: Judgment Day" }
                    );
                });

            modelBuilder.Entity("Movies.API.Entities.Movie", b =>
                {
                    b.HasOne("Movies.API.Entities.Director", "Director")
                        .WithMany()
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
