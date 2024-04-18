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
            _dbContext.SaveChanges();
        }

        public void deletePrayerItem(PrayerItem prayerItem)
        {
            _dbContext.Remove(prayerItem);
            _dbContext.SaveChanges();
        }

        public PrayerItem GetPrayerItem(int id)
        {
            PrayerItem prayerItem = _dbContext.PrayerItems.Find(id);
            return prayerItem;
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
