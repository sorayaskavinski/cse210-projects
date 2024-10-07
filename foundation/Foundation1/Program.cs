using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<Video> videos = new List<Video>();

       
        Video video1 = new Video("Learning Python", "Joe", 200);
        video1.AddComment(new Comment("Laura", "Great video!"));
        video1.AddComment(new Comment("Charlie", "Very informative."));
        video1.AddComment(new Comment("Terry", "Thanks for the tips!"));
        video1.AddComment(new Comment("Steven", "Could you please explain about loops"));

        Video video2 = new Video("Understanding what's Encapsulation", "Eve", 350);
        video2.AddComment(new Comment("Frank", "I love this content."));
        video2.AddComment(new Comment("Grace", "Wow, I didn't really understand what was encapsulation before this video"));
        video2.AddComment(new Comment("Suzie", "This is very helpful."));
        video2.AddComment(new Comment("Taylor", "Thank you for your help. Can you explain what's OOP?"));

        Video video3 = new Video("C# for Beginners", "Laura", 700);
        video3.AddComment(new Comment("Jack", "Excellent tutorial!"));
        video3.AddComment(new Comment("Kate", "Looking forward to more videos."));
        video3.AddComment(new Comment("Leo", "Well explained!"));
        video3.AddComment(new Comment("Steve", "Had too many information, it should have been broken into smaller videos"));

        
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}