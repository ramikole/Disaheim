namespace Disaheim;

public class CourseRepository
{
    private List<Course> courses = new List<Course>();

    public void AddCourse(Course course)
    {
        courses.Add(course);
    }

    public Course GetCourse(string name)
    {
        Course wantedCourse = null;
        foreach (Course course in courses)
        {
            if (course.Name == name)
            {
                wantedCourse = course;
                break;
            }
        }
        return wantedCourse;
    }

    public double GetTotalValue()
    {
        double total = 0;
        foreach (Course b in courses)
        {
            total += Utility.GetValueOfCourse(b);
        }
        return total;
    }
    
    public List<Course> GetAllCourses()
    {
        return courses;
    }
}