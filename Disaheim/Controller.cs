
namespace Disaheim;

public class Controller
{
    private BookRepository bookRepo;
    private AmuletRepository amuletRepo;
    private CourseRepository courseRepo;

    public Controller()
    {
        bookRepo = new BookRepository();
        amuletRepo = new AmuletRepository();
        courseRepo = new CourseRepository();
    }

    public void AddToList(Book book)
    {
        bookRepo.AddBook(book);
    }

    public void AddToList(Amulet amulet)
    {
        amuletRepo.AddAmulet(amulet);
    }

    public void AddToList(Course course)
    {
        courseRepo.AddCourse(course);
    }
    
    public List<Book> GetAllBooks()
    {
        return bookRepo.GetAllBooks();
    }

    public List<Amulet> GetAllAmulets()
    {
        return amuletRepo.GetAllAmulets();
    }

    public List<Course> GetAllCourses()
    {
        return courseRepo.GetAllCourses();
    }

}