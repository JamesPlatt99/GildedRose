using NUnit.Framework;
using System.Collections.Generic;

namespace csharp.Tests
{
    [TestFixture]
    public class SellIn
    {
        [Test]
        public void CheckNormalSellIn()
        {
            IList<BaseItem> items = new List<BaseItem>
            {
                new BaseItem {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(items[0].SellIn, 9);
        }

        [Test]
        public void CheckLegendarySellIn()
        {
            IList<BaseItem> items = new List<BaseItem>
            {
                new Legendary {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Legendary {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(items[0].SellIn, -1);
            Assert.AreEqual(items[1].SellIn, 0);
        }
    }
}