using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Gos.Models;

public partial class SpoProjectContext : DbContext
{
    public SpoProjectContext()
    {
    }

    public SpoProjectContext(DbContextOptions<SpoProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Animal> Animals { get; set; }

    public virtual DbSet<Animalsinheltetr> Animalsinheltetrs { get; set; }

    public virtual DbSet<CommOvereyeing> CommOvereyeings { get; set; }

    public virtual DbSet<Missinganimal> Missinganimals { get; set; }

    public virtual DbSet<Overeyingofpet> Overeyingofpets { get; set; }

    public virtual DbSet<Passport> Passports { get; set; }

    public virtual DbSet<Recod> Recods { get; set; }

    public virtual DbSet<Rewei> Reweis { get; set; }

    public virtual DbSet<Shelter> Shelters { get; set; }

    public virtual DbSet<TakeOvereyingofpet> TakeOvereyingofpets { get; set; }

    public virtual DbSet<Takeanimal> Takeanimals { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Vaccine> Vaccines { get; set; }

    public virtual DbSet<Vetclinic> Vetclinics { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=SpoProject;Username=postgres;Password=Misha1029!");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Animal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("animal_pk");

            entity.ToTable("animal");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Nameanimal)
                .HasColumnType("character varying")
                .HasColumnName("nameanimal");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Animals)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("animal_user_fk");
        });

        modelBuilder.Entity<Animalsinheltetr>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("animalsheltetr_pk");

            entity.ToTable("animalsinheltetrs");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Idshelters).HasColumnName("idshelters");
            entity.Property(e => e.Name).HasColumnType("character varying");

            entity.HasOne(d => d.IdsheltersNavigation).WithMany(p => p.Animalsinheltetrs)
                .HasForeignKey(d => d.Idshelters)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("animalsinheltetrs_shelter_fk");
        });

        modelBuilder.Entity<CommOvereyeing>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("comm_overeyeing");

            entity.HasIndex(e => new { e.Overeyeing, e.ReweisOver }, "comm_overeyeing_unique").IsUnique();

            entity.Property(e => e.Overeyeing).HasColumnName("overeyeing");
            entity.Property(e => e.ReweisOver).HasColumnName("reweis_over");

            entity.HasOne(d => d.OvereyeingNavigation).WithMany()
                .HasForeignKey(d => d.Overeyeing)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("comm_overeyeing_overeyingofpets_fk");

            entity.HasOne(d => d.ReweisOverNavigation).WithMany()
                .HasForeignKey(d => d.ReweisOver)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("comm_overeyeing_reweis_fk");
        });

        modelBuilder.Entity<Missinganimal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("missinganimal_pk");

            entity.ToTable("missinganimal");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Animalid).HasColumnName("animalid");
            entity.Property(e => e.Userid).HasColumnName("userid");

            entity.HasOne(d => d.User).WithMany(p => p.Missinganimals)
                .HasForeignKey(d => d.Userid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("missinganimal_user_fk");
        });

        modelBuilder.Entity<Overeyingofpet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("peremoga_pk");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Adress)
                .HasColumnType("character varying")
                .HasColumnName("adress");
        });

        modelBuilder.Entity<Passport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("passport_pk");

            entity.ToTable("passport");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Animalid).HasColumnName("animalid");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.Serea).HasColumnName("serea");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Passport)
                .HasForeignKey<Passport>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("passport_animal_fk");
        });

        modelBuilder.Entity<Recod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("recod_pk");

            entity.ToTable("recod");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Animalid).HasColumnName("animalid");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Vetclinid).HasColumnName("vetclinid");

            entity.HasOne(d => d.Animal).WithMany(p => p.Recods)
                .HasForeignKey(d => d.Animalid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("recod_animal_fk");

            entity.HasOne(d => d.User).WithMany(p => p.Recods)
                .HasForeignKey(d => d.Userid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("recod_user_fk");

            entity.HasOne(d => d.Vetclin).WithMany(p => p.Recods)
                .HasForeignKey(d => d.Vetclinid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("recod_vetclinic_fk");
        });

        modelBuilder.Entity<Rewei>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("reweis_pk");

            entity.ToTable("reweis");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Comm)
                .HasColumnType("character varying")
                .HasColumnName("comm");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Reweis)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("reweis_user_fk");

            entity.HasMany(d => d.Idvets).WithMany(p => p.Idcomms)
                .UsingEntity<Dictionary<string, object>>(
                    "Commvet",
                    r => r.HasOne<Vetclinic>().WithMany()
                        .HasForeignKey("Idvet")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("commvet_vetclinic_fk"),
                    l => l.HasOne<Rewei>().WithMany()
                        .HasForeignKey("Idcomm")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("commvet_reweis_fk"),
                    j =>
                    {
                        j.HasKey("Idcomm", "Idvet").HasName("commvet_pk");
                        j.ToTable("commvet");
                        j.IndexerProperty<int>("Idcomm").HasColumnName("idcomm");
                        j.IndexerProperty<int>("Idvet").HasColumnName("idvet");
                    });
        });

        modelBuilder.Entity<Shelter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("shelter_pk");

            entity.ToTable("shelter");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Adress)
                .HasColumnType("character varying")
                .HasColumnName("adress");
        });

        modelBuilder.Entity<TakeOvereyingofpet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("newtable_pk");

            entity.ToTable("takeOvereyingofpets");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Animalid).HasColumnName("animalid");
            entity.Property(e => e.Peremoga).HasColumnName("peremoga");
            entity.Property(e => e.Userid).HasColumnName("userid");

            entity.HasOne(d => d.Animal).WithMany(p => p.TakeOvereyingofpets)
                .HasForeignKey(d => d.Animalid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("takeperemoga_animal_fk");

            entity.HasOne(d => d.PeremogaNavigation).WithMany(p => p.TakeOvereyingofpets)
                .HasForeignKey(d => d.Peremoga)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("takeperemoga_peremoga_fk");

            entity.HasOne(d => d.User).WithMany(p => p.TakeOvereyingofpets)
                .HasForeignKey(d => d.Userid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("takeperemoga_user_fk");
        });

        modelBuilder.Entity<Takeanimal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("takeanimal_pk");

            entity.ToTable("takeanimal");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Aniimalsinsheltrsid).HasColumnName("aniimalsinsheltrsid");
            entity.Property(e => e.Iduser).HasColumnName("iduser");
            entity.Property(e => e.Shelerid).HasColumnName("shelerid");

            entity.HasOne(d => d.Aniimalsinsheltrs).WithMany(p => p.Takeanimals)
                .HasForeignKey(d => d.Aniimalsinsheltrsid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("takeanimal_animalsinheltetrs_fk");

            entity.HasOne(d => d.IduserNavigation).WithMany(p => p.Takeanimals)
                .HasForeignKey(d => d.Iduser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("takeanimal_user_fk");

            entity.HasOne(d => d.Sheler).WithMany(p => p.Takeanimals)
                .HasForeignKey(d => d.Shelerid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("takeanimal_shelter_fk");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_pk");

            entity.ToTable("user");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Firstname)
                .HasColumnType("character varying")
                .HasColumnName("firstname");
            entity.Property(e => e.Phone)
                .HasColumnType("character varying")
                .HasColumnName("phone");
            entity.Property(e => e.Secondname)
                .HasColumnType("character varying")
                .HasColumnName("secondname");
            entity.Property(e => e.Therdname)
                .HasColumnType("character varying")
                .HasColumnName("therdname");
        });

        modelBuilder.Entity<Vaccine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("vacin_pk");

            entity.ToTable("vaccine");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Pssoprtid).HasColumnName("pssoprtid");

            entity.HasOne(d => d.Pssoprt).WithMany(p => p.Vaccines)
                .HasForeignKey(d => d.Pssoprtid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("vacin_passport_fk");
        });

        modelBuilder.Entity<Vetclinic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("vetclinic_pk");

            entity.ToTable("vetclinic");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Adress)
                .HasColumnType("character varying")
                .HasColumnName("adress");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
