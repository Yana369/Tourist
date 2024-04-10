namespace Tourist.Models
{
    public class Place
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhotoURL { get; set; } // Посилання на фотографію місця
        public int RegionID { get; set; } // Зовнішній ключ для зв'язку з областю
        public  Region? Region { get; set; } // Об'єкт області, до якої належить місце
    }
}
