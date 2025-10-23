using System.Web;

namespace Disaheim;

public class BookRepository
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public Book GetBook(string itemId)
    {
        Book wantedBook = null;
        foreach (Book book in books)
        {
            if (book.ItemId == itemId)
            {
                wantedBook = book;
                break;
            }
        }
        return wantedBook;
    }

    public double GetTotalValue()
    {
        double total = 0;
        foreach (Book b in books)
        {
            total += Utility.GetValueOfBook(b);
        }
        return total;
    }
}