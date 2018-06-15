using System;

namespace csharp.Items
{
    public class Cheese : BaseItem
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