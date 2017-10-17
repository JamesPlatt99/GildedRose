using System;

namespace csharp
{
    public class Ticket : Item
    {
        public Ticket(Item item)
        {
            Name = item.Name;
            SellIn = item.SellIn;
            Quality = item.Quality;
        }
        public override void SetQuality()
        {
            Quality++;
            
            if (SellIn < 10)
            {
                Quality++;
            }
            if (SellIn < 5)
            {
                Quality++;
            }
            if (SellIn < 0)
            {
                Quality = 0;
            }
            Quality = Math.Min(50, Quality);
        }
    }
}