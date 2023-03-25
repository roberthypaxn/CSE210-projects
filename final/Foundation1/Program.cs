using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //Videos
        Video fullStack = new Video("FullStack Development", "Mentale", TimeSpan.FromSeconds(3670));
        Video python = new Video("Python For Everyone", "Mentale", TimeSpan.FromSeconds(3675));
        Video csharp = new Video("C# for Everyone", "Mentale", TimeSpan.FromSeconds(3696));
        //comments for fullStack
        Comment fullStackComment1 = new Comment("Jordan", "You went above and beyond explaining this one!");
        Comment fullStackComment2 = new Comment("John", "Next time please make a video about DBMS systems, some of us need to understand more about them");
        Comment fullStackComment3 = new Comment("Josh", "This is well organised. keep it up");
        fullStack.Commenting(fullStackComment1._fullComment);
        fullStack.Commenting(fullStackComment2._fullComment);
        fullStack.Commenting(fullStackComment3._fullComment);
        //Comments for python
        Comment pythonComment1 = new Comment("Jordan", "Epic stuff");
        Comment pythonComment2 = new Comment("John", "The Tkinter example is niiiince");
        Comment pythonComment3 = new Comment("Josh", "Python is my favorite language");
        python.Commenting(pythonComment1._fullComment);
        python.Commenting(pythonComment2._fullComment);
        python.Commenting(pythonComment3._fullComment);
        //Comments for csharp
        Comment csharpComment1 = new Comment("Jordan", "Polymorphism is really intricate");
        Comment csharpComment2 = new Comment("John", "Abstraction is useful but OOP is not as fun as functional programming. Just saying.");
        Comment csharpComment3 = new Comment("Josh", "Python is still my favorite language");
        csharp.Commenting(csharpComment1._fullComment);
        csharp.Commenting(csharpComment2._fullComment);
        csharp.Commenting(csharpComment3._fullComment);

        List<string> videos = new List<string>();

        foreach(string comment in fullStack._comments){
            videos.Add($"\nTitle: {fullStack._title}\nAuthor: {fullStack._author}\nDuration: {fullStack._length.ToString()}\nComments = \n{comment}");
        }

        foreach(string comment in python._comments){
            videos.Add($"\nTitle: {python._title}\nAuthor: {python._author}\nDuration: {python._length.ToString()}\nComments = \n{comment}");
        }

        foreach(string comment in csharp._comments){
            videos.Add($"\nTitle: {csharp._title}\nAuthor: {csharp._author}\nDuration: {csharp._length.ToString()}\nComments = \n{comment}");
        }
        
        foreach(string video in videos)
        {
            Console.WriteLine(video);
        }

    }
}