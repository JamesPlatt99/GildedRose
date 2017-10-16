using System;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Items[i] = GetNewSellIn(Items[i]);
                Items[i] = GetNewQuality(Items[i]);
            }
        }

        private Item GetNewSellIn(Item item)
        {
            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.SellIn--;
            }
            return item;
        }

        private Item GetNewQuality(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    item.Quality = GetAgedBrieQuality(item);
                    return item;

                case "Backstage passes to a TAFKAL80ETC concert":
                    item.Quality = GetPassQuality(item);
                    return item;

                case "Sulfuras, Hand of Ragnaros":
                    return item;

                case "Conjured Mana Cake":
                    item.Quality = GetDefaultQuality(item);
                    break;
            }
            item.Quality = GetDefaultQuality(item);
            return item;
        }

        private int GetDefaultQuality(Item item)
        {
            item.Quality = Math.Max(0, item.Quality - 1);
            if (item.SellIn < 0)
                item.Quality = Math.Max(0, item.Quality - 1);
            return item.Quality;
        }

        private int GetAgedBrieQuality(Item item)
        {
            item.Quality = Math.Min(item.Quality + 1, 50);
            if (item.SellIn < 0)
                item.Quality = Math.Min(item.Quality + 1, 50);
            return item.Quality;
        }

        private int GetPassQuality(Item pass)
        {
            int quality = pass.Quality + 1;
            if (pass.SellIn < 0)
                return 0;
            if (pass.SellIn < 10)
                quality++;
            if (pass.SellIn < 5)
                quality++;
            return Math.Min(quality, 50);
        }
    }
}