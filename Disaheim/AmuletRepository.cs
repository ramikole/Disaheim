namespace Disaheim;

public class AmuletRepository
{
    private List<Amulet> amulets = new List<Amulet>();

    public void AddAmulet(Amulet amulet)
    {
        amulets.Add(amulet);
    }

    public Amulet GetAmulet(string itemId)
    {
        Amulet wantedAmulet = null;
        foreach (Amulet amulet in amulets)
        {
            if (amulet.ItemId == itemId)
            {
                wantedAmulet = amulet;
                break;
            }
        }
        return wantedAmulet;
    }

    public double GetTotalValue()
    {
        double total = 0;
        foreach (Amulet b in amulets)
        {
            total += Utility.GetValueOfAmulet(b);
        }
        return total;
    }
}