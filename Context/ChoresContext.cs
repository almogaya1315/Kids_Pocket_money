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
        }

        public ChoresContext(DbContextOptions<ChoresContext> options) : base(options)
        {
            //_connectionString = @"Data Source=DESKTOP-I9GEGTE\MSSQLSERVER1;Initial Catalog=LocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        }

        public DbSet<ChoresEntity> Chores { get; set; }

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
