using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemberSystem.Infrastructure.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "apply_file",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<long>(type: "bigint", nullable: false),
                    file_path = table.Column<string>(type: "varchar(200)", nullable: false, defaultValue: ""),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_apply_file", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "orgs",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(20)", nullable: false, defaultValue: ""),
                    org_no = table.Column<string>(type: "varchar(20)", nullable: false, defaultValue: ""),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orgs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "syslog",
                columns: table => new
                {
                    SeqNo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    account = table.Column<string>(type: "varchar(30)", nullable: false, defaultValue: ""),
                    ipaddress = table.Column<string>(type: "varchar(15)", nullable: false, defaultValue: ""),
                    login_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(name: "created _at", type: "datetime2", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("seq_no", x => x.SeqNo);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    org_id = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "nvarchar(20)", nullable: false, defaultValue: ""),
                    birthday = table.Column<DateTime>(type: "date", nullable: false),
                    email = table.Column<string>(type: "varchar(200)", nullable: false, defaultValue: ""),
                    account = table.Column<string>(type: "varchar(30)", nullable: false, defaultValue: ""),
                    password = table.Column<string>(type: "char(64)", nullable: false),
                    status = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "apply_file");

            migrationBuilder.DropTable(
                name: "orgs");

            migrationBuilder.DropTable(
                name: "syslog");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
