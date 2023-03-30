using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create video 1
        Video video1 = new Video();
        video1.Title = "Introduction to C#";
        video1.Author = "John Smith";
        video1.Length = 700;
        video1.AddComment(new Comment() { Name = "Josefine", Text = "Wonderful video!" });
        video1.AddComment(new Comment() { Name = "Roberto", Text = "Thanks for the tutorial." });
        video1.AddComment(new Comment() { Name = "Jackie", Text = "Very helpful, thank you." });
        videos.Add(video1);

        // Create video 2
        Video video2 = new Video();
        video2.Title = "How to cook Barbecue";
        video2.Author = "Masterchef - productions";
        video2.Length = 1400;
        video2.AddComment(new Comment() { Name = "Ewan", Text = "This looks delicious!" });
        video2.AddComment(new Comment() { Name = "Brie", Text = "Thanks for sharing the recipe." });
        video2.AddComment(new Comment() { Name = "Michael", Text = "I'll definitely try this." });
        videos.Add(video2);

        // Create video 3
        Video video3 = new Video();
        video3.Title = "Travel blog: Honolulu";
        video3.Author = "Alexis Jackson";
        video3.Length = 2000;
        video3.AddComment(new Comment() { Name = "Patricio", Text = "This makes me want to go to Honolulu." });
        video3.AddComment(new Comment() { Name = "Thor", Text = "Awesome video, thanks for sharing." });
        video3.AddComment(new Comment() { Name = "Anne", Text = "I love Honolulu, this brings back memories." });
        videos.Add(video3);

        // Display information about all videos and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
