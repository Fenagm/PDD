using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TP_Parcial.Migrations
{
    public partial class version2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Usuario",
                table: "Usuario",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Clave",
                table: "Usuario",
                type: "varchar(50)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "vencimiento",
                table: "Tareas",
                type: "DateTime",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "titulo",
                table: "Tareas",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "recursosId",
                table: "Tareas",
                type: "int",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "estimacion",
                table: "Tareas",
                type: "int",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "estado",
                table: "Tareas",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuariosId",
                table: "Recursos",
                type: "int",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Recursos",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Recursos",
                type: "int",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true)
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "tiempo",
                table: "Detalles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "tareasId",
                table: "Detalles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "recursosId",
                table: "Detalles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha",
                table: "Detalles",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Usuario",
                table: "Usuario",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Clave",
                table: "Usuario",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<DateTime>(
                name: "vencimiento",
                table: "Tareas",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "titulo",
                table: "Tareas",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "recursosId",
                table: "Tareas",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "estimacion",
                table: "Tareas",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "estado",
                table: "Tareas",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "UsuariosId",
                table: "Recursos",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Recursos",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Recursos",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 100)
                .Annotation("Sqlite:Autoincrement", true)
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "tiempo",
                table: "Detalles",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "tareasId",
                table: "Detalles",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "recursosId",
                table: "Detalles",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha",
                table: "Detalles",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");
        }
    }
}
