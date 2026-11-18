using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        // --- VIDEO 1 ---
        Video video1 = new Video();
        video1._title = "Learn C# in 10 Minutes";
        video1._author = "Code Ninja";
        video1._length = 600;

        Comment v1c1 = new Comment();
        v1c1._name = "Alice";
        v1c1._text = "This was incredibly helpful, thanks!";
        video1._comments.Add(v1c1);

        Comment v1c2 = new Comment();
        v1c2._name = "Bob";
        v1c2._text = "I finally understand classes.";
        video1._comments.Add(v1c2);

        Comment v1c3 = new Comment();
        v1c3._name = "Charlie";
        v1c3._text = "Can you make a video about Abstraction?";
        video1._comments.Add(v1c3);

        videosList.Add(video1);

        // --- VIDEO 2 ---
        Video video2 = new Video();
        video2._title = "Top 5 Programming Languages";
        video2._author = "Tech Guru";
        video2._length = 950;

        Comment v2c1 = new Comment();
        v2c1._name = "David";
        v2c1._text = "Python is the best!";
        video2._comments.Add(v2c1);

        Comment v2c2 = new Comment();
        v2c2._name = "Eva";
        v2c2._text = "Where is C++?";
        video2._comments.Add(v2c2);

        Comment v2c3 = new Comment();
        v2c3._name = "Frank";
        v2c3._text = "I love C# more.";
        video2._comments.Add(v2c3);

        videosList.Add(video2);

        // --- VIDEO 3 ---
        Video video3 = new Video();
        video3._title = "Funny Cat Compilation 2024";
        video3._author = "MeowTube";
        video3._length = 1200;

        Comment v3c1 = new Comment();
        v3c1._name = "Grace";
        v3c1._text = "The orange cat is hilarious.";
        video3._comments.Add(v3c1);

        Comment v3c2 = new Comment();
        v3c2._name = "Heidi";
        v3c2._text = "I can't stop laughing!";
        video3._comments.Add(v3c2);

        Comment v3c3 = new Comment();
        v3c3._name = "Ivan";
        v3c3._text = "More cats please!";
        video3._comments.Add(v3c3);

        videosList.Add(video3);

        Console.WriteLine("\n--- YouTube Videos Tracker ---");
        Console.WriteLine("===========================================\n");
        
        foreach (Video v in videosList)
        {
            v.DisplayInfo(); 
        }
    }
}