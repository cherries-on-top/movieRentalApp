﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalApp.DTOs
{
    public class NewRentalDto
    {
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }
    }
}