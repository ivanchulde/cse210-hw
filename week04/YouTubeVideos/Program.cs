using System;

class Program
{
    static void Main(string[] args)
    {
         // Create videos
        Video video1 = new Video("Introduction to C#", "Alice", 600);
        Video video2 = new Video("Cooking Spaghetti", "Chef Bob", 900);

        // Create comments
        Comment comment1 = new Comment("John", "Great video!");
        Comment comment2 = new Comment("Mary", "I learned a lot, thanks!");
        Comment comment3 = new Comment("Alex", "Nice explanation.");
        Comment comment4 = new Comment("Tom", "Looks delicious!");
        Comment comment5 = new Comment("Lucy", "I'll try this recipe tonight.");

        // Add comments to videos
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        video2.AddComment(comment4);
        video2.AddComment(comment5);

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2 };

        // Display video info and comments
        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayText());
            Console.WriteLine("----------------------------");
        }
    }
}
