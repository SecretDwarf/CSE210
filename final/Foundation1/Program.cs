using System;

class Program
{
    static void Main(string[] args)
    {
        Video firstVideo = new Video ("How to watch a Youtube Video", "John Smith", 120);

        Comment firstComments = new Comment();
        firstComments.AddComment("Steve       ", "Mind blown.");
        firstComments.AddComment("Granny Smith", "Thank you! This is a great resource.");
        firstComments.AddComment("Youtube     ", "Great Video! I totally agree with your process.");
        firstComments.AddComment("Sarah       ", "Wait a second... To watch how to watch a youtbe video don't you need to already know how to watch a video?");

        firstVideo.DisplayVideoInfo();
        Console.Write("\nComments:\n");
        firstComments.DisplayComments();

        Video secondVideo = new Video ("How to gain witness of eternal truths", "Holy Ghost", 50);

        Comment secondComments = new Comment();
        secondComments.AddComment("John ", "This message has changed my life.");
        secondComments.AddComment("Mary ", "It's weird, I felt this same feling after I was challenged to pray about the Book of Mormon.");
        secondComments.AddComment("Paul ", "Somehow without speaking he teaches more than words can describe.");
        secondComments.AddComment("Sarah", "This message made my day. I know that Christ lives and he loves us indvidually");

        secondVideo.DisplayVideoInfo();
        Console.Write("\nComments:\n");
        secondComments.DisplayComments();
    }
}