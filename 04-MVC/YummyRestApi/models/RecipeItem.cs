﻿using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YummyRestApi.Models
{
    [Bind("Name, Time, Difficulty, NumberOfLikes, Ingredients, Process, TipsAndTricks")]
    public class RecipeItem
    {
       // [BindProperty]
        public int ID { get; set; }
        //[BindProperty]
        public string Name { get; set; }
        public int Time { get; set; }
        public string Difficulty { get; set; }
   
        public int NumberOfLikes { get; set; }
        public string Ingredients { get; set; }
        public string Process { get; set; }
        public string TipsAndTricks { get; set; }
        public string Secret { get; set; }
    }
}
