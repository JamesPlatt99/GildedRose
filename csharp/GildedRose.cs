using System;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private IList<Item> Items;

        readonly Dictionary<string,ItemTypes> _itemLookup = new Dictionary<string, ItemTypes>{
            {"Aged Brie", ItemTypes.Cheese},
            {"Backstage passes to a TAFKAL80ETC concert", ItemTypes.Ticket},
            {"Sulfuras, Hand of Ragnaros", ItemTypes.Legendary},
            {"Conjured Mana Cake", ItemTypes.Conjurerd},
            {"+5 Dexterity Vest", ItemTypes.Default},
            {"Elixir of the Mongoose", ItemTypes.Default }
        };

        enum ItemTypes
        {
            Cheese,
            Ticket,
            Legendary,
            Conjurerd,
            Default
        }

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateItems()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Items[i] = UpdateSellIn(Items[i]);
                Items[i] = UpdateQuality(Items[i]);
            }
        }

        private Item UpdateSellIn(Item item)
        {
            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.SellIn--;
            }
            return item;
        }

        private Item UpdateQuality(Item item)
        {
            switch (_itemLookup[item.Name])
            {
                case ItemTypes.Cheese:
                    item.Quality = GetAgedBrieQuality(item);
                    return item;

                case ItemTypes.Ticket:
                    item.Quality = GetPassQuality(item);
                    return item;

                case ItemTypes.Legendary:
                    return item;

                case ItemTypes.Conjurerd:
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