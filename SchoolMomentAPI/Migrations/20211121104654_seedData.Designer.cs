// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolMomentAPI.Data;

namespace SchoolMomentAPI.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20211121104654_seedData")]
    partial class seedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SchoolMomentAPI.Models.Moment", b =>
                {
                    b.Property<int>("MomentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MomentId");

                    b.ToTable("Moments");

                    b.HasData(
                        new
                        {
                            MomentId = 1,
                            Category = 2,
                            DateTime = new DateTime(2021, 11, 29, 11, 46, 53, 241, DateTimeKind.Local).AddTicks(8675),
                            Duration = 2,
                            Name = "Moment0"
                        },
                        new
                        {
                            MomentId = 2,
                            Category = 0,
                            DateTime = new DateTime(2021, 11, 23, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(4670),
                            Duration = 2,
                            Name = "Moment1"
                        },
                        new
                        {
                            MomentId = 3,
                            Category = 0,
                            DateTime = new DateTime(2021, 11, 23, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(4926),
                            Duration = 2,
                            Name = "Moment2"
                        },
                        new
                        {
                            MomentId = 4,
                            Category = 1,
                            DateTime = new DateTime(2021, 11, 27, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(4968),
                            Duration = 2,
                            Name = "Moment3"
                        },
                        new
                        {
                            MomentId = 5,
                            Category = 1,
                            DateTime = new DateTime(2021, 11, 22, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(5000),
                            Duration = 2,
                            Name = "Moment4"
                        },
                        new
                        {
                            MomentId = 6,
                            Category = 3,
                            DateTime = new DateTime(2021, 11, 23, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(5043),
                            Duration = 2,
                            Name = "Moment5"
                        },
                        new
                        {
                            MomentId = 7,
                            Category = 2,
                            DateTime = new DateTime(2021, 11, 29, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(5085),
                            Duration = 2,
                            Name = "Moment6"
                        },
                        new
                        {
                            MomentId = 8,
                            Category = 2,
                            DateTime = new DateTime(2021, 11, 29, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(5119),
                            Duration = 2,
                            Name = "Moment7"
                        },
                        new
                        {
                            MomentId = 9,
                            Category = 2,
                            DateTime = new DateTime(2021, 11, 23, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(5151),
                            Duration = 2,
                            Name = "Moment8"
                        },
                        new
                        {
                            MomentId = 10,
                            Category = 0,
                            DateTime = new DateTime(2021, 11, 29, 11, 46, 53, 245, DateTimeKind.Local).AddTicks(5183),
                            Duration = 2,
                            Name = "Moment9"
                        });
                });

            modelBuilder.Entity("SchoolMomentAPI.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MomentId")
                        .HasColumnType("int");

                    b.Property<int?>("MomentId1")
                        .HasColumnType("int");

                    b.Property<string>("StudentNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(true);

                    b.HasKey("StudentId");

                    b.HasIndex("MomentId");

                    b.HasIndex("MomentId1");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            FirstName = "Student0",
                            LastName = "LastName",
                            StudentNumber = "10000001"
                        },
                        new
                        {
                            StudentId = 2,
                            FirstName = "Student1",
                            LastName = "LastName",
                            StudentNumber = "10000002"
                        },
                        new
                        {
                            StudentId = 3,
                            FirstName = "Student2",
                            LastName = "LastName",
                            StudentNumber = "10000003"
                        },
                        new
                        {
                            StudentId = 4,
                            FirstName = "Student3",
                            LastName = "LastName",
                            StudentNumber = "10000004"
                        },
                        new
                        {
                            StudentId = 5,
                            FirstName = "Student4",
                            LastName = "LastName",
                            StudentNumber = "10000005"
                        },
                        new
                        {
                            StudentId = 6,
                            FirstName = "Student5",
                            LastName = "LastName",
                            StudentNumber = "10000006"
                        },
                        new
                        {
                            StudentId = 7,
                            FirstName = "Student6",
                            LastName = "LastName",
                            StudentNumber = "10000007"
                        },
                        new
                        {
                            StudentId = 8,
                            FirstName = "Student7",
                            LastName = "LastName",
                            StudentNumber = "10000008"
                        },
                        new
                        {
                            StudentId = 9,
                            FirstName = "Student8",
                            LastName = "LastName",
                            StudentNumber = "10000009"
                        },
                        new
                        {
                            StudentId = 10,
                            FirstName = "Student9",
                            LastName = "LastName",
                            StudentNumber = "10000010"
                        });
                });

            modelBuilder.Entity("SchoolMomentAPI.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(true);

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            FirstName = "Teacher0",
                            LastName = "LastName",
                            TeacherNumber = "1000000001"
                        },
                        new
                        {
                            TeacherId = 2,
                            FirstName = "Teacher1",
                            LastName = "LastName",
                            TeacherNumber = "1000000002"
                        },
                        new
                        {
                            TeacherId = 3,
                            FirstName = "Teacher2",
                            LastName = "LastName",
                            TeacherNumber = "1000000003"
                        },
                        new
                        {
                            TeacherId = 4,
                            FirstName = "Teacher3",
                            LastName = "LastName",
                            TeacherNumber = "1000000004"
                        },
                        new
                        {
                            TeacherId = 5,
                            FirstName = "Teacher4",
                            LastName = "LastName",
                            TeacherNumber = "1000000005"
                        },
                        new
                        {
                            TeacherId = 6,
                            FirstName = "Teacher5",
                            LastName = "LastName",
                            TeacherNumber = "1000000006"
                        },
                        new
                        {
                            TeacherId = 7,
                            FirstName = "Teacher6",
                            LastName = "LastName",
                            TeacherNumber = "1000000007"
                        },
                        new
                        {
                            TeacherId = 8,
                            FirstName = "Teacher7",
                            LastName = "LastName",
                            TeacherNumber = "1000000008"
                        },
                        new
                        {
                            TeacherId = 9,
                            FirstName = "Teacher8",
                            LastName = "LastName",
                            TeacherNumber = "1000000009"
                        },
                        new
                        {
                            TeacherId = 10,
                            FirstName = "Teacher9",
                            LastName = "LastName",
                            TeacherNumber = "1000000010"
                        });
                });

            modelBuilder.Entity("SchoolMomentAPI.Models.Student", b =>
                {
                    b.HasOne("SchoolMomentAPI.Models.Moment", null)
                        .WithMany("AttendedStudents")
                        .HasForeignKey("MomentId");

                    b.HasOne("SchoolMomentAPI.Models.Moment", null)
                        .WithMany("RequestedStudents")
                        .HasForeignKey("MomentId1");
                });
#pragma warning restore 612, 618
        }
    }
}
