﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorServerCRUDExample.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Products",
            //    columns: table => new
            //    {
            //        ID = table.Column<Guid>(nullable: false),
            //        Name = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Products", x => x.ID);
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Products");
        }
    }
}
