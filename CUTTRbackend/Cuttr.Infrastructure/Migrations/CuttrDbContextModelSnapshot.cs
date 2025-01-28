﻿// <auto-generated />
using System;
using Cuttr.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;

#nullable disable

namespace Cuttr.Infrastructure.Migrations
{
    [DbContext(typeof(CuttrDbContext))]
    partial class CuttrDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cuttr.Infrastructure.Entities.ConnectionEF", b =>
                {
                    b.Property<int>("ConnectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConnectionId"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<int>("UserId1")
                        .HasColumnType("int");

                    b.Property<int>("UserId2")
                        .HasColumnType("int");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("ConnectionId");

                    b.HasIndex("UserId1");

                    b.HasIndex("UserId2");

                    b.ToTable("Connections");
                });

            modelBuilder.Entity("Cuttr.Infrastructure.Entities.MatchEF", b =>
                {
                    b.Property<int>("MatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MatchId"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<int>("PlantId1")
                        .HasColumnType("int");

                    b.Property<int>("PlantId2")
                        .HasColumnType("int");

                    b.Property<int>("UserId1")
                        .HasColumnType("int");

                    b.Property<int>("UserId2")
                        .HasColumnType("int");

                    b.HasKey("MatchId");

                    b.HasIndex("PlantId2");

                    b.HasIndex("UserId1");

                    b.HasIndex("UserId2");

                    b.HasIndex("PlantId1", "PlantId2")
                        .IsUnique();

                    b.ToTable("Matches", t =>
                        {
                            t.HasCheckConstraint("CK_MatchEF_PlantIdOrder", "[PlantId1] < [PlantId2]");
                        });
                });

            modelBuilder.Entity("Cuttr.Infrastructure.Entities.MessageEF", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MessageId"));

                    b.Property<int>("ConnectionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<int?>("MatchEFMatchId")
                        .HasColumnType("int");

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.Property<string>("MessageText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SenderUserId")
                        .HasColumnType("int");

                    b.HasKey("MessageId");

                    b.HasIndex("ConnectionId");

                    b.HasIndex("MatchEFMatchId");

                    b.HasIndex("SenderUserId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Cuttr.Infrastructure.Entities.PlantEF", b =>
                {
                    b.Property<int>("PlantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlantId"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Extras")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IndoorOutdoor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsTraded")
                        .HasColumnType("bit");

                    b.Property<string>("LightRequirement")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PetFriendly")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PlantCategory")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PlantStage")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PropagationEase")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SpeciesName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("WateringNeed")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PlantId");

                    b.HasIndex("UserId");

                    b.ToTable("Plants");
                });

            modelBuilder.Entity("Cuttr.Infrastructure.Entities.RefreshTokenEF", b =>
                {
                    b.Property<int>("RefreshTokenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RefreshTokenId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpiresAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRevoked")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("RevokedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("TokenHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RefreshTokenId");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("Cuttr.Infrastructure.Entities.ReportEF", b =>
                {
                    b.Property<int>("ReportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReportId"));

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<bool>("IsResolved")
                        .HasColumnType("bit");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReportedUserId")
                        .HasColumnType("int");

                    b.Property<int>("ReporterUserId")
                        .HasColumnType("int");

                    b.HasKey("ReportId");

                    b.HasIndex("ReportedUserId");

                    b.HasIndex("ReporterUserId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("Cuttr.Infrastructure.Entities.SwipeEF", b =>
                {
                    b.Property<int>("SwipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SwipeId"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<bool>("IsLike")
                        .HasColumnType("bit");

                    b.Property<int>("SwipedPlantId")
                        .HasColumnType("int");

                    b.Property<int>("SwiperPlantId")
                        .HasColumnType("int");

                    b.HasKey("SwipeId");

                    b.HasIndex("SwipedPlantId");

                    b.HasIndex("SwiperPlantId", "SwipedPlantId")
                        .IsUnique();

                    b.ToTable("Swipes");
                });

            modelBuilder.Entity("Cuttr.Infrastructure.Entities.TradeProposalEF", b =>
                {
                    b.Property<int>("TradeProposalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TradeProposalId"));

                    b.Property<DateTime?>("AcceptedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CompletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ConnectionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeclinedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("PlantIdsProposedByUser1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlantIdsProposedByUser2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TradeProposalStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TradeProposalId");

                    b.HasIndex("ConnectionId");

                    b.ToTable("TradeProposals");
                });

            modelBuilder.Entity("Cuttr.Infrastructure.Entities.UserEF", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Bio")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<Point>("Location")
                        .HasColumnType("geography");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Cuttr.Infrastructure.Entities.UserPreferencesEF", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("PreferedExtras")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreferedIndoorOutdoor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreferedLightRequirement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreferedPetFriendly")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreferedPlantCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreferedPlantStage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreferedPropagationEase")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreferedSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreferedWateringNeed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SearchRadius")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("UserPreferences");
                });

            modelBuilder.Entity("Cuttr.Infrastructure.Entities.ConnectionEF", b =>
                {
                    b.HasOne("Cuttr.Infrastructure.Entities.UserEF", "User1")
                        .WithMany()
                        .HasForeignKey("UserId1")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Cuttr.Infrastructure.Entities.UserEF", "User2")
                        .WithMany()
                        .HasForeignKey("UserId2")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User1");

                    b.Navigation("User2");
                });

            modelBuilder.Entity("Cuttr.Infrastructure.Entities.MatchEF", b =>
                {
                    b.HasOne("Cuttr.Infrastructure.Entities.PlantEF", "Plant1")
                        .WithMany()
                        .HasForeignKey("PlantId1")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Cuttr.Infrastructure.Entities.PlantEF", "Plant2")
                        .WithMany()
                        .HasForeignKey("PlantId2")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Cuttr.Infrastructure.Entities.UserEF", "User1")
                        .WithMany()
                        .HasForeignKey("UserId1")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Cuttr.Infrastructure.Entities.UserEF", "User2")
                        .WithMany()
                        .HasForeignKey("UserId2")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Plant1");

                    b.Navigation("Plant2");

                    b.Navigation("User1");

                    b.Navigation("User2");
                });

            modelBuilder.Entity("Cuttr.Infrastructure.Entities.MessageEF", b =>
                {
                    b.HasOne("Cuttr.Infrastructure.Entities.ConnectionEF", "Connection")
                        .WithMany("Messages")
                        .HasForeignKey("ConnectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cuttr.Infrastructure.Entities.MatchEF", null)
                        .WithMany("Messages")
                        .HasForeignKey("MatchEFMatchId");

                    b.HasOne("Cuttr.Infrastructure.Entities.UserEF", "SenderUser")
                        .WithMany("SentMessages")
                        .HasForeignKey("SenderUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Connection");

                    b.Navigation("SenderUser");
                });

            modelBuilder.Entity("Cuttr.Infrastructure.Entities.PlantEF", b =>
                {
                    b.HasOne("Cuttr.Infrastructure.Entities.UserEF", "User")
                        .WithMany("Plants")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Cuttr.Infrastructure.Entities.RefreshTokenEF", b =>
                {
                    b.HasOne("Cuttr.Infrastructure.Entities.UserEF", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Cuttr.Infrastructure.Entities.ReportEF", b =>
                {
                    b.HasOne("Cuttr.Infrastructure.Entities.UserEF", "ReportedUser")
                        .WithMany("ReportsReceived")
                        .HasForeignKey("ReportedUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Cuttr.Infrastructure.Entities.UserEF", "ReporterUser")
                        .WithMany("ReportsMade")
                        .HasForeignKey("ReporterUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ReportedUser");

                    b.Navigation("ReporterUser");
                });

            modelBuilder.Entity("Cuttr.Infrastructure.Entities.SwipeEF", b =>
                {
                    b.HasOne("Cuttr.Infrastructure.Entities.PlantEF", "SwipedPlant")
                        .WithMany()
                        .HasForeignKey("SwipedPlantId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Cuttr.Infrastructure.Entities.PlantEF", "SwiperPlant")
                        .WithMany()
                        .HasForeignKey("SwiperPlantId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("SwipedPlant");

                    b.Navigation("SwiperPlant");
                });

            modelBuilder.Entity("Cuttr.Infrastructure.Entities.TradeProposalEF", b =>
                {
                    b.HasOne("Cuttr.Infrastructure.Entities.ConnectionEF", "Connection")
                        .WithMany("TradeProposals")
                        .HasForeignKey("ConnectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Connection");
                });

            modelBuilder.Entity("Cuttr.Infrastructure.Entities.UserPreferencesEF", b =>
                {
                    b.HasOne("Cuttr.Infrastructure.Entities.UserEF", "User")
                        .WithOne("Preferences")
                        .HasForeignKey("Cuttr.Infrastructure.Entities.UserPreferencesEF", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Cuttr.Infrastructure.Entities.ConnectionEF", b =>
                {
                    b.Navigation("Messages");

                    b.Navigation("TradeProposals");
                });

            modelBuilder.Entity("Cuttr.Infrastructure.Entities.MatchEF", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("Cuttr.Infrastructure.Entities.UserEF", b =>
                {
                    b.Navigation("Plants");

                    b.Navigation("Preferences")
                        .IsRequired();

                    b.Navigation("ReportsMade");

                    b.Navigation("ReportsReceived");

                    b.Navigation("SentMessages");
                });
#pragma warning restore 612, 618
        }
    }
}
