public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public string GetDisplayText()
    {
        string displayText = $"{_title} by {_author} ({_length} seconds)\nComments:\n";
        foreach (Comment comment in _comments)
        {
            displayText += comment.GetDisplayText() + "\n";
        }
        return displayText.TrimEnd('\n'); 
    }
}