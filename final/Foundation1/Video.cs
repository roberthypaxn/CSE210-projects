using System;

class Video
{
    public string _title;
    public string _author;
    public  TimeSpan _length;
    public List<string> _comments = new List<string>();
    public Video(string title, string author, TimeSpan length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void Commenting(string comment)
    {
        _comments.Add(comment);
    }
}