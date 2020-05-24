using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FlightJournal.Web.Translations;
using System.Linq;

namespace FlightJournal.Web.Models
{
    public class TrainingLesson
    {
        [Key]
        public int TrainingLessonId { get; set; }

        public int TrainingLessonCategoryId { get; set; }
        public virtual TrainingLessonCategory TrainingLessonCategory { get; set; }

        [LocalizedDisplayName("Lesson identifier")]
        public string Identifier { get; set; }

        [LocalizedDisplayName("Lesson description")]
        public string Description { get; set; }

        public virtual ICollection<FlyingExercise> FlyingExercises { get; set; }
        public virtual ICollection<NonFlyingExercise> NonFlyingExercises { get; set; }

        [LocalizedDisplayName("Requires flight")]
        public bool RequiresFlight { get; set; } = true;

        [LocalizedDisplayName("Requires flight instructor approval")]
        public bool RequiresFlightInstructorApproval { get; set; } = true;

        [LocalizedDisplayName("Enabled")]
        public bool Enabled { get; set; } = true;

        [LocalizedDisplayName("Sort order")]
        public int SortOrder { get; set; }

        [LocalizedDisplayName("In progress")]
        public bool InProgress
        {
            get
            {
                return !Completed
                    && (FlyingExercises.Any(e => e.Trained || e.Completed) || NonFlyingExercises.Any(e => e.Completed));
            }
        }

        [LocalizedDisplayName("Completed")]
        public bool Completed
        {
            get
            {
                return FlyingExercises.All(e => e.Completed) && NonFlyingExercises.All(e => e.Completed);
            }
        }
    }
}