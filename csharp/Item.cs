using System;

namespace csharp
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public virtual void SetSellIn()
        {
            SellIn--;
        }

        public virtual void SetQuality()
        {
            Quality = Math.Max(Quality - 1, 0);
            if (SellIn < 0)
            {
                Quality = Math.Max(Quality - 1, 0);
            }
        }
    }
}
