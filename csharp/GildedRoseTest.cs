using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void CheckQuality()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 50
                },new Item
                {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 0,
                Quality = 49
                },
                new Item {Name = "+5 Dexterity Vest", SellIn = 0, Quality = 20},
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6},
                new Item {Name = "Conjured Mana Cake", SellIn = 0, Quality = 6}
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(19, Items[0].Quality);
            Assert.AreEqual(1, Items[1].Quality);
            Assert.AreEqual(6, Items[2].Quality);
            Assert.AreEqual(80, Items[3].Quality);
            Assert.AreEqual(80, Items[4].Quality);
            Assert.AreEqual(21, Items[5].Quality);
            Assert.AreEqual(50, Items[6].Quality);
            Assert.AreEqual(50, Items[7].Quality);
            Assert.AreEqual(0, Items[8].Quality);
            Assert.AreEqual(18, Items[9].Quality);
            Assert.AreEqual(4, Items[10].Quality);
            Assert.AreEqual(2, Items[11].Quality);
        }
        [Test]
        public void CheckSellIn()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 50
                }
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(Items[0].SellIn, 9);
            Assert.AreEqual(Items[1].SellIn, 1);
            Assert.AreEqual(Items[2].SellIn, 4);
            Assert.AreEqual(Items[3].SellIn, 0);
            Assert.AreEqual(Items[4].SellIn, -1);
            Assert.AreEqual(Items[5].SellIn, 14);
        }
    }


}
