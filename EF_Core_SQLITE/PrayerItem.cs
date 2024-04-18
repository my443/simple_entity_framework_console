namespace EF_Core_SQLITE
{
    public class PrayerItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsHistory { get; set; }

        override public string ToString() {
            return $"{Id} - {Name} - {Description} - {CreateDate} - {IsHistory}";
        }
    }
}
