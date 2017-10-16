using System;
using System.Collections.Generic;
using System.Data;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
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
                    item.Quality = Math.Min(item.Quality + 1,50);
                    if (item.SellIn < 0)
                        item.Quality = Math.Min(item.Quality + 1,50);
                    break;
                case "Backstage passes to a TAFKAL80ETC concert":
                    item.Quality = GetPassQuality(item);
                    break;
                case "Sulfuras, Hand of Ragnaros":
                    break;
                case "Conjured Mana Cake":
                    item.Quality = Math.Max(0, item.Quality - 2);
                    if (item.SellIn <= 0)
                        item.Quality = Math.Max(0, item.Quality - 2);
                    break;
                default:
                        item.Quality = Math.Max(0, item.Quality - 1);
                        if (item.SellIn < 0)
                            item.Quality = Math.Max(0, item.Quality - 1);
                    break;
            }
            return item;
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
            return Math.Min(quality,50);
        }

        
    }
}