using System;

namespace csharp
{
    public class Legendary : Item
    {
        public Legendary(Item item)
        {
            Name = item.Name;
            SellIn = item.SellIn;
            Quality = item.Quality;
        }
        public override void SetQuality()
        {
            Quality = 80;
        }

        public override void SetSellIn()
        {
        }
    }
}