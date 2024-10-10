using System.ComponentModel.DataAnnotations;

namespace Vista.App.Data
{
    public class TrainerCategory
    {
        // Has a composite (compound) key that will be defined TrainersDbConext

        [Required]
        public int TrainerId { get; set; }

        [MaxLength(15)]
        public required string CategoryCode { get; set; }

        // Placeholder a navigation property to Trainer (one side of one-to-many)
        public Trainer? Trainer { get; set; }

        // See TrainersDbConext for Foreign Key (Fluent API) definition 

        // Placeholder for a navigation property to Category (one side of one-to-many)
        public Category? Category { get; set; }
    }
}
