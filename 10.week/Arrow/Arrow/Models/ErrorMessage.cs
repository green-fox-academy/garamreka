﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrow.Models
{
    public class ErrorMessage : IArrow
    {
        public string Error { get; set; } = "Please provide time and distance.";
    }
}
