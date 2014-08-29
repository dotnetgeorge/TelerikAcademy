//Problem - http://bgcoder.com/Contests/Practice/DownloadResource/449
using System;

class Garden
{
    static void Main(string[] args)
    {
        float tomatoSeeds = float.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());
        float cucumberSeeds = float.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());
        float potatoSeeds = float.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());
        float carrotSeeds = float.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());
        float cabbageSeeds = float.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());
        float beansSeeds = float.Parse(Console.ReadLine());

        int area = 250;
        float totalCosts = (tomatoSeeds * 0.5f) + (cucumberSeeds * 0.4f) + (potatoSeeds * 0.25f) + (carrotSeeds * 0.6f) + (cabbageSeeds * 0.3f) + (beansSeeds * 0.4f);
        int totalAreas = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;
        Console.WriteLine("Total costs: {0:F2}", totalCosts);
        if (totalAreas < area)
        {
            Console.WriteLine("Beans area: {0}", (area - totalAreas));
        }
        else if (totalAreas > area)
        {
            Console.WriteLine("Insufficient area");
        }
        else if (totalAreas == area)
        {
            Console.WriteLine("No area for beans");
        }
    }
}
