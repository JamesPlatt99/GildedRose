using System;

namespace csharp
{
    public class Cheese : Default
    {
        protected override void SetQuality()
        {
            Quality = Math.Min(Quality + 1, 50);
            if (SellIn < 0)
            {
                Quality = Math.Min(Quality + 1, 50);
            }
        }
    }
}