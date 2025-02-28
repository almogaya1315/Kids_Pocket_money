using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kids_Pocket_money.Entities;

namespace Kids_Pocket_money.Context
{
    internal class ChoresContext : DbContext
    {

       

        public ChoresContext()
        {
            //var optionsBuilder = new DbContextOptionsBuilder<GarageContext>();
            //optionsBuilder.UseSqlServer(_connectionString);

            ChoresList = new List<ChoreEntity>
            {
                new ChoreEntity("taking_out_the_trash",1),
                new ChoreEntity("cleaning_windows",4),
                new ChoreEntity("cleaning_mirrors",2),
                new ChoreEntity("washing_floor",10),
                new ChoreEntity("washing_car",7),
                new ChoreEntity("vacuuming_car",7),
                new ChoreEntity("cleaning_room",4),
                new ChoreEntity("making_bed",2),
                new ChoreEntity("vacuuming_Yard",4),
                new ChoreEntity("cleaning_yard",4),
                new ChoreEntity("fold_laundry ",4),
                new ChoreEntity("hang_laundry",3),
                new ChoreEntity("take_off_laundry",2),
                new ChoreEntity("washing_dishes",4),
                new ChoreEntity("cleaning_counter",2),
                new ChoreEntity("drying_dishes",3),

            };
        }

        public ChoresContext(DbContextOptions<ChoresContext> options) : base(options)
        {
            //_connectionString = @"Data Source=DESKTOP-I9GEGTE\MSSQLSERVER1;Initial Catalog=LocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        }

        public DbSet<ChoreEntity> Chores { get; set; }
        public List<ChoreEntity> ChoresList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)

            //  var _connectionString = @"Data Source=DESKTOP-I9GEGTE\MSSQLSERVER1;Initial Catalog=GarageDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            //var _connectionString = "";
            //optionsBuilder.UseSqlServer(_connectionString);

          //  optionsBuilder.UseSqlite(@"\Data Source=\C:\Users\hadady\Documents\1.5.1 - Gamla\ATE.db\;Version=3;\;");
            //optionsBuilder.UseSqlite(@"\Data Source=\C:\c# course\DB's\ATE.db\;Version=3;\;");
            optionsBuilder.UseSqlite(@"Data Source=C:\c# course\DBs\KidsMoney.db;");
            



            //base.OnConfiguring(optionsBuilder);
        }




        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
