using System;

namespace csharp.Items
{
    public class BaseItem
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

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