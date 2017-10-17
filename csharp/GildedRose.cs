using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private readonly IList<dynamic> _items;

        public GildedRose(IList<dynamic> items)
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