using System;
using TrainStation.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TrainStation.DAL.DBContext
{
    public partial class TrainStationContext : IdentityDbContext<User>
    {
        public TrainStationContext()
        {
        }

        public TrainStationContext(DbContextOptions<TrainStationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Passage> Passage { get; set; }
        public virtual DbSet<PassageSchedule> PassageSchedule { get; set; }
        public virtual DbSet<Passenger> Passenger { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=TrainStation;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
 
            modelBuilder.Entity<Passenger>(entity =>
            {
                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

                                            
         modelBuilder.Entity<PassageSchedule>(entity =>
            {
                

                entity.ToTable("Passage_schedule");

                entity.Property(e => e.DepartureDate)
                    .IsRequired()
                    .HasColumnName("Departure_date")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DepartureTime)
                    .IsRequired()
                    .HasColumnName("Departure_time")
                    .HasMaxLength(30)
                    .IsUnicode(false);
               
            });

           modelBuilder.Entity<Passage>(entity =>
            {
                entity.Property(e => e.Passages)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Froms)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Wheres)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                modelBuilder.Entity<Passage>()
                .HasOne<Passenger>()
                .WithMany()
                .HasForeignKey(p => p.PassengerId);

                modelBuilder.Entity<Passage>()
               .HasOne<PassageSchedule>()
               .WithMany()
               .HasForeignKey(p => p.PassageSheduleId);

            });

            modelBuilder.Entity<Passenger>().HasData(
                  new Passenger[] {
                    new Passenger { Id = 1, Name = "Arthur", LastName = "Ohandzhanian" }

                  });
           
            modelBuilder.Entity<PassageSchedule>().HasData(
                 new PassageSchedule[] {
                    new PassageSchedule { Id = 1, DepartureDate = "25.12.2021", DepartureTime = "04:40:00"}

                 });

            modelBuilder.Entity<Passage>().HasData(
                 new Passage[] {
                    new Passage { Id = 1,PassengerId =1, PassageSheduleId = 1,Froms = "Madrid", Wheres = "Kiev",Passages = "UKRstation" }

                 });
            modelBuilder.Entity<User>().HasData(
               new User[] {
                    new User { UserName = "arthur", FirstName = "Arthur", LastName = "Ohandzhanian", Email = "arikukraine@gmail.com"}
               });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
 
