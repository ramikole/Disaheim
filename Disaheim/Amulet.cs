namespace Disaheim;

public class Amulet : Merchandise
{
    public string Design { get; set; }
    public Level Quality { get; set; }

    public Amulet(string itemId) : this(itemId, Level.medium, "")
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
        return $"{base.ToString()}, Quality: {Quality}, Design: {Design}";
    }
}