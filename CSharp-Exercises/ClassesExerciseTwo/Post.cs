namespace ClassesExerciseTwo
{
    internal class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public int Votes { get; private set; } = 0;

        public void UpVoting()
        {
            Votes++;
        }

        public void DownVoting()
        {
            Votes--;
        }
    }
}
