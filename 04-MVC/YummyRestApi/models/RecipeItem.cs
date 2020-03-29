using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YummyRestApi.Models
{
    public class RecipeItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Time { get; set; }
        public string Difficulty { get; set; }
   
        public int NumberOfLikes { get; set; }
        public string Ingredients { get; set; }
        public string Process { get; set; }
        public string TipsAndTricks { get; set; }
    }
}
