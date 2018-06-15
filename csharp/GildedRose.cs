using System.Collections.Generic;
using csharp.Items;

namespace csharp
{
    public class GildedRose
    {
        private readonly IList<BaseItem> _items;

        public GildedRose(IList<BaseItem> items)
        {
            this._items = items;
        }

        public void UpdateQuality()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                _items[i].Update();
            }
        }
    }
}