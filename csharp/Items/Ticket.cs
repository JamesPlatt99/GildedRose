using System;

namespace csharp.Items
{
    public class Ticket : BaseItem
    {
        protected override void SetQuality()
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