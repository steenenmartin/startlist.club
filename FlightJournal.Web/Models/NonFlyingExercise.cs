using System.ComponentModel.DataAnnotations;
using FlightJournal.Web.Translations;

namespace FlightJournal.Web.Models
{
    public class NonFlyingExercise
    {
        [Key]
        public int ExerciseId { get; set; }

        public int TrainingLessonId { get; set; }
        public virtual TrainingLesson TrainingLesson { get; set; }

        [LocalizedDisplayName("Exercise description")]
        public string Description { get; set; }

        [LocalizedDisplayName("Enabled")]
        public bool Enabled { get; set; } = true;

        [LocalizedDisplayName("Sort order")]
        public int SortOrder { get; set; }

        [LocalizedDisplayName("Completed")]
        public bool Completed { get; set; } = false;
    }
}