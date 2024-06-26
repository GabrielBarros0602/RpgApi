﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RpgApi.Data;

#nullable disable

namespace RpgAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240417003400_MigracaoUsuario")]
    partial class MigracaoUsuario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RpgAPI.Models.Arma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Dano")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("TB_ARMAS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Dano = 50,
                            Nome = "Espada"
                        },
                        new
                        {
                            Id = 2,
                            Dano = 25,
                            Nome = "Adaga"
                        },
                        new
                        {
                            Id = 3,
                            Dano = 5,
                            Nome = "Escudo"
                        },
                        new
                        {
                            Id = 4,
                            Dano = 35,
                            Nome = "Clava"
                        },
                        new
                        {
                            Id = 5,
                            Dano = 1000,
                            Nome = "Estrelança da Aurora Dracônica!!!!!!"
                        },
                        new
                        {
                            Id = 6,
                            Dano = 60,
                            Nome = "Machado"
                        },
                        new
                        {
                            Id = 7,
                            Dano = 30,
                            Nome = "Arco"
                        });
                });

            modelBuilder.Entity("RpgAPI.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataAcesso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.Property<byte[]>("Foto")
                        .HasColumnType("varbinary(max)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Perfil")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200)
                        .HasColumnType("varchar")
                        .HasDefaultValue("Jogador");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("TB_USUARIOS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "seuEmail@gmail.com",
                            Latitude = -23.520024100000001,
                            Longitude = -46.596497999999997,
                            PasswordHash = new byte[] { 10, 27, 25, 215, 225, 18, 86, 166, 230, 216, 28, 229, 217, 178, 49, 166, 55, 217, 174, 116, 143, 183, 224, 83, 157, 38, 203, 1, 28, 207, 230, 57, 57, 170, 165, 81, 174, 78, 68, 0, 131, 167, 249, 39, 248, 88, 250, 158, 216, 161, 167, 201, 228, 187, 44, 72, 2, 211, 79, 37, 52, 44, 181, 185 },
                            PasswordSalt = new byte[] { 76, 207, 227, 173, 233, 20, 138, 60, 43, 76, 226, 178, 49, 129, 127, 44, 127, 194, 8, 230, 93, 207, 30, 206, 127, 162, 85, 254, 86, 184, 0, 128, 52, 224, 11, 174, 108, 229, 225, 134, 6, 158, 77, 161, 206, 54, 38, 11, 184, 107, 97, 56, 88, 67, 220, 154, 183, 163, 59, 215, 207, 217, 247, 236, 242, 178, 253, 166, 173, 75, 69, 213, 130, 254, 63, 132, 177, 108, 115, 201, 187, 63, 23, 158, 235, 10, 3, 196, 128, 134, 224, 201, 145, 234, 42, 56, 184, 104, 98, 53, 58, 118, 62, 178, 59, 34, 12, 105, 208, 245, 75, 10, 98, 236, 226, 129, 193, 165, 96, 71, 76, 22, 39, 159, 148, 21, 104, 246 },
                            Perfil = "Admin",
                            Username = "UsuarioAdmin"
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Personagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Classe")
                        .HasColumnType("int");

                    b.Property<int>("Defesa")
                        .HasColumnType("int");

                    b.Property<int>("Forca")
                        .HasColumnType("int");

                    b.Property<byte[]>("FotoPersonagem")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Inteligencia")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.Property<int>("PontosVida")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("TB_PERSONAGENS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Classe = 1,
                            Defesa = 23,
                            Forca = 17,
                            Inteligencia = 33,
                            Nome = "Frodo",
                            PontosVida = 100,
                            UsuarioId = 1
                        },
                        new
                        {
                            Id = 2,
                            Classe = 1,
                            Defesa = 25,
                            Forca = 15,
                            Inteligencia = 30,
                            Nome = "Sam",
                            PontosVida = 100,
                            UsuarioId = 1
                        },
                        new
                        {
                            Id = 3,
                            Classe = 3,
                            Defesa = 21,
                            Forca = 18,
                            Inteligencia = 35,
                            Nome = "Galadriel",
                            PontosVida = 100,
                            UsuarioId = 1
                        },
                        new
                        {
                            Id = 4,
                            Classe = 2,
                            Defesa = 18,
                            Forca = 18,
                            Inteligencia = 37,
                            Nome = "Gandalf",
                            PontosVida = 100,
                            UsuarioId = 1
                        },
                        new
                        {
                            Id = 5,
                            Classe = 1,
                            Defesa = 17,
                            Forca = 20,
                            Inteligencia = 31,
                            Nome = "Hobbit",
                            PontosVida = 100,
                            UsuarioId = 1
                        },
                        new
                        {
                            Id = 6,
                            Classe = 3,
                            Defesa = 13,
                            Forca = 21,
                            Inteligencia = 34,
                            Nome = "Celeborn",
                            PontosVida = 100,
                            UsuarioId = 1
                        },
                        new
                        {
                            Id = 7,
                            Classe = 2,
                            Defesa = 11,
                            Forca = 25,
                            Inteligencia = 35,
                            Nome = "Radagast",
                            PontosVida = 100,
                            UsuarioId = 1
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Personagem", b =>
                {
                    b.HasOne("RpgAPI.Models.Usuario", "Usuario")
                        .WithMany("Personagens")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("RpgAPI.Models.Usuario", b =>
                {
                    b.Navigation("Personagens");
                });
#pragma warning restore 612, 618
        }
    }
}
