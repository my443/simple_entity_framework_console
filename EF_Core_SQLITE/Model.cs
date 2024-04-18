using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace EF_Core_SQLITE
{
    public class PrayerItemContext: DbContext
    {
        public DbSet<PrayerItem> PrayerItems { get; set; }
        public string DbPath { get; }
        
        public PrayerItemContext() { 
            DbPath = @"c:\temp\mydb.db";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite($"Data Source={DbPath}");
    }
}
