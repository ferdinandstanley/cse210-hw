using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Web development for Beginner", "BYU-I", 850);
        Video video2 = new Video("How to Get a better Job", "Career Expert", 800);
        Video video3 = new Video("Health is Wealth", "Dr Ferdinand Snr", 400);

        // Add comments to video1
        video1.AddComment(new Comment("Mary", "Just what I wanted."));
        video1.AddComment(new Comment("Peter", "You made it easy to understand."));
        video1.AddComment(new Comment("Tim", "Can you explain more about C#."));

        // Add comments to video2
        video2.AddComment(new Comment("Ann", "I will surely apply this."));
        video2.AddComment(new Comment("Ada", "Thanks a bunch"));
        video2.AddComment(new Comment("West", "This is so helpful."));

        // Add comments to video3
        video3.AddComment(new Comment("Rose", "You videos has helped me alot."));
        video3.AddComment(new Comment("Cynthia", "Nice one"));
        video3.AddComment(new Comment("Duke", "Can we do this for less than 7 weeks"));

        // list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // video details
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}