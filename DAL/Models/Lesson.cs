namespace DAL.Models;

public class Lesson
{
    public int Id { get; set; }
    private string? Text { get; set; }
    private string? URL { get; set; }

    public Lesson(string text, string url)
    {
        Text = text;
        URL = url;
    }
    
    public Lesson() {}
}