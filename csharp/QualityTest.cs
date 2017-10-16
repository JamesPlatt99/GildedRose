using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class QualityTest
    {
        [Test]
        public void CheckRegularQualityChange()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateItems();
            Assert.AreEqual(Items[0].Quality, 19);
        }

        [Test]
        public void CheckUnderflowQualityChange()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 0},
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateItems();
            Assert.AreEqual(Items[0].Quality, 0);
        }

        [Test]
        public void CheckOverflowQualityChange()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Aged Brie", SellIn = 10, Quality = 50},
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateItems();
            Assert.AreEqual(Items[0].Quality, 50);
        }

        [Test]
        public void CheckExpiredItemQualityChange()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 0, Quality = 20},
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateItems();
            Assert.AreEqual(Items[0].Quality, 18);
        }

        [Test]
        public void CheckCheeseQualityChange()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Aged Brie", SellIn = 0, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 1, Quality = 20},
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateItems();
            Assert.AreEqual(Items[0].Quality, 22);
            Assert.AreEqual(Items[1].Quality, 21);
        }

        [Test]
        public void CheckTicketQuality()
        {
            IList<Item> Items = new List<Item>
            {new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 30
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 30
                },new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 0,
                    Quality = 30
                },
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateItems();
            Assert.AreEqual(Items[0].Quality, 21);
            Assert.AreEqual(Items[1].Quality, 32);
            Assert.AreEqual(Items[2].Quality, 33);
            Assert.AreEqual(Items[3].Quality, 0);
        }
    }
}