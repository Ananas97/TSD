using System;
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
        [Display(Name = "Number of likes")]
        public decimal NumberOfLikes { get; set; }
        public string Ingredients { get; set; }
        public string Process { get; set; }
        [Display(Name = "Tips and Tricks")]
        public string TipsAndTricks { get; set; }
    }
}
