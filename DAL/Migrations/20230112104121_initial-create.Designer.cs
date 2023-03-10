// <auto-generated />
using System;
using DAL.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230112104121_initial-create")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EL.Entities.Firma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirmaAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OnayDurumu")
                        .HasColumnType("bit");

                    b.Property<DateTime>("SiparisIzinBaslangicSaati")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SiparisIzinBitisSaati")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Firmalar");
                });

            modelBuilder.Entity("EL.Entities.Siparis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("FirmaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SiparisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("SiparisiVerenMusteriAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FirmaId");

                    b.HasIndex("UrunId");

                    b.ToTable("Siparisler");
                });

            modelBuilder.Entity("EL.Entities.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("FirmaId")
                        .HasColumnType("int");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stok")
                        .HasColumnType("int");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FirmaId");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("EL.Entities.Siparis", b =>
                {
                    b.HasOne("EL.Entities.Firma", "Firma")
                        .WithMany("Siparisler")
                        .HasForeignKey("FirmaId");

                    b.HasOne("EL.Entities.Urun", "Urun")
                        .WithMany("Siparisler")
                        .HasForeignKey("UrunId");

                    b.Navigation("Firma");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("EL.Entities.Urun", b =>
                {
                    b.HasOne("EL.Entities.Firma", "Firma")
                        .WithMany("Uruns")
                        .HasForeignKey("FirmaId");

                    b.Navigation("Firma");
                });

            modelBuilder.Entity("EL.Entities.Firma", b =>
                {
                    b.Navigation("Siparisler");

                    b.Navigation("Uruns");
                });

            modelBuilder.Entity("EL.Entities.Urun", b =>
                {
                    b.Navigation("Siparisler");
                });
#pragma warning restore 612, 618
        }
    }
}
