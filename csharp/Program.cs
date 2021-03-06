﻿using System;
using System.Collections.Generic;
using csharp.Items;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<BaseItem> items = GetItems();

            GildedRose app = new GildedRose(items);

            for (int i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                foreach (dynamic item in items)
                {
                    Console.WriteLine(item.Name + ", " + item.SellIn + ", " + item.Quality);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
            Console.ReadLine();
        }

        private static IList<BaseItem> GetItems()
        {
            return new List<BaseItem>{
                new BaseItem {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Cheese {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new BaseItem {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Legendary {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Legendary {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Ticket
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Ticket
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new Ticket
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
                new Conjured {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };
        }
    }
}