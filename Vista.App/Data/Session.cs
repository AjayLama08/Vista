﻿using System.ComponentModel.DataAnnotations;

namespace Vista.App.Data
{
    public class Session
    {
        public int SessionId { get; set; }
        public int TrainerId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime SessionDate { get; set; }

        [MaxLength(40)]
        public string? BookingReference { get; set; } //Allows Null

        // Placeholder for a navigation property to trainer (one side of one-to-many)
        public Trainer? Trainer { get; set; }


    }
}
