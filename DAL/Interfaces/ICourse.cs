using DAL.Models;

namespace DAL.Controllers;

public interface ICourse
{
    public List<Course> GetCourses();
}