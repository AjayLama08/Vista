using System.ComponentModel.DataAnnotations;

namespace Vista.App.Data
{
    public class Category
    {
        [Key] // Since the key name (CategoryCode) does not include
              // "Id", we have to use an annotation (could also
              // specify this using FluitAPI)
        [MaxLength(15)] 

        public required string CategoryName { get; set; }

        // Placeholder for List of Trainer Categories (many side of one-to-many)
        public List<TrainerCategory>? TrainerCategories { get; set; }
    }
}
