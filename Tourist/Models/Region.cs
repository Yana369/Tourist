namespace Tourist.Models
{
    public class Region
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhotoURL { get; set; } // Посилання на фотографію області
        public virtual ICollection<Place>? Places { get; set; } // Колекція місць у цій області
    }
}
