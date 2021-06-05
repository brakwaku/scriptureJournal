﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace RazorPagesScripture.Migrations
{
    [DbContext(typeof(RazorPagesScriptureContext))]
    partial class RazorPagesScriptureContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("RazorPagesScripture.Models.Scripture", b =>
                {
                    b.Property<int>("ScriptureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateEntered")
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .HasColumnType("TEXT");

                    b.Property<string>("ScriptureRef")
                        .HasColumnType("TEXT");

                    b.HasKey("ScriptureID");

                    b.ToTable("Scripture");
                });
#pragma warning restore 612, 618
        }
    }
}
