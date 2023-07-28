using System.Text.Json.Serialization;
namespace LibraryManager.Models
{
    public class Author
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }

        // Navigation property to the list of Books
        [JsonIgnore]
        public List<Book>? Books { get; set; }
    }
}
