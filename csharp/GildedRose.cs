using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net;

namespace csharp
{
    public class GildedRose
    {
        private readonly IList<Item> _items;

        readonly Dictionary<string,Type> _itemTypeLookup = new Dictionary<string, Type>{
            {"Aged Brie", typeof(Cheese)},
            {"Backstage passes to a TAFKAL80ETC concert", typeof(Ticket)},
            {"Sulfuras, Hand of Ragnaros", typeof(Legendary)},
            {"Conjured Mana Cake", typeof(Conjured)},
            {"+5 Dexterity Vest", typeof(Item)},
            {"Elixir of the Mongoose", typeof(Item) }
        };

        public GildedRose(IList<Item> items)
        {
            this._items = items;
        }

        public void UpdateItems()
        {
            Dictionary<int, dynamic> itemDict = CreateItemDict();
            for (int i = 0; i < _items.Count; i++)
            {
                itemDict[i].SetSellIn();
                itemDict[i].SetQuality();
                _items[i] = itemDict[i];
            }
        }

        private Dictionary<int, dynamic> CreateItemDict()
        {
            Dictionary<int, dynamic> itemDict = new Dictionary<int, dynamic>();
            for (int i = 0; i < _items.Count; i++)
            {
                itemDict.Add(i,CreateObject(i));
            }
            return itemDict;
        }

        private dynamic CreateObject(int i)
        {
            dynamic curType = _itemTypeLookup[_items[i].Name];
            if (curType != typeof(Item))
            {
                return Activator.CreateInstance(curType,_items[i]);
            }
            return  _items[i];
        }
    }
}