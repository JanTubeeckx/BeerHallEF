﻿using System;
namespace BeerHallEF.Models
{
    public class Beer
    {
        #region Properties

        public int BeerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? AlcoholByVolume { get; set; }
        public bool AlcoholKnown => AlcoholByVolume.HasValue;
        public decimal Price { get; set; }
        #endregion

        public Beer()
        {
        }
    }
}
