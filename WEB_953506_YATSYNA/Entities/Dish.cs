﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_953506_YATSYNA.Entities
{
    public class Dish
    {
        public int DishId { get; set; } 
        public string DishName { get; set; } 
        public string Description { get; set; } 
        public int Calories { get; set; } 
        public string Image { get; set; } 
                                         

        public int DishGroupId { get; set; }
        public DishGroup Group { get; set; }
    }
}
