using System.ComponentModel.DataAnnotations;

namespace Vista.App.Data
{
    public class Trainer
    {
        public int TrainerId { get; set; }

        [MaxLength(50)]
        public required string Name { get; set; }
        [MaxLength(50)]
        public string? Location { get; set; } // The question mark allow nulls
        // Placeholder for List of Trainer Categories (many side of one-to-many)
        // Placeholder for List of Sessions (many side of one-to-many)


    }
}
