namespace DAL.Models;

public class Course
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<Lesson>? Lessons { get; set; }

    public Course(string name, string description, List<Lesson> lessons)
    {
        Random Rd = new Random();
        Id = Rd.Next(1, 100000);
        //Temporary solution 
        Name = name;
        Description = description;
        Lessons = lessons;
    }
    public Course() {}
}