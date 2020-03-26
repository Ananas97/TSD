﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Yummy.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Time { get; set; }
        public string Difficulty { get; set; }
        public decimal NumberOfLikes { get; set; }
        public string Ingredients { get; set; }
        public string Process { get; set; }
        public string TipsAndTricks { get; set; }
    }
}
