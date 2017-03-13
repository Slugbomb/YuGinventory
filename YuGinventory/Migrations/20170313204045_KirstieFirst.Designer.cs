using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using YuGinventory.Models;

namespace YuGinventory.Migrations
{
    [DbContext(typeof(YuGinventoryContext))]
    [Migration("20170313204045_KirstieFirst")]
    partial class KirstieFirst
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YuGinventory.Models.Card", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DeckId");

                    b.Property<int>("ReferenceCardId");

                    b.Property<int>("UserId");

                    b.HasKey("ID");

                    b.ToTable("Card");
                });

            modelBuilder.Entity("YuGinventory.Models.Deck", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BoxColour");

                    b.Property<string>("Name");

                    b.Property<string>("SleeveColour");

                    b.Property<int>("UserId");

                    b.HasKey("ID");

                    b.ToTable("Deck");
                });

            modelBuilder.Entity("YuGinventory.Models.ReferenceCard", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Attack");

                    b.Property<int>("Defense");

                    b.Property<string>("Name");

                    b.Property<string>("SetId");

                    b.Property<string>("Text");

                    b.Property<int>("Type");

                    b.HasKey("ID");

                    b.ToTable("ReferenceCard");
                });

            modelBuilder.Entity("YuGinventory.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("User");
                });
        }
    }
}
