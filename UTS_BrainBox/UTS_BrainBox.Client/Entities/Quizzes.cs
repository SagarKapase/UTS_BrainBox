namespace UTS_BrainBox.Client.Entities
{
    public class Quizzes
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Questions { get; set; }
        public string Attempts { get; set; }
        public string Actions { get; set; }
    }
}
