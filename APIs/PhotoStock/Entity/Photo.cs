using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhotoStock.Entity
{
    public class Photo
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Link { get; set; }

        public string Original_Size { get; set; }

        public DateTimeOffset Date_Of_Creation { get; set; }

        public string Author { get; set; }

        public string Cost { get; set; }

        public string Num_of_Sales { get; set; }

        public string Photo_Rating { get; set; }
    }   
}
