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
            IList<dynamic> items = new List<dynamic>
            {
                new Default {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(items[0].SellIn, 9);
        }

        [Test]
        public void CheckLegendarySellIn()
        {
            IList<dynamic> items = new List<dynamic>
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