﻿// <auto-generated />
using Gos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Gos.Migrations
{
    [DbContext(typeof(SpoProjectContext))]
    partial class SpoProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Commvet", b =>
                {
                    b.Property<int>("Idcomm")
                        .HasColumnType("integer")
                        .HasColumnName("idcomm");

                    b.Property<int>("Idvet")
                        .HasColumnType("integer")
                        .HasColumnName("idvet");

                    b.HasKey("Idcomm", "Idvet")
                        .HasName("commvet_pk");

                    b.HasIndex("Idvet");

                    b.ToTable("commvet", (string)null);
                });

            modelBuilder.Entity("Gos.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer")
                        .HasColumnName("age");

                    b.Property<string>("Nameanimal")
                        .IsRequired()
                        .HasColumnType("character varying")
                        .HasColumnName("nameanimal");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("animal_pk");

                    b.HasIndex("UserId");

                    b.ToTable("animal", (string)null);
                });

            modelBuilder.Entity("Gos.Models.Animalsinheltetr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<int>("Idshelters")
                        .HasColumnType("integer")
                        .HasColumnName("idshelters");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying");

                    b.HasKey("Id")
                        .HasName("animalsheltetr_pk");

                    b.HasIndex("Idshelters");

                    b.ToTable("animalsinheltetrs", (string)null);
                });

            modelBuilder.Entity("Gos.Models.CommOvereyeing", b =>
                {
                    b.Property<int>("Overeyeing")
                        .HasColumnType("integer")
                        .HasColumnName("overeyeing");

                    b.Property<int>("ReweisOver")
                        .HasColumnType("integer")
                        .HasColumnName("reweis_over");

                    b.HasIndex("ReweisOver");

                    b.HasIndex(new[] { "Overeyeing", "ReweisOver" }, "comm_overeyeing_unique")
                        .IsUnique();

                    b.ToTable("comm_overeyeing", (string)null);
                });

            modelBuilder.Entity("Gos.Models.Missinganimal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<int>("Animalid")
                        .HasColumnType("integer")
                        .HasColumnName("animalid");

                    b.Property<int>("Userid")
                        .HasColumnType("integer")
                        .HasColumnName("userid");

                    b.HasKey("Id")
                        .HasName("missinganimal_pk");

                    b.HasIndex("Userid");

                    b.ToTable("missinganimal", (string)null);
                });

            modelBuilder.Entity("Gos.Models.Overeyingofpet", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("character varying")
                        .HasColumnName("adress");

                    b.HasKey("Id")
                        .HasName("peremoga_pk");

                    b.ToTable("Overeyingofpets");
                });

            modelBuilder.Entity("Gos.Models.Passport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<int>("Animalid")
                        .HasColumnType("integer")
                        .HasColumnName("animalid");

                    b.Property<int>("Number")
                        .HasColumnType("integer")
                        .HasColumnName("number");

                    b.Property<int>("Serea")
                        .HasColumnType("integer")
                        .HasColumnName("serea");

                    b.HasKey("Id")
                        .HasName("passport_pk");

                    b.ToTable("passport", (string)null);
                });

            modelBuilder.Entity("Gos.Models.Recod", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<int>("Animalid")
                        .HasColumnType("integer")
                        .HasColumnName("animalid");

                    b.Property<int>("Userid")
                        .HasColumnType("integer")
                        .HasColumnName("userid");

                    b.Property<int>("Vetclinid")
                        .HasColumnType("integer")
                        .HasColumnName("vetclinid");

                    b.HasKey("Id")
                        .HasName("recod_pk");

                    b.HasIndex("Animalid");

                    b.HasIndex("Userid");

                    b.HasIndex("Vetclinid");

                    b.ToTable("recod", (string)null);
                });

            modelBuilder.Entity("Gos.Models.Rewei", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<string>("Comm")
                        .IsRequired()
                        .HasColumnType("character varying")
                        .HasColumnName("comm");

                    b.Property<int>("IdUser")
                        .HasColumnType("integer")
                        .HasColumnName("id_user");

                    b.HasKey("Id")
                        .HasName("reweis_pk");

                    b.HasIndex("IdUser");

                    b.ToTable("reweis", (string)null);
                });

            modelBuilder.Entity("Gos.Models.Shelter", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("character varying")
                        .HasColumnName("adress");

                    b.HasKey("Id")
                        .HasName("shelter_pk");

                    b.ToTable("shelter", (string)null);
                });

            modelBuilder.Entity("Gos.Models.TakeOvereyingofpet", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<int>("Animalid")
                        .HasColumnType("integer")
                        .HasColumnName("animalid");

                    b.Property<int>("Peremoga")
                        .HasColumnType("integer")
                        .HasColumnName("peremoga");

                    b.Property<int>("Userid")
                        .HasColumnType("integer")
                        .HasColumnName("userid");

                    b.HasKey("Id")
                        .HasName("newtable_pk");

                    b.HasIndex("Animalid");

                    b.HasIndex("Peremoga");

                    b.HasIndex("Userid");

                    b.ToTable("takeOvereyingofpets", (string)null);
                });

            modelBuilder.Entity("Gos.Models.Takeanimal", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<int>("Aniimalsinsheltrsid")
                        .HasColumnType("integer")
                        .HasColumnName("aniimalsinsheltrsid");

                    b.Property<int>("Iduser")
                        .HasColumnType("integer")
                        .HasColumnName("iduser");

                    b.Property<int>("Shelerid")
                        .HasColumnType("integer")
                        .HasColumnName("shelerid");

                    b.HasKey("Id")
                        .HasName("takeanimal_pk");

                    b.HasIndex("Aniimalsinsheltrsid");

                    b.HasIndex("Iduser");

                    b.HasIndex("Shelerid");

                    b.ToTable("takeanimal", (string)null);
                });

            modelBuilder.Entity("Gos.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying")
                        .HasColumnName("firstname");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying")
                        .HasColumnName("phone");

                    b.Property<string>("Secondname")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying")
                        .HasColumnName("secondname");

                    b.Property<string>("Therdname")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying")
                        .HasColumnName("therdname");

                    b.HasKey("Id")
                        .HasName("user_pk");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("Gos.Models.Vaccine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<int>("Pssoprtid")
                        .HasColumnType("integer")
                        .HasColumnName("pssoprtid");

                    b.HasKey("Id")
                        .HasName("vacin_pk");

                    b.HasIndex("Pssoprtid");

                    b.ToTable("vaccine", (string)null);
                });

            modelBuilder.Entity("Gos.Models.Vetclinic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("character varying")
                        .HasColumnName("adress");

                    b.HasKey("Id")
                        .HasName("vetclinic_pk");

                    b.ToTable("vetclinic", (string)null);
                });

            modelBuilder.Entity("Commvet", b =>
                {
                    b.HasOne("Gos.Models.Rewei", null)
                        .WithMany()
                        .HasForeignKey("Idcomm")
                        .IsRequired()
                        .HasConstraintName("commvet_reweis_fk");

                    b.HasOne("Gos.Models.Vetclinic", null)
                        .WithMany()
                        .HasForeignKey("Idvet")
                        .IsRequired()
                        .HasConstraintName("commvet_vetclinic_fk");
                });

            modelBuilder.Entity("Gos.Models.Animal", b =>
                {
                    b.HasOne("Gos.Models.User", "User")
                        .WithMany("Animals")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("animal_user_fk");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Gos.Models.Animalsinheltetr", b =>
                {
                    b.HasOne("Gos.Models.Shelter", "IdsheltersNavigation")
                        .WithMany("Animalsinheltetrs")
                        .HasForeignKey("Idshelters")
                        .IsRequired()
                        .HasConstraintName("animalsinheltetrs_shelter_fk");

                    b.Navigation("IdsheltersNavigation");
                });

            modelBuilder.Entity("Gos.Models.CommOvereyeing", b =>
                {
                    b.HasOne("Gos.Models.Overeyingofpet", "OvereyeingNavigation")
                        .WithMany()
                        .HasForeignKey("Overeyeing")
                        .IsRequired()
                        .HasConstraintName("comm_overeyeing_overeyingofpets_fk");

                    b.HasOne("Gos.Models.Rewei", "ReweisOverNavigation")
                        .WithMany()
                        .HasForeignKey("ReweisOver")
                        .IsRequired()
                        .HasConstraintName("comm_overeyeing_reweis_fk");

                    b.Navigation("OvereyeingNavigation");

                    b.Navigation("ReweisOverNavigation");
                });

            modelBuilder.Entity("Gos.Models.Missinganimal", b =>
                {
                    b.HasOne("Gos.Models.User", "User")
                        .WithMany("Missinganimals")
                        .HasForeignKey("Userid")
                        .IsRequired()
                        .HasConstraintName("missinganimal_user_fk");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Gos.Models.Passport", b =>
                {
                    b.HasOne("Gos.Models.Animal", "IdNavigation")
                        .WithOne("Passport")
                        .HasForeignKey("Gos.Models.Passport", "Id")
                        .IsRequired()
                        .HasConstraintName("passport_animal_fk");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("Gos.Models.Recod", b =>
                {
                    b.HasOne("Gos.Models.Animal", "Animal")
                        .WithMany("Recods")
                        .HasForeignKey("Animalid")
                        .IsRequired()
                        .HasConstraintName("recod_animal_fk");

                    b.HasOne("Gos.Models.User", "User")
                        .WithMany("Recods")
                        .HasForeignKey("Userid")
                        .IsRequired()
                        .HasConstraintName("recod_user_fk");

                    b.HasOne("Gos.Models.Vetclinic", "Vetclin")
                        .WithMany("Recods")
                        .HasForeignKey("Vetclinid")
                        .IsRequired()
                        .HasConstraintName("recod_vetclinic_fk");

                    b.Navigation("Animal");

                    b.Navigation("User");

                    b.Navigation("Vetclin");
                });

            modelBuilder.Entity("Gos.Models.Rewei", b =>
                {
                    b.HasOne("Gos.Models.User", "IdUserNavigation")
                        .WithMany("Reweis")
                        .HasForeignKey("IdUser")
                        .IsRequired()
                        .HasConstraintName("reweis_user_fk");

                    b.Navigation("IdUserNavigation");
                });

            modelBuilder.Entity("Gos.Models.TakeOvereyingofpet", b =>
                {
                    b.HasOne("Gos.Models.Animal", "Animal")
                        .WithMany("TakeOvereyingofpets")
                        .HasForeignKey("Animalid")
                        .IsRequired()
                        .HasConstraintName("takeperemoga_animal_fk");

                    b.HasOne("Gos.Models.Overeyingofpet", "PeremogaNavigation")
                        .WithMany("TakeOvereyingofpets")
                        .HasForeignKey("Peremoga")
                        .IsRequired()
                        .HasConstraintName("takeperemoga_peremoga_fk");

                    b.HasOne("Gos.Models.User", "User")
                        .WithMany("TakeOvereyingofpets")
                        .HasForeignKey("Userid")
                        .IsRequired()
                        .HasConstraintName("takeperemoga_user_fk");

                    b.Navigation("Animal");

                    b.Navigation("PeremogaNavigation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Gos.Models.Takeanimal", b =>
                {
                    b.HasOne("Gos.Models.Animalsinheltetr", "Aniimalsinsheltrs")
                        .WithMany("Takeanimals")
                        .HasForeignKey("Aniimalsinsheltrsid")
                        .IsRequired()
                        .HasConstraintName("takeanimal_animalsinheltetrs_fk");

                    b.HasOne("Gos.Models.User", "IduserNavigation")
                        .WithMany("Takeanimals")
                        .HasForeignKey("Iduser")
                        .IsRequired()
                        .HasConstraintName("takeanimal_user_fk");

                    b.HasOne("Gos.Models.Shelter", "Sheler")
                        .WithMany("Takeanimals")
                        .HasForeignKey("Shelerid")
                        .IsRequired()
                        .HasConstraintName("takeanimal_shelter_fk");

                    b.Navigation("Aniimalsinsheltrs");

                    b.Navigation("IduserNavigation");

                    b.Navigation("Sheler");
                });

            modelBuilder.Entity("Gos.Models.Vaccine", b =>
                {
                    b.HasOne("Gos.Models.Passport", "Pssoprt")
                        .WithMany("Vaccines")
                        .HasForeignKey("Pssoprtid")
                        .IsRequired()
                        .HasConstraintName("vacin_passport_fk");

                    b.Navigation("Pssoprt");
                });

            modelBuilder.Entity("Gos.Models.Animal", b =>
                {
                    b.Navigation("Passport");

                    b.Navigation("Recods");

                    b.Navigation("TakeOvereyingofpets");
                });

            modelBuilder.Entity("Gos.Models.Animalsinheltetr", b =>
                {
                    b.Navigation("Takeanimals");
                });

            modelBuilder.Entity("Gos.Models.Overeyingofpet", b =>
                {
                    b.Navigation("TakeOvereyingofpets");
                });

            modelBuilder.Entity("Gos.Models.Passport", b =>
                {
                    b.Navigation("Vaccines");
                });

            modelBuilder.Entity("Gos.Models.Shelter", b =>
                {
                    b.Navigation("Animalsinheltetrs");

                    b.Navigation("Takeanimals");
                });

            modelBuilder.Entity("Gos.Models.User", b =>
                {
                    b.Navigation("Animals");

                    b.Navigation("Missinganimals");

                    b.Navigation("Recods");

                    b.Navigation("Reweis");

                    b.Navigation("TakeOvereyingofpets");

                    b.Navigation("Takeanimals");
                });

            modelBuilder.Entity("Gos.Models.Vetclinic", b =>
                {
                    b.Navigation("Recods");
                });
#pragma warning restore 612, 618
        }
    }
}
