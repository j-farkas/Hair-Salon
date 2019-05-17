﻿// <auto-generated />
using HairSalon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace hair_salon.Migrations
{
    [DbContext(typeof(SalonContext))]
    partial class SalonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("HairSalon.Models.Client", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("hair");

                    b.Property<string>("haircut");

                    b.Property<string>("name");

                    b.Property<int>("stylist");

                    b.HasKey("id");

                    b.ToTable("client");
                });

            modelBuilder.Entity("HairSalon.Models.Join", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("client_id");

                    b.Property<int>("prefix_id");

                    b.Property<int>("scissors_id");

                    b.Property<int>("specialty_id");

                    b.Property<int>("stylist_id");

                    b.Property<int>("suffix_id");

                    b.HasKey("id");

                    b.ToTable("join");
                });

            modelBuilder.Entity("HairSalon.Models.Prefix", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("max_value");

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.ToTable("prefix");
                });

            modelBuilder.Entity("HairSalon.Models.Scissors", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name");

                    b.Property<int>("prefix_1");

                    b.Property<int>("prefix_1_value");

                    b.Property<int>("prefix_2");

                    b.Property<int>("prefix_2_value");

                    b.Property<int>("quality");

                    b.Property<int>("suffix_1");

                    b.Property<int>("suffix_1_value");

                    b.Property<int>("suffix_2");

                    b.Property<int>("suffix_2_value");

                    b.HasKey("id");

                    b.ToTable("scissors");
                });

            modelBuilder.Entity("HairSalon.Models.Specialty", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.ToTable("specialty");
                });

            modelBuilder.Entity("HairSalon.Models.Stylist", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("description");

                    b.Property<int>("drop");

                    b.Property<int>("hair");

                    b.Property<int>("level");

                    b.Property<string>("name");

                    b.Property<int>("scissors");

                    b.HasKey("id");

                    b.ToTable("stylist");
                });

            modelBuilder.Entity("HairSalon.Models.Suffix", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("max_value");

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.ToTable("suffix");
                });
#pragma warning restore 612, 618
        }
    }
}
