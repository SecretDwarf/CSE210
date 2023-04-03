public class Comment
{
    public List<string> comments = new List<string>();
    public List<string> names = new List<string>();

    public Comment() {}
    public void AddComment(string name, string comment)
    {
        comments.Add($"Name: {name} Comment: {comment}");
    }
    public int lengthOfComments() {
        return comments.Count();
    }

    public void DisplayComments()
    {
        foreach (string comment in comments)
        {
            Console.WriteLine(comment);
        }
    }

}