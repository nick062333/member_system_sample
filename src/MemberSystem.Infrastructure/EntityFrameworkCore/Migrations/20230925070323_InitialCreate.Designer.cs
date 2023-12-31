﻿// <auto-generated />
using System;
using MemberSystem.Infrastructure.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MemberSystem.Infrastructure.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(MemberContext))]
    [Migration("20230925070323_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MemberSystem.Domain.AggregatesModel.OrgAggregate.Org", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("OrgNo")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(20)")
                        .HasDefaultValue("")
                        .HasColumnName("org_no");

                    b.Property<string>("Title")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(20)")
                        .HasDefaultValue("")
                        .HasColumnName("title");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("orgs", (string)null);
                });

            modelBuilder.Entity("MemberSystem.Domain.AggregatesModel.UserAggregate.ApplyFile", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(200)")
                        .HasDefaultValue("")
                        .HasColumnName("file_path");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.ToTable("apply_file", (string)null);
                });

            modelBuilder.Entity("MemberSystem.Domain.AggregatesModel.UserAggregate.SysLog", b =>
                {
                    b.Property<long>("SeqNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("SeqNo"));

                    b.Property<string>("Account")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(30)")
                        .HasDefaultValue("")
                        .HasColumnName("account");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("created _at");

                    b.Property<string>("IPAddress")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(15)")
                        .HasDefaultValue("")
                        .HasColumnName("ipaddress");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("LoginTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("login_at");

                    b.HasKey("SeqNo")
                        .HasName("seq_no");

                    b.ToTable("syslog", (string)null);
                });

            modelBuilder.Entity("MemberSystem.Domain.AggregatesModel.UserAggregate.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Account")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(30)")
                        .HasDefaultValue("")
                        .HasColumnName("account");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("date")
                        .HasColumnName("birthday");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(200)")
                        .HasDefaultValue("")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(20)")
                        .HasDefaultValue("")
                        .HasColumnName("name");

                    b.Property<long>("OrgId")
                        .HasColumnType("bigint")
                        .HasColumnName("org_id");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("char(64)")
                        .HasColumnName("password");

                    b.Property<long>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValue(0L)
                        .HasColumnName("status");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("users", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
