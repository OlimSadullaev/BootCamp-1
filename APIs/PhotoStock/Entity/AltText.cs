namespace PhotoStock.Entity
{
    public class AltText
    {
        public Guid Id { get; set; }
        public string Text_Name { get; set; }

        public string Text_Title { get; set; }
        
        public DateTimeOffset Datetime { get; set; }

        public string Cost { get; set; }

        public string Author { get; set; }

        public string Number_of_sales { get; set; }

        public string Text_Rating { get; set; }
    }
}
