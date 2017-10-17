using System;

namespace csharp
{
    public class Ticket : Default
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