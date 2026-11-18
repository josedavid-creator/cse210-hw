using System;
using System.Collections.Generic; 

public class Video
{
    public string _title;
    public string _author;
    public int _length; 
    public List<Comment> _comments = new List<Comment>(); 

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        
        foreach (Comment c in _comments)
        {
            c.Display();
        }
        

        Console.WriteLine("-------------------------------------------");
    }
}