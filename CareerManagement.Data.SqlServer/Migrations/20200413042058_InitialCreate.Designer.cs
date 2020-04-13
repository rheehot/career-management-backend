﻿// <auto-generated />
using System;
using CareerManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CareerManagement.Data.SqlServer.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200413042058_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CareerManagement.Entities.Career", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(36)")
                        .HasComment("식별자")
                        .HasMaxLength(36);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(2000)")
                        .HasComment("설명")
                        .HasMaxLength(2000);

                    b.Property<string>("Period")
                        .HasColumnType("nvarchar(200)")
                        .HasComment("기간")
                        .HasMaxLength(200);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasComment("상태")
                        .HasMaxLength(200);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(2000)")
                        .HasComment("제목; 직장명")
                        .HasMaxLength(2000);

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasComment("사용자 식별자")
                        .HasMaxLength(36);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Career");
                });

            modelBuilder.Entity("CareerManagement.Entities.CareerLink", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(36)")
                        .HasComment("식별자")
                        .HasMaxLength(36);

                    b.Property<string>("CareerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasComment("경력 식별자")
                        .HasMaxLength(36);

                    b.Property<string>("Href")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasComment("링크 주소")
                        .HasMaxLength(500);

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(200)")
                        .HasComment("아이콘")
                        .HasMaxLength(200);

                    b.Property<string>("Target")
                        .HasColumnType("nvarchar(200)")
                        .HasComment("링크 대상")
                        .HasMaxLength(200);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasComment("링크 제목")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CareerId");

                    b.ToTable("CareerLink");
                });

            modelBuilder.Entity("CareerManagement.Entities.Education", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(36)")
                        .HasComment("식별자")
                        .HasMaxLength(36);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(2000)")
                        .HasComment("설명")
                        .HasMaxLength(2000);

                    b.Property<string>("Period")
                        .HasColumnType("nvarchar(200)")
                        .HasComment("기간")
                        .HasMaxLength(200);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(200)")
                        .HasComment("상태")
                        .HasMaxLength(200);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasComment("제목")
                        .HasMaxLength(200);

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasComment("사용자 식별자")
                        .HasMaxLength(36);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("CareerManagement.Entities.EducationLink", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(36)")
                        .HasComment("식별자")
                        .HasMaxLength(36);

                    b.Property<string>("EducationId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasComment("교육 식별자")
                        .HasMaxLength(36);

                    b.Property<string>("Href")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasComment("링크 주소")
                        .HasMaxLength(500);

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(200)")
                        .HasComment("아이콘")
                        .HasMaxLength(200);

                    b.Property<string>("Target")
                        .HasColumnType("nvarchar(200)")
                        .HasComment("링크 대상")
                        .HasMaxLength(200);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasComment("링크 제목")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("EducationId");

                    b.ToTable("EducationLink");
                });

            modelBuilder.Entity("CareerManagement.Entities.Portfolio", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(36)")
                        .HasComment("식별자")
                        .HasMaxLength(36);

                    b.Property<string>("Descriptoin")
                        .HasColumnType("nvarchar(2000)")
                        .HasComment("설명")
                        .HasMaxLength(2000);

                    b.Property<string>("Period")
                        .HasColumnType("nvarchar(200)")
                        .HasComment("기간")
                        .HasMaxLength(200);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasComment("상태")
                        .HasMaxLength(200);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasComment("제목")
                        .HasMaxLength(200);

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasComment("사용자 식별자")
                        .HasMaxLength(36);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Portfolio");
                });

            modelBuilder.Entity("CareerManagement.Entities.PortfolioFeature", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(36)")
                        .HasComment("식별자")
                        .HasMaxLength(36);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(2000)")
                        .HasComment("내용")
                        .HasMaxLength(2000);

                    b.Property<string>("PortfolioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasComment("포트폴리오 식별자")
                        .HasMaxLength(36);

                    b.HasKey("Id");

                    b.HasIndex("PortfolioId");

                    b.ToTable("PortfolioFeature");
                });

            modelBuilder.Entity("CareerManagement.Entities.PortfolioLink", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(36)")
                        .HasComment("식별자")
                        .HasMaxLength(36);

                    b.Property<string>("Href")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasComment("링크 주소")
                        .HasMaxLength(500);

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(200)")
                        .HasComment("아이콘")
                        .HasMaxLength(200);

                    b.Property<string>("PortfolioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasComment("포트폴리오 식별자")
                        .HasMaxLength(36);

                    b.Property<string>("Target")
                        .HasColumnType("nvarchar(200)")
                        .HasComment("링크 대상")
                        .HasMaxLength(200);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasComment("링크 제목")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("PortfolioId");

                    b.ToTable("PortfolioLink");
                });

            modelBuilder.Entity("CareerManagement.Entities.PortfolioTag", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(36)")
                        .HasComment("식별자")
                        .HasMaxLength(36);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasComment("태그")
                        .HasMaxLength(200);

                    b.Property<string>("PortfolioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasComment("포트폴리오 식별자")
                        .HasMaxLength(36);

                    b.HasKey("Id");

                    b.HasIndex("PortfolioId");

                    b.ToTable("PortfolioTag");
                });

            modelBuilder.Entity("CareerManagement.Entities.Profile", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(36)")
                        .HasComment("식별자")
                        .HasMaxLength(36);

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(2000)")
                        .HasComment("상태")
                        .HasMaxLength(2000);

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasComment("사용자 식별자")
                        .HasMaxLength(36);

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("CareerManagement.Entities.ProfileLink", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(36)")
                        .HasComment("식별자")
                        .HasMaxLength(36);

                    b.Property<string>("Href")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasComment("링크 주소")
                        .HasMaxLength(500);

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(200)")
                        .HasComment("아이콘")
                        .HasMaxLength(200);

                    b.Property<string>("ProfileId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasComment("프로필 식별자")
                        .HasMaxLength(36);

                    b.Property<string>("Target")
                        .HasColumnType("nvarchar(200)")
                        .HasComment("링크 대상")
                        .HasMaxLength(200);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasComment("링크 제목")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("ProfileLink");
                });

            modelBuilder.Entity("CareerManagement.Entities.Skill", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(36)")
                        .HasComment("식별자")
                        .HasMaxLength(36);

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(200)")
                        .HasComment("아이콘")
                        .HasMaxLength(200);

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasComment("사용자 식별자")
                        .HasMaxLength(36);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("CareerManagement.Entities.SkillItem", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(36)")
                        .HasComment("식별자")
                        .HasMaxLength(36);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasComment("이름")
                        .HasMaxLength(200);

                    b.Property<float>("Score")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("real")
                        .HasComment("점수")
                        .HasDefaultValue(0f);

                    b.Property<string>("SkillId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasComment("기술 식별자")
                        .HasMaxLength(36);

                    b.HasKey("Id");

                    b.HasIndex("SkillId");

                    b.ToTable("SkillItem");
                });

            modelBuilder.Entity("CareerManagement.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(36)")
                        .HasComment("식별자")
                        .HasMaxLength(36);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasComment("전자우편주소")
                        .HasMaxLength(100);

                    b.Property<string>("ImageUri")
                        .HasColumnType("nvarchar(500)")
                        .HasComment("사용자 이미지 URI")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasComment("사용자 이름 (출력)")
                        .HasMaxLength(200);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasComment("계정이름")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CareerManagement.Entities.UserLogin", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(36)")
                        .HasComment("사용자 식별자")
                        .HasMaxLength(36);

                    b.Property<DateTimeOffset>("ExpiredAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasComment("만료시각")
                        .HasDefaultValue(new DateTimeOffset(new DateTime(2020, 7, 13, 4, 20, 58, 230, DateTimeKind.Unspecified).AddTicks(7648), new TimeSpan(0, 0, 0, 0, 0)));

                    b.Property<bool>("IsLocked")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasComment("로그인 잠김")
                        .HasDefaultValue(false);

                    b.Property<DateTimeOffset?>("LockedAt")
                        .HasColumnType("datetimeoffset")
                        .HasComment("로그인 잠김 시각");

                    b.Property<string>("Provider")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(200)")
                        .HasComment("사용자 로그인 제공자")
                        .HasMaxLength(200)
                        .HasDefaultValue("Local");

                    b.Property<int>("RetryCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("로그인 재시도 횟수")
                        .HasDefaultValue(0);

                    b.Property<string>("Secret")
                        .IsRequired()
                        .HasColumnType("nvarchar(2000)")
                        .HasComment("비밀키; 비밀번호 해시")
                        .HasMaxLength(2000);

                    b.HasKey("UserId");

                    b.ToTable("UserLogin");
                });

            modelBuilder.Entity("CareerManagement.Entities.Career", b =>
                {
                    b.HasOne("CareerManagement.Entities.User", "User")
                        .WithMany("Careers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CareerManagement.Entities.CareerLink", b =>
                {
                    b.HasOne("CareerManagement.Entities.Career", "Career")
                        .WithMany("Links")
                        .HasForeignKey("CareerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CareerManagement.Entities.Education", b =>
                {
                    b.HasOne("CareerManagement.Entities.User", "User")
                        .WithMany("Educations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CareerManagement.Entities.EducationLink", b =>
                {
                    b.HasOne("CareerManagement.Entities.Education", "Education")
                        .WithMany("Links")
                        .HasForeignKey("EducationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CareerManagement.Entities.Portfolio", b =>
                {
                    b.HasOne("CareerManagement.Entities.User", "User")
                        .WithMany("Portfolios")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CareerManagement.Entities.PortfolioFeature", b =>
                {
                    b.HasOne("CareerManagement.Entities.Portfolio", "Portfolio")
                        .WithMany("Features")
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CareerManagement.Entities.PortfolioLink", b =>
                {
                    b.HasOne("CareerManagement.Entities.Portfolio", "Portfolio")
                        .WithMany("Links")
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CareerManagement.Entities.PortfolioTag", b =>
                {
                    b.HasOne("CareerManagement.Entities.Portfolio", "Portfolio")
                        .WithMany("Tags")
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CareerManagement.Entities.Profile", b =>
                {
                    b.HasOne("CareerManagement.Entities.User", "User")
                        .WithOne("Profile")
                        .HasForeignKey("CareerManagement.Entities.Profile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CareerManagement.Entities.ProfileLink", b =>
                {
                    b.HasOne("CareerManagement.Entities.Profile", "Profile")
                        .WithMany("Links")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CareerManagement.Entities.Skill", b =>
                {
                    b.HasOne("CareerManagement.Entities.User", "User")
                        .WithMany("Skills")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CareerManagement.Entities.SkillItem", b =>
                {
                    b.HasOne("CareerManagement.Entities.Skill", "Skill")
                        .WithMany("Items")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CareerManagement.Entities.UserLogin", b =>
                {
                    b.HasOne("CareerManagement.Entities.User", "User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
