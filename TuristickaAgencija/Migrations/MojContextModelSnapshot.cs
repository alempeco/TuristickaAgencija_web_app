﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TuristickaAgencija.EF;

namespace TuristickaAgencija.Migrations
{
    [DbContext(typeof(MojContext))]
    partial class MojContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("TuristickaAgencija.EntityModels.AutorizacijskiToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("IpAdresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KorisnickiNaloziId")
                        .HasColumnType("int");

                    b.Property<string>("Vrijednost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VrijemeEvidentiranja")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("KorisnickiNaloziId");

                    b.ToTable("AutorizacijskiToken");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.Drzava", b =>
                {
                    b.Property<int>("DrzavaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DrzavaId");

                    b.ToTable("Drzava");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.Firma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojZiroracuna")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GradID");

                    b.ToTable("Firma");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.Gradovi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("DrzavaId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("NazivGrada")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DrzavaId");

                    b.ToTable("Gradovi");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.KorisnickiNalozi", b =>
                {
                    b.Property<int>("KorisnickiNalogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("KorisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lozinka")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KorisnickiNalogId");

                    b.ToTable("KorisnickiNalozi");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JMBG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kontakt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GradID");

                    b.ToTable("Klijent");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.Obavijesti", b =>
                {
                    b.Property<int>("ObavijestiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sadrzaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("ObavijestiId");

                    b.ToTable("Obavijesti");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.Prevoz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BrojMjesta")
                        .HasColumnType("int");

                    b.Property<float>("CijenaPoMjestu")
                        .HasColumnType("real");

                    b.Property<int?>("FirmaID")
                        .HasColumnType("int");

                    b.Property<string>("TipPrevoza")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FirmaID");

                    b.ToTable("Prevoz");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.PutnikKorisnik", b =>
                {
                    b.Property<int>("PutnikKorisnikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("KorisnickiNalogId")
                        .HasColumnType("int");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.HasKey("PutnikKorisnikId");

                    b.HasIndex("KorisnickiNalogId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("PutnikKorisnik");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.Putovanja", b =>
                {
                    b.Property<int>("PutovanjaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BrojPutnika")
                        .HasColumnType("int");

                    b.Property<float>("CijenaPutovanja")
                        .HasColumnType("real");

                    b.Property<DateTime>("DatumDolaska")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumPolaska")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Dodatak")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("DodatakNaziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NazivPutovanja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpisPutovanja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PopisPutnika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PrevozId")
                        .HasColumnType("int");

                    b.Property<int?>("SmjestajId")
                        .HasColumnType("int");

                    b.HasKey("PutovanjaId");

                    b.HasIndex("PrevozId");

                    b.HasIndex("SmjestajId");

                    b.ToTable("Putovanja");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.Smjestaj", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("CijenaNocenja")
                        .HasColumnType("real");

                    b.Property<int?>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("NazivSmjestaja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpisSmjestaja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Tip_sobe")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GradID");

                    b.ToTable("Smjestaj");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.Uplate", b =>
                {
                    b.Property<int>("UplataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DatumUplate")
                        .HasColumnType("datetime2");

                    b.Property<float>("Iznos")
                        .HasColumnType("real");

                    b.Property<int?>("KlijentId")
                        .HasColumnType("int");

                    b.Property<int?>("PutovanjaID")
                        .HasColumnType("int");

                    b.HasKey("UplataId");

                    b.HasIndex("KlijentId");

                    b.HasIndex("PutovanjaID");

                    b.ToTable("Uplate");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.Vodic", b =>
                {
                    b.Property<int>("VodicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JMBG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kontakt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PutovanjaID")
                        .HasColumnType("int");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("VodicId");

                    b.HasIndex("PutovanjaID");

                    b.ToTable("Vodic");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.Zaposlenici", b =>
                {
                    b.Property<int>("ZaposlenikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("KorisnickiNalogId")
                        .HasColumnType("int");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<string>("StrucnaSprema")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ZaposlenikId");

                    b.HasIndex("KorisnickiNalogId");

                    b.HasIndex("KorisnikID");

                    b.ToTable("Zaposlenici");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.AutorizacijskiToken", b =>
                {
                    b.HasOne("TuristickaAgencija.EntityModels.KorisnickiNalozi", "KorisnickiNalozi")
                        .WithMany()
                        .HasForeignKey("KorisnickiNaloziId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KorisnickiNalozi");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.Firma", b =>
                {
                    b.HasOne("TuristickaAgencija.EntityModels.Gradovi", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID");

                    b.Navigation("Grad");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.Gradovi", b =>
                {
                    b.HasOne("TuristickaAgencija.EntityModels.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drzava");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.Korisnik", b =>
                {
                    b.HasOne("TuristickaAgencija.EntityModels.Gradovi", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID");

                    b.Navigation("Grad");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.Prevoz", b =>
                {
                    b.HasOne("TuristickaAgencija.EntityModels.Firma", "Firma")
                        .WithMany()
                        .HasForeignKey("FirmaID");

                    b.Navigation("Firma");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.PutnikKorisnik", b =>
                {
                    b.HasOne("TuristickaAgencija.EntityModels.KorisnickiNalozi", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId");

                    b.HasOne("TuristickaAgencija.EntityModels.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KorisnickiNalog");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.Putovanja", b =>
                {
                    b.HasOne("TuristickaAgencija.EntityModels.Prevoz", "Prevoz")
                        .WithMany()
                        .HasForeignKey("PrevozId");

                    b.HasOne("TuristickaAgencija.EntityModels.Smjestaj", "Smjestaj")
                        .WithMany()
                        .HasForeignKey("SmjestajId");

                    b.Navigation("Prevoz");

                    b.Navigation("Smjestaj");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.Smjestaj", b =>
                {
                    b.HasOne("TuristickaAgencija.EntityModels.Gradovi", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID");

                    b.Navigation("Grad");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.Uplate", b =>
                {
                    b.HasOne("TuristickaAgencija.EntityModels.Korisnik", "Klijent")
                        .WithMany()
                        .HasForeignKey("KlijentId");

                    b.HasOne("TuristickaAgencija.EntityModels.Putovanja", "Putovanja")
                        .WithMany()
                        .HasForeignKey("PutovanjaID");

                    b.Navigation("Klijent");

                    b.Navigation("Putovanja");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.Vodic", b =>
                {
                    b.HasOne("TuristickaAgencija.EntityModels.Putovanja", "Putovanja")
                        .WithMany()
                        .HasForeignKey("PutovanjaID");

                    b.Navigation("Putovanja");
                });

            modelBuilder.Entity("TuristickaAgencija.EntityModels.Zaposlenici", b =>
                {
                    b.HasOne("TuristickaAgencija.EntityModels.KorisnickiNalozi", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId");

                    b.HasOne("TuristickaAgencija.EntityModels.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KorisnickiNalog");

                    b.Navigation("Korisnik");
                });
#pragma warning restore 612, 618
        }
    }
}
