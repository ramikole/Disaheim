namespace Disaheim;

public class Book : Merchandise
{
    public string Title { get; set; }
    public double Price { get; set; }

    public Book(string itemId) : this(itemId, "", 0.0)
    {
    }

    public Book(string itemId, string title) : this(itemId, title, 0.0)
    {
    }

    public Book(string itemId, string title, double price)
    {
        ItemId = itemId;
        Title = title;
        Price = price;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Title: {Title}, Price: {Price}";
    }
}