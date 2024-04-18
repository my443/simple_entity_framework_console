using Microsoft.EntityFrameworkCore;

namespace EF_Core_SQLITE
{
    public class PrayerItemList
    {
        private PrayerItemContext _dbContext;
        public PrayerItemList(PrayerItemContext dbContext) { 
             _dbContext = dbContext;
        }

        public void addPrayerItem(PrayerItem prayerItem) { 
            _dbContext.Add(prayerItem);
        }

        public void getPrayerItems()
        {
            var list = _dbContext.PrayerItems.ToList();

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Description} - {item.CreateDate} - {item.IsHistory}");
            }

        }
    }
}
