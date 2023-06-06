﻿// <auto-generated />
using System;
using Digdir.Domain.Dialogporten.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Digdir.Domain.Dialogporten.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(DialogDbContext))]
    [Migration("20230602121149_AddDialogueTables")]
    partial class AddDialogueTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.Actions.DialogueApiAction", b =>
                {
                    b.Property<long>("InternalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("InternalId"));

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTimeOffset>("CreatedAtUtc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp at time zone 'utc'");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("uuid");

                    b.Property<long>("DialogueId")
                        .HasColumnType("bigint");

                    b.Property<string>("DocumentationUrl")
                        .HasMaxLength(1023)
                        .HasColumnType("character varying(1023)");

                    b.Property<string>("HttpMethod")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("RequestSchema")
                        .HasMaxLength(1023)
                        .HasColumnType("character varying(1023)");

                    b.Property<string>("Resource")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("ResponseSchema")
                        .HasMaxLength(1023)
                        .HasColumnType("character varying(1023)");

                    b.Property<DateTimeOffset>("UpdatedAtUtc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp at time zone 'utc'");

                    b.Property<Guid>("UpdatedByUserId")
                        .HasColumnType("uuid");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(1023)
                        .HasColumnType("character varying(1023)");

                    b.HasKey("InternalId");

                    b.HasIndex("DialogueId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("DialogueApiAction");
                });

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.Actions.DialogueGuiAction", b =>
                {
                    b.Property<long>("InternalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("InternalId"));

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTimeOffset>("CreatedAtUtc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp at time zone 'utc'");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("uuid");

                    b.Property<long>("DialogueId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<bool>("IsBackChannel")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleteAction")
                        .HasColumnType("boolean");

                    b.Property<string>("Resource")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<long>("TitleInternalId")
                        .HasColumnType("bigint");

                    b.Property<int>("TypeId")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("UpdatedAtUtc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp at time zone 'utc'");

                    b.Property<Guid>("UpdatedByUserId")
                        .HasColumnType("uuid");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(1023)
                        .HasColumnType("character varying(1023)");

                    b.HasKey("InternalId");

                    b.HasIndex("DialogueId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("TitleInternalId");

                    b.HasIndex("TypeId");

                    b.ToTable("DialogueGuiAction");
                });

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.Actions.DialogueGuiActionType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.ToTable("DialogueGuiActionType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Primary"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Secondary"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Tertiary"
                        });
                });

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.Activities.DialogueActivity", b =>
                {
                    b.Property<long>("InternalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("InternalId"));

                    b.Property<DateTimeOffset>("CreatedAtUtc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp at time zone 'utc'");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("uuid");

                    b.Property<long>("DescriptionInternalId")
                        .HasColumnType("bigint");

                    b.Property<string>("DetailsApiUrl")
                        .HasMaxLength(1023)
                        .HasColumnType("character varying(1023)");

                    b.Property<string>("DetailsGuiUrl")
                        .HasMaxLength(1023)
                        .HasColumnType("character varying(1023)");

                    b.Property<long>("DialogueId")
                        .HasColumnType("bigint");

                    b.Property<string>("ExtendedType")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("PerformedBy")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("TypeId")
                        .HasColumnType("integer");

                    b.HasKey("InternalId");

                    b.HasIndex("DescriptionInternalId");

                    b.HasIndex("DialogueId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("TypeId");

                    b.ToTable("DialogueActivity");
                });

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.Activities.DialogueActivityType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.ToTable("DialogueActivityType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Submission"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Feedback"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Information"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Error"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Closed"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Seen"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Forwarded"
                        });
                });

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.Attachments.DialogueAttachement", b =>
                {
                    b.Property<long>("InternalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("InternalId"));

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTimeOffset>("CreatedAtUtc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp at time zone 'utc'");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("uuid");

                    b.Property<long>("DialogueId")
                        .HasColumnType("bigint");

                    b.Property<long>("DisplayNameInternalId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("Resource")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<long>("SizeInBytes")
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset>("UpdatedAtUtc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp at time zone 'utc'");

                    b.Property<Guid>("UpdatedByUserId")
                        .HasColumnType("uuid");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(1023)
                        .HasColumnType("character varying(1023)");

                    b.HasKey("InternalId");

                    b.HasIndex("DialogueId");

                    b.HasIndex("DisplayNameInternalId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("DialogueAttachement");
                });

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.DialogueEntity", b =>
                {
                    b.Property<long>("InternalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("InternalId"));

                    b.Property<long>("BodyId")
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset>("CreatedAtUtc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp at time zone 'utc'");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset?>("DueAtUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("ExpiresAtUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ExtendedStatus")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("Org")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Party")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTimeOffset?>("ReadAtUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("SearchTitleId")
                        .HasColumnType("bigint");

                    b.Property<long>("SenderNameId")
                        .HasColumnType("bigint");

                    b.Property<string>("ServiceResourceIdentifier")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.Property<long>("TitleId")
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset>("UpdatedAtUtc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp at time zone 'utc'");

                    b.Property<Guid>("UpdatedByUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("VisibleFromUtc")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("InternalId");

                    b.HasIndex("BodyId")
                        .IsUnique();

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("SearchTitleId")
                        .IsUnique();

                    b.HasIndex("SenderNameId")
                        .IsUnique();

                    b.HasIndex("StatusId");

                    b.HasIndex("TitleId")
                        .IsUnique();

                    b.ToTable("Dialogue", (string)null);
                });

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.DialogueStatus", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.ToTable("DialogueStatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Unspecified"
                        },
                        new
                        {
                            Id = 2,
                            Name = "InProgress"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Waiting"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Signing"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Cancelled"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Completed"
                        });
                });

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.TokenScopes.DialogueTokenScope", b =>
                {
                    b.Property<long>("InternalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("InternalId"));

                    b.Property<DateTimeOffset>("CreatedAtUtc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp at time zone 'utc'");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("uuid");

                    b.Property<long>("DialogueId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("InternalId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("DialogueId", "Value")
                        .IsUnique();

                    b.ToTable("DialogueTokenScope");
                });

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Localizations.Localization", b =>
                {
                    b.Property<long>("LocalizationSetId")
                        .HasColumnType("bigint");

                    b.Property<string>("CultureCode")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<DateTimeOffset>("CreatedAtUtc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp at time zone 'utc'");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("UpdatedAtUtc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp at time zone 'utc'");

                    b.Property<Guid>("UpdatedByUserId")
                        .HasColumnType("uuid");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("LocalizationSetId", "CultureCode");

                    b.ToTable("Localization");
                });

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Localizations.LocalizationSet", b =>
                {
                    b.Property<long>("InternalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("InternalId"));

                    b.Property<DateTimeOffset>("CreatedAtUtc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("current_timestamp at time zone 'utc'");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.HasKey("InternalId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("LocalizationSet");
                });

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Outboxes.OutboxMessage", b =>
                {
                    b.Property<Guid>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("EventPayload")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("jsonb");

                    b.Property<string>("EventType")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("EventId");

                    b.ToTable("OutboxMessage");
                });

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Outboxes.OutboxMessageConsumer", b =>
                {
                    b.Property<Guid>("EventId")
                        .HasColumnType("uuid");

                    b.Property<string>("ConsumerName")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("EventId", "ConsumerName");

                    b.ToTable("OutboxMessageConsumer");
                });

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.Actions.DialogueApiAction", b =>
                {
                    b.HasOne("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.DialogueEntity", "Dialogue")
                        .WithMany("ApiActions")
                        .HasForeignKey("DialogueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dialogue");
                });

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.Actions.DialogueGuiAction", b =>
                {
                    b.HasOne("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.DialogueEntity", "Dialogue")
                        .WithMany("GuiActions")
                        .HasForeignKey("DialogueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Digdir.Domain.Dialogporten.Domain.Localizations.LocalizationSet", "Title")
                        .WithMany()
                        .HasForeignKey("TitleInternalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.Actions.DialogueGuiActionType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dialogue");

                    b.Navigation("Title");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.Activities.DialogueActivity", b =>
                {
                    b.HasOne("Digdir.Domain.Dialogporten.Domain.Localizations.LocalizationSet", "Description")
                        .WithMany()
                        .HasForeignKey("DescriptionInternalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.DialogueEntity", "Dialogue")
                        .WithMany("History")
                        .HasForeignKey("DialogueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.Activities.DialogueActivityType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Description");

                    b.Navigation("Dialogue");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.Attachments.DialogueAttachement", b =>
                {
                    b.HasOne("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.DialogueEntity", "Dialogue")
                        .WithMany("Attachments")
                        .HasForeignKey("DialogueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Digdir.Domain.Dialogporten.Domain.Localizations.LocalizationSet", "DisplayName")
                        .WithMany()
                        .HasForeignKey("DisplayNameInternalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dialogue");

                    b.Navigation("DisplayName");
                });

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.DialogueEntity", b =>
                {
                    b.HasOne("Digdir.Domain.Dialogporten.Domain.Localizations.LocalizationSet", "Body")
                        .WithOne()
                        .HasForeignKey("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.DialogueEntity", "BodyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Digdir.Domain.Dialogporten.Domain.Localizations.LocalizationSet", "SearchTitle")
                        .WithOne()
                        .HasForeignKey("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.DialogueEntity", "SearchTitleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Digdir.Domain.Dialogporten.Domain.Localizations.LocalizationSet", "SenderName")
                        .WithOne()
                        .HasForeignKey("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.DialogueEntity", "SenderNameId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.DialogueStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Digdir.Domain.Dialogporten.Domain.Localizations.LocalizationSet", "Title")
                        .WithOne()
                        .HasForeignKey("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.DialogueEntity", "TitleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Body");

                    b.Navigation("SearchTitle");

                    b.Navigation("SenderName");

                    b.Navigation("Status");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.TokenScopes.DialogueTokenScope", b =>
                {
                    b.HasOne("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.DialogueEntity", "Dialogue")
                        .WithMany("TokenScopes")
                        .HasForeignKey("DialogueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dialogue");
                });

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Localizations.Localization", b =>
                {
                    b.HasOne("Digdir.Domain.Dialogporten.Domain.Localizations.LocalizationSet", "LocalizationSet")
                        .WithMany("Localizations")
                        .HasForeignKey("LocalizationSetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LocalizationSet");
                });

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Outboxes.OutboxMessageConsumer", b =>
                {
                    b.HasOne("Digdir.Domain.Dialogporten.Domain.Outboxes.OutboxMessage", "OutboxMessage")
                        .WithMany("OutboxMessageConsumers")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OutboxMessage");
                });

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Dialogues.Entities.DialogueEntity", b =>
                {
                    b.Navigation("ApiActions");

                    b.Navigation("Attachments");

                    b.Navigation("GuiActions");

                    b.Navigation("History");

                    b.Navigation("TokenScopes");
                });

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Localizations.LocalizationSet", b =>
                {
                    b.Navigation("Localizations");
                });

            modelBuilder.Entity("Digdir.Domain.Dialogporten.Domain.Outboxes.OutboxMessage", b =>
                {
                    b.Navigation("OutboxMessageConsumers");
                });
#pragma warning restore 612, 618
        }
    }
}
