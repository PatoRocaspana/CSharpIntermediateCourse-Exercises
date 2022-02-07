using ClassesExerciseTwo;

var post = new Post
{
    CreationDate = DateTime.Today,
    Title = "This is a title",
    Description = "This is the content."
};

Console.WriteLine($"Votes at the beginning: {post.Votes}");

post.DownVoting();
post.DownVoting();
Console.WriteLine($"Votes after 2 DownVoting: {post.Votes}");

post.UpVoting();
post.UpVoting();
post.UpVoting();
Console.WriteLine($"Votes after 3 UpVoting: {post.Votes}");
