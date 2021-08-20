using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace PFKProductionViewer.Models
{
    public partial class LatheContext : DbContext
    {
        private string _connectionString { get; }
        public LatheContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public LatheContext(DbContextOptions<LatheContext> options)
            : base(options)
        {
        }

        public static List<BinsActual> GetAllBins(string connectionString)
        {
            using (var context = new LatheContext(connectionString))
            {
                return context.BinsActuals.ToList();
            }
        }

        public static List<ShiftActual> GetAllShiftsActual(string connectionString)
        {
            using (var context = new LatheContext(connectionString))
            {
                return context.ShiftActuals.ToList();
            }
        }

        public static List<ShiftPreviou> GetAllShiftsPrevious(string connectionString)
        {
            using (var context = new LatheContext(connectionString))
            {
                return context.ShiftPrevious.ToList();
            }
        }


        public virtual DbSet<BinsActual> BinsActuals { get; set; }
        public virtual DbSet<ShiftActual> ShiftActuals { get; set; }
        public virtual DbSet<ShiftPreviou> ShiftPrevious { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<BinsActual>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bins_Actual");

                entity.Property(e => e.Bin1Sheets).HasColumnName("BIN1_Sheets");

                entity.Property(e => e.Bin1Volume).HasColumnName("BIN1_Volume");

                entity.Property(e => e.Bin2Sheets).HasColumnName("BIN2_Sheets");

                entity.Property(e => e.Bin2Volume).HasColumnName("BIN2_Volume");

                entity.Property(e => e.Bin3Sheets).HasColumnName("BIN3_Sheets");

                entity.Property(e => e.Bin3Volume).HasColumnName("BIN3_Volume");
            });

            modelBuilder.Entity<ShiftActual>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Shift_Actual");

                entity.Property(e => e.ColBlock).HasColumnName("col_block");

                entity.Property(e => e.CollPack11).HasColumnName("coll_pack11");

                entity.Property(e => e.CollPack12).HasColumnName("coll_pack12");

                entity.Property(e => e.CollPack13).HasColumnName("coll_pack13");

                entity.Property(e => e.CollPack21).HasColumnName("coll_pack21");

                entity.Property(e => e.CollPack22).HasColumnName("coll_pack22");

                entity.Property(e => e.CollPack23).HasColumnName("coll_pack23");

                entity.Property(e => e.LossCil).HasColumnName("loss_cil");

                entity.Property(e => e.LossCore).HasColumnName("loss_core");

                entity.Property(e => e.MediumDBlock).HasColumnName("medium_D_block");

                entity.Property(e => e.MediumDCore).HasColumnName("medium_D_core");

                entity.Property(e => e.OveralCollList).HasColumnName("overal_coll_list");

                entity.Property(e => e.OveralCollList1).HasColumnName("overal_coll_list1");

                entity.Property(e => e.OveralCollList11).HasColumnName("overal_coll_list11");

                entity.Property(e => e.OveralCollList12).HasColumnName("overal_coll_list12");

                entity.Property(e => e.OveralCollList13).HasColumnName("overal_coll_list13");

                entity.Property(e => e.OveralCollList2).HasColumnName("overal_coll_list2");

                entity.Property(e => e.OveralCollList21).HasColumnName("overal_coll_list21");

                entity.Property(e => e.OveralCollList22).HasColumnName("overal_coll_list22");

                entity.Property(e => e.OveralCollList23).HasColumnName("overal_coll_list23");

                entity.Property(e => e.OveralVList).HasColumnName("overal_V_list");

                entity.Property(e => e.OveralVList1).HasColumnName("overal_V_list1");

                entity.Property(e => e.OveralVList11).HasColumnName("overal_V_list11");

                entity.Property(e => e.OveralVList12).HasColumnName("overal_V_list12");

                entity.Property(e => e.OveralVList13).HasColumnName("overal_V_list13");

                entity.Property(e => e.OveralVList2).HasColumnName("overal_V_list2");

                entity.Property(e => e.OveralVList21).HasColumnName("overal_V_list21");

                entity.Property(e => e.OveralVList22).HasColumnName("overal_V_list22");

                entity.Property(e => e.OveralVList23).HasColumnName("overal_V_list23");

                entity.Property(e => e.PercentLossVeneer).HasColumnName("Percent_loss_veneer");

                entity.Property(e => e.Rate1).HasColumnName("rate1");

                entity.Property(e => e.Rate2).HasColumnName("rate2");

                entity.Property(e => e.RateMedium).HasColumnName("rate_medium");

                entity.Property(e => e.Smena).HasColumnName("smena");

                entity.Property(e => e.VBlock).HasColumnName("V_block");

                entity.Property(e => e.VCil).HasColumnName("V_cil");

                entity.Property(e => e.VCore).HasColumnName("V_core");
            });

            modelBuilder.Entity<ShiftPreviou>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Shift_Previous");

                entity.Property(e => e.ColBlock).HasColumnName("col_block");

                entity.Property(e => e.CollPack11).HasColumnName("coll_pack11");

                entity.Property(e => e.CollPack12).HasColumnName("coll_pack12");

                entity.Property(e => e.CollPack13).HasColumnName("coll_pack13");

                entity.Property(e => e.CollPack21).HasColumnName("coll_pack21");

                entity.Property(e => e.CollPack22).HasColumnName("coll_pack22");

                entity.Property(e => e.CollPack23).HasColumnName("coll_pack23");

                entity.Property(e => e.LossCil).HasColumnName("loss_cil");

                entity.Property(e => e.LossCore).HasColumnName("loss_core");

                entity.Property(e => e.MediumDBlock).HasColumnName("medium_D_block");

                entity.Property(e => e.MediumDCore).HasColumnName("medium_D_core");

                entity.Property(e => e.OveralCollList).HasColumnName("overal_coll_list");

                entity.Property(e => e.OveralCollList1).HasColumnName("overal_coll_list1");

                entity.Property(e => e.OveralCollList11).HasColumnName("overal_coll_list11");

                entity.Property(e => e.OveralCollList12).HasColumnName("overal_coll_list12");

                entity.Property(e => e.OveralCollList13).HasColumnName("overal_coll_list13");

                entity.Property(e => e.OveralCollList2).HasColumnName("overal_coll_list2");

                entity.Property(e => e.OveralCollList21).HasColumnName("overal_coll_list21");

                entity.Property(e => e.OveralCollList22).HasColumnName("overal_coll_list22");

                entity.Property(e => e.OveralCollList23).HasColumnName("overal_coll_list23");

                entity.Property(e => e.OveralVList).HasColumnName("overal_V_list");

                entity.Property(e => e.OveralVList1).HasColumnName("overal_V_list1");

                entity.Property(e => e.OveralVList11).HasColumnName("overal_V_list11");

                entity.Property(e => e.OveralVList12).HasColumnName("overal_V_list12");

                entity.Property(e => e.OveralVList13).HasColumnName("overal_V_list13");

                entity.Property(e => e.OveralVList2).HasColumnName("overal_V_list2");

                entity.Property(e => e.OveralVList21).HasColumnName("overal_V_list21");

                entity.Property(e => e.OveralVList22).HasColumnName("overal_V_list22");

                entity.Property(e => e.OveralVList23).HasColumnName("overal_V_list23");

                entity.Property(e => e.PercentLossVeneer).HasColumnName("Percent_loss_veneer");

                entity.Property(e => e.Rate1).HasColumnName("rate1");

                entity.Property(e => e.Rate2).HasColumnName("rate2");

                entity.Property(e => e.RateMedium).HasColumnName("rate_medium");

                entity.Property(e => e.VBlock).HasColumnName("V_block");

                entity.Property(e => e.VCil).HasColumnName("V_cil");

                entity.Property(e => e.VCore).HasColumnName("V_core");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
