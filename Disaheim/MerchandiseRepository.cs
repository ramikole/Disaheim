namespace Disaheim;

public class MerchandiseRepository
{
    private List<Merchandise> merchandises = new List<Merchandise>();


    public void AddMerchandise(Merchandise merchandise)
    {
        merchandises.Add(merchandise);
    }

    public Merchandise GetMerchandise(string itemId)
    {
        Merchandise wantedMerchandise = null;
        foreach (Merchandise merchandise in merchandises)
        {
            if (merchandise.ItemId == itemId)
            {
                wantedMerchandise = merchandise;
                break;
            }
        }
        return wantedMerchandise;
    }

    public double GetTotalValue()
    {
        double total = 0;
        foreach (Merchandise b in merchandises)
        {
            total += Utility.GetValueOfMerchandise(b);
        }
        return total;
    }
}