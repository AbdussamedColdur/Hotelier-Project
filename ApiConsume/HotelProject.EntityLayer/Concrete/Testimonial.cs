﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }
        public string ClientName { get; set; }
        public string ClientTitle { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }

}
