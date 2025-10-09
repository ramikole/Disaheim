namespace Disaheim;

public class Amulet
{
    public string ItemId;
    public string Design;
    public Level Quality;
    
    public Amulet(string itemId) : this(itemId, Level.Medium, "")
    {
    }

    public Amulet(string itemId, Level quality) : this(itemId, quality, "")
    {
    }

    public Amulet(string itemId, Level quality, string design)
    {
        ItemId = itemId;
        Quality = quality;
        Design = design;
    }
    
    public override string ToString()
    {
        return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
    }
}