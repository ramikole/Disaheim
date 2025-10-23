namespace Disaheim;

public class Utility
{
    public const double LowQualityValue = 12.5;
    public const double MediumQualityValue = 20.0;
    public const double HighQualityValue = 27.5;
    public const double CourseHourValue = 875.0;

    public static double GetValueOfMerchandise(Merchandise merchandise)
    {
        if (merchandise is Book book)
        {
            return book.Price;
        }
        if (merchandise is Amulet amulet)
        {
            switch (amulet.Quality)
            {
                case Level.low:
                    return LowQualityValue;

                case Level.medium:
                    return MediumQualityValue;

                case Level.high:
                    return HighQualityValue;

                default:
                    return 0.0;
            }
        }
        return 0.0;
    }

    public static double GetValueOfCourse(Course course)
    {
        int minutes = course.DurationInMinutes;
        int hours = minutes / 60;
        int remainder = minutes % 60;

        if (remainder > 0)
            hours += 1;

        return hours * CourseHourValue;
    }
}