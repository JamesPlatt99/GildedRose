using NUnit.Framework;
using System.Collections.Generic;

namespace csharp.Tests
{
    [TestFixture]
    public class QualityTest
    {
        [Test]
        public void CheckRegularQualityChange()
        {
            IList<BaseItem> items = new List<BaseItem>
            {
                new BaseItem {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(items[0].Quality, 19);
        }

        [Test]
        public void CheckUnderflowQualityChange()
        {
            IList<BaseItem> items = new List<BaseItem>
            {
                new BaseItem {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 0},
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(items[0].Quality, 0);
        }

        [Test]
        public void CheckOverflowQualityChange()
        {
            IList<BaseItem> items = new List<BaseItem>
            {
                new Cheese {Name = "Aged Brie", SellIn = 10, Quality = 50},
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(items[0].Quality, 50);
        }

        [Test]
        public void CheckExpiredItemQualityChange()
        {
            IList<BaseItem> items = new List<BaseItem>
            {
                new BaseItem {Name = "+5 Dexterity Vest", SellIn = 0, Quality = 20},
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(items[0].Quality, 18);
        }

        [Test]
        public void CheckCheeseQualityChange()
        {
            IList<BaseItem> items = new List<BaseItem>
            {
                new Cheese {Name = "Aged Brie", SellIn = 0, Quality = 20},
                new Cheese {Name = "Aged Brie", SellIn = 1, Quality = 20},
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(items[0].Quality, 22);
            Assert.AreEqual(items[1].Quality, 21);
        }

        [Test]
        public void CheckTicketQuality()
        {
            IList<BaseItem> items = new List<BaseItem>
            {new Ticket
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Ticket
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 30
                },
                new Ticket
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 30
                },new Ticket
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 0,
                    Quality = 30
                },
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(items[0].Quality, 21);
            Assert.AreEqual(items[1].Quality, 32);
            Assert.AreEqual(items[2].Quality, 33);
            Assert.AreEqual(items[3].Quality, 0);
        }
    }
}