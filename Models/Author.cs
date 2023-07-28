using System.Text.Json.Serialization;
namespace LibraryManager.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public ICollection<Book>? Books { get; set; }
    }
}
