namespace Disaheim;

public class Book
{
    public string ItemId;
    public string Title;
    public double Price;

    public Book(string itemId) : this(itemId, "", 0.0)
    {
    }

    public Book(string itemId, string title) : this(itemId, title, 0.0)
    {
    }

    public Book(string itemId, string title, double price)
    {
        this.ItemId = itemId;
        this.Title = title;
        this.Price = price;
    }

    public override string ToString()
    {
        return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
    }
}