﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProzzoroTest.Domain.Entities
{
    public class NavigationItem
    {
        public int Id { get; set; }
        public string Href { get; set; }
        public string Text { get; set; }
    }
}