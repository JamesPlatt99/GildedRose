using System;

namespace csharp
{
    public class Default : Item
    {
        public void Update()
        {
            SetSellIn();
            SetQuality();
        }

        protected virtual void SetSellIn()
        {
            SellIn--;
        }

        protected virtual void SetQuality()
        {
            Quality = Math.Max(Quality - 1, 0);
            if (SellIn < 0)
            {
                Quality = Math.Max(Quality - 1, 0);
            }
        }
    }
}