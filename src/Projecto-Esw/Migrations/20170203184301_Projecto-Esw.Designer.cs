using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Projecto_Esw.Data;

namespace ProjectoEsw.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170203184301_Projecto-Esw")]
    partial class ProjectoEsw
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Projecto_Esw.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("Utilizador");
                });

            modelBuilder.Entity("Projecto_Esw.Models.Companhia", b =>
                {
                    b.Property<int>("CompanhiaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("CompanhiaId");

                    b.ToTable("Companhia");
                });

            modelBuilder.Entity("Projecto_Esw.Models.Destino", b =>
                {
                    b.Property<int>("DestinoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("DestinoId");

                    b.ToTable("Destino");
                });

            modelBuilder.Entity("Projecto_Esw.Models.Help", b =>
                {
                    b.Property<int>("HelpId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("HelpId");

                    b.ToTable("Help");
                });

            modelBuilder.Entity("Projecto_Esw.Models.HelpReserva", b =>
                {
                    b.Property<int>("HelpReservaId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("HelpReservaId");

                    b.ToTable("HelpReserva");
                });

            modelBuilder.Entity("Projecto_Esw.Models.Reserva", b =>
                {
                    b.Property<int>("ReservaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanhiaId");

                    b.Property<DateTime>("DataPartida");

                    b.Property<DateTime>("DataRegresso");

                    b.Property<string>("Destino")
                        .IsRequired();

                    b.Property<DateTime>("HoraPartida");

                    b.Property<DateTime>("HoraRegresso");

                    b.Property<int>("NumeroPessoas");

                    b.Property<string>("Origem")
                        .IsRequired();

                    b.Property<int>("TipoJatoId");

                    b.Property<int>("UserId");

                    b.Property<string>("UsersId");

                    b.HasKey("ReservaId");

                    b.HasIndex("CompanhiaId");

                    b.HasIndex("TipoJatoId");

                    b.HasIndex("UsersId");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("Projecto_Esw.Models.ReservaIda", b =>
                {
                    b.Property<int>("ReservaIdaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<int>("CompanhiaId");

                    b.Property<DateTime>("DataPartida");

                    b.Property<string>("Destino")
                        .IsRequired();

                    b.Property<DateTime>("HoraPartida");

                    b.Property<int>("NumeroPessoas");

                    b.Property<string>("Origem")
                        .IsRequired();

                    b.Property<int>("TipoJatoId");

                    b.HasKey("ReservaIdaId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("CompanhiaId");

                    b.HasIndex("TipoJatoId");

                    b.ToTable("ReservaIda");
                });

            modelBuilder.Entity("Projecto_Esw.Models.TipoJato", b =>
                {
                    b.Property<int>("TipoJatoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<double>("Preco");

                    b.HasKey("TipoJatoId");

                    b.ToTable("TipoJato");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Projecto_Esw.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Projecto_Esw.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Projecto_Esw.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Projecto_Esw.Models.Reserva", b =>
                {
                    b.HasOne("Projecto_Esw.Models.Companhia", "Companhia")
                        .WithMany()
                        .HasForeignKey("CompanhiaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Projecto_Esw.Models.TipoJato", "TipoJato")
                        .WithMany()
                        .HasForeignKey("TipoJatoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Projecto_Esw.Models.ApplicationUser", "Users")
                        .WithMany("Reservas")
                        .HasForeignKey("UsersId");
                });

            modelBuilder.Entity("Projecto_Esw.Models.ReservaIda", b =>
                {
                    b.HasOne("Projecto_Esw.Models.ApplicationUser")
                        .WithMany("Reserva")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("Projecto_Esw.Models.Companhia", "Companhia")
                        .WithMany()
                        .HasForeignKey("CompanhiaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Projecto_Esw.Models.TipoJato", "TipoJato")
                        .WithMany()
                        .HasForeignKey("TipoJatoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
