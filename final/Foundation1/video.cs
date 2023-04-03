public class Video
{
    string Title;
    string Author;
    int VideoLength; 

    public Video(string _Title, string _Author, int _VideoLength) 
    {
        Title = _Title;
        Author = _Author;
        VideoLength = _VideoLength;
    }

    public void DisplayVideoInfo()
    {
        Console.Write($"\nVideo title: {Title}");
        Console.Write($"\nVideo Author: {Author}");
        Console.Write($"\nVideo length in seconds: {VideoLength}");
    }
}