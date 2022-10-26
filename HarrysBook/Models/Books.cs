namespace HarrysBook.Models
{
    public class Book
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public decimal price { get; set; }
        public Currency currencyType { get; set; }
    }
}