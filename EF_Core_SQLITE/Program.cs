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
            //prayerItemContext.SaveChanges();

            list.getPrayerItems();


            Console.WriteLine("Enter id to delete");
            string id_to_delete = Console.ReadLine();
            Int32.TryParse(id_to_delete, out int id);

            PrayerItem item1 = list.GetPrayerItem(id);
            Console.WriteLine(item1.ToString());
            list.deletePrayerItem(item1);


        }
    }
}
