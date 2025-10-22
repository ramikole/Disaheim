namespace Disaheim;

public class Utility
{
    public double GetValueOfBook(Book book)
    {
        return book.Price;
    }

    public double GetValueOfAmulet(Amulet amulet)
    {
        switch (amulet.Quality)
        {
            case Level.low: return 12.5;
            case Level.medium: return 20.0;
            case Level.high: return 27.5;
            default: return 0.0;
        }
    }

    public double GetValueOfCourse(Course course)
    {
        int minutes = course.DurationInMinutes;

        int hours = minutes / 60;         
        int remainder = minutes % 60;     

        if (remainder > 0)
        {
            hours += 1; 
        }

        double value = hours * 875.0;
        return value;    
    }
}