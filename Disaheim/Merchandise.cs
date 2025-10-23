public abstract class Merchandise
{
    public string ItemId { get; set; }

    public Merchandise() { } 

    public override string ToString()
    {
        return $"ItemId: {ItemId}";
    }
}