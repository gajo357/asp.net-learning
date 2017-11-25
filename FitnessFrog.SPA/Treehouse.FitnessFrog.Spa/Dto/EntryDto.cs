using System;
using System.ComponentModel.DataAnnotations;
using Treehouse.FitnessFrog.Shared.Models;
using static Treehouse.FitnessFrog.Shared.Models.Entry;

namespace Treehouse.FitnessFrog.Spa.Dto
{
    public class EntryDto
    {
        public int Id { get; set; }

        [Required]
        public DateTime? Date { get; set; }

        [Required]
        public int? ActivityId { get; set; }

        [Required]
        [Range(0.01, 1000)]
        public decimal? Duration { get; set; }

        [Required]
        public IntensityLevel? Intensity { get; set; }

        public bool Exclude { get; set; }

        [MaxLength(200, ErrorMessage = "The Notes field cannot be longer than 200 characters.")]
        public string Notes { get; set; }


        public Entry ToModel()
        {
            return new Entry
            {
                Id = Id,
                Date = Date.Value,
                ActivityId = ActivityId.Value,
                Duration = Duration.Value,
                Intensity = Intensity.Value,
                Exclude = Exclude,
                Notes = Notes
            };
        }
    }
}