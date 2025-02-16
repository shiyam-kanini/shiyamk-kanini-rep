﻿// <auto-generated />
using IRepository_Hospital_5_5_23.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IRepository_Hospital_5_5_23.Migrations
{
    [DbContext(typeof(HospitalContext))]
    partial class HospitalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IRepository_Hospital_5_5_23.Models.Doctor", b =>
                {
                    b.Property<int>("Did")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Did"));

                    b.Property<string>("Dname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DName");

                    b.HasKey("Did");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("IRepository_Hospital_5_5_23.Models.Patient", b =>
                {
                    b.Property<int>("Pid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Pid"));

                    b.Property<int>("DoctorsDid")
                        .HasColumnType("int")
                        .HasColumnName("DoctorsDId");

                    b.Property<string>("Pname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PName");

                    b.HasKey("Pid");

                    b.HasIndex(new[] { "DoctorsDid" }, "IX_Patients_DoctorsDId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("IRepository_Hospital_5_5_23.Models.Patient", b =>
                {
                    b.HasOne("IRepository_Hospital_5_5_23.Models.Doctor", "DoctorsD")
                        .WithMany("Patients")
                        .HasForeignKey("DoctorsDid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DoctorsD");
                });

            modelBuilder.Entity("IRepository_Hospital_5_5_23.Models.Doctor", b =>
                {
                    b.Navigation("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}
