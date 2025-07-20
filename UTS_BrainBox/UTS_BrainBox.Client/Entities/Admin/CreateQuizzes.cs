using System.ComponentModel.DataAnnotations;

namespace UTS_BrainBox.Client.Entities.Admin
{
    public class CreateQuizzes
    {
        [Key]
        public int QuizID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public string Questions { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Attempts { get; set; } = string.Empty;
    }
}
