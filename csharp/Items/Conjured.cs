using System;

namespace csharp.Items
{
    public class Conjured : BaseItem
    {
        protected override void SetQuality()
        {
            Quality = Math.Max(Quality - 2, 0);
            if (SellIn < 0)
            {
                Quality = Math.Max(Quality - 2, 0);
            }
        }
    }
}