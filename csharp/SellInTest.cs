using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class SellIn
    {
        [Test]
        public void CheckNormalSellIn()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateItems();
            Assert.AreEqual(Items[0].SellIn, 9);
        }
        [Test]
        public void CheckLegendarySellIn()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateItems();
            Assert.AreEqual(Items[0].SellIn, -1);
            Assert.AreEqual(Items[1].SellIn, 0);
        }
    }


}
