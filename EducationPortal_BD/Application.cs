using CORE.Models;

namespace EducationPortal_BD;

public class Application
{
    
    public void OutputAllCourses(List<Course> courses)
    {
        if (courses.Count == 0)
        {
            Console.WriteLine("There are no courses available");
        }
        else if (courses.Count == 1)
        {
            Console.WriteLine("There is only one course available");
        }
        else
        {
            Console.WriteLine($"There are {courses.Count} available");
        }
        for (var i = 0; i < courses.Count; i++)
        {
            var variableCourse = courses[i];
            Console.WriteLine(i+"."+variableCourse.Name);
        }
        int index = 0;
        Console.WriteLine("Choose a course which you want me to output: ");
        while (Int32.TryParse(Console.ReadLine(), out index) == false && index+1>courses.Count)
        {
            Console.WriteLine("Please write a number without spaces or symbols and available course");
        }
        Console.WriteLine($"{courses[index].Id} /n{courses[index].Description}/nQuantity of available lessons for this course{courses[index].Lessons.Count}/n{courses[index].Name}");
    }
}