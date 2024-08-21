namespace examenItChallenges.models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Players { get; set; } = new List<string>();
        public string Duration { get; set; }
        public string Difficulty { get; set; }
        public List<string> Reviews { get; set; } = new List<string>();
    }
}