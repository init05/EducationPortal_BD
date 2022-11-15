using CORE.Models;

namespace CORE.Controllers;

public interface ICourseController
{
    public List<Course> GetCourses();
}