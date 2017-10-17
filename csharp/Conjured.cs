﻿using System;

namespace csharp
{
    public class Conjured : Default
    {
        protected override void SetQuality()
        {
            Quality = Math.Max(Quality - 2, 0);
            if (SellIn < 0)
            {
                Quality = Math.Max(Quality - 2, 0);
            }
        }
    }
}