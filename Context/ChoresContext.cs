using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kids_Pocket_money.Entities;
using Kids_Pocket_money.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Kids_Pocket_money.Context
{
    internal class ChoresContext : DbContext
    {
        public ChoresContext()
        {
            //var optionsBuilder = new DbContextOptionsBuilder<GarageContext>();
            //optionsBuilder.UseSqlServer(_connectionString);

            //ChoresList = new List<ChoreEntity>
            //{
            //    new ChoreEntity("taking_out_the_trash",1),
            //    new ChoreEntity("cleaning_windows",4),
            //    new ChoreEntity("cleaning_mirrors",2),
            //    new ChoreEntity("washing_floor",10),
            //    new ChoreEntity("washing_car",7),
            //    new ChoreEntity("vacuuming_car",7),
            //    new ChoreEntity("cleaning_room",4),
            //    new ChoreEntity("making_bed",2),
            //    new ChoreEntity("vacuuming_Yard",4),
            //    new ChoreEntity("cleaning_yard",4),
            //    new ChoreEntity("fold_laundry ",4),
            //    new ChoreEntity("hang_laundry",3),
            //    new ChoreEntity("take_off_laundry",2),
            //    new ChoreEntity("washing_dishes",4),
            //    new ChoreEntity("cleaning_counter",2),
            //    new ChoreEntity("drying_dishes",3),

            //};
        }

        public ChoresContext(DbContextOptions<ChoresContext> options) : base(options)
        {
            //_connectionString = @"Data Source=DESKTOP-I9GEGTE\MSSQLSERVER1;Initial Catalog=LocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        }

        public DbSet<ChoreEntity> Chores { get; set; }
        public DbSet<ChildEntity> Children { get; set; }

        //public List<ChoreEntity> ChoresList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)

            //var _connectionString = @"Data Source=DESKTOP-I9GEGTE\MSSQLSERVER1;Initial Catalog=GarageDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            //var _connectionString = "";
            //optionsBuilder.UseSqlServer(_connectionString);
            
            // THE ONLY DIFFERENCE BETWEEN SQLLITE & SQLSERVER
            // JUST VERIFY SCHEMA WITH UPDATING ALL RELEVANT MIGRATIONS
            var _connectionString = @"Data Source=DESKTOP-6TQMGKV\SQLEXPRESS;Initial Catalog=ChoresDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            optionsBuilder.UseSqlServer(_connectionString);

            //optionsBuilder.UseSqlite(@"\Data Source=\C:\Users\hadady\Documents\1.5.1 - Gamla\ATE.db\;Version=3;\;");
            //optionsBuilder.UseSqlite(@"\Data Source=\C:\c# course\DB's\ATE.db\;Version=3;\;");
            //optionsBuilder.UseSqlite(@"Data Source=C:\c# course\DBs\KidsMoney.db;");

            /// *** ONLY USE WHEN SURE THAT MANUAL CHANGES TO MIGRATIONS (UP & DOWN METHODS) ARE VALID!!!! ***
            //optionsBuilder.ConfigureWarnings(w => w.Ignore(RelationalEventId.PendingModelChangesWarning));

            //base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ChoreEntity>().HasData(
            //    new ChoreEntity(1, "taking_out_the_trash", 1),
            //    new ChoreEntity(2, "cleaning_windows", 4),
            //    new ChoreEntity(3, "cleaning_mirrors", 2),
            //    new ChoreEntity(4, "washing_floor", 10),
            //    new ChoreEntity(5, "washing_car", 7),
            //    new ChoreEntity(6, "vacuuming_car", 7),
            //    new ChoreEntity(7, "cleaning_room", 4),
            //    new ChoreEntity(8, "making_bed", 2),
            //    new ChoreEntity(9, "vacuuming_Yard", 4),
            //    new ChoreEntity(10, "cleaning_yard", 4),
            //    new ChoreEntity(11, "fold_laundry", 4),
            //    new ChoreEntity(12, "hang_laundry", 3),
            //    new ChoreEntity(13, "take_off_laundry", 2),
            //    new ChoreEntity(14, "washing_dishes", 4),
            //    new ChoreEntity(15, "cleaning_counter", 2),
            //    new ChoreEntity(16, "drying_dishes", 3)
            //);

            //modelBuilder.Entity<ChildEntity>().HasData(
            //    new ChildEntity(1, "Yiska", 15),
            //    new ChildEntity(2, "Moriya", 13),
            //    new ChildEntity(3, "Ariel", 11),
            //    new ChildEntity(4, "Yoav", 4)
            //    );

            base.OnModelCreating(modelBuilder);
        }
    }
}
