using System;

namespace csharp
{
    public class Cheese : Item
    {
        public Cheese(Item item)
        {
            Name = item.Name;
            SellIn = item.SellIn;
            Quality = item.Quality;
        }
        public override void SetQuality()
        {
            Quality = Math.Min(Quality + 1, 50);
            if (SellIn < 0)
            {
                Quality = Math.Min(Quality + 1, 50);
            }
        }
    }
}