using System;

namespace csharp
{
    public class Conjured : Item
    {
        public Conjured(Item item)
        {
            Name = item.Name;
            SellIn = item.SellIn;
            Quality = item.Quality;
        }
        public override void SetQuality()
        {
            Quality = Math.Max(Quality - 2, 0);
            if (SellIn < 0)
            {
                Quality = Math.Max(Quality - 2, 0);
            }
        }
    }
}