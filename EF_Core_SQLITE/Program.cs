using EF_Core_SQLITE;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;

namespace PrayerJournal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrayerItem item = new PrayerItem { IsHistory = true, Name = "Pray for success of this project", Description="Success", CreateDate = DateTime.Now            
            };
            PrayerItemContext prayerItemContext = new PrayerItemContext();
            PrayerItemList list = new PrayerItemList(prayerItemContext);
            list.addPrayerItem(item);
            prayerItemContext.SaveChanges();


            list.getPrayerItems();

        }
    }
}
