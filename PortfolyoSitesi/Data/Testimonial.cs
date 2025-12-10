using System;
using System.Collections.Generic;

namespace PortfolyoSitesi.Data
{
    public partial class Testimonial
    {
        public int TestimonialId { get; set; }
        public string? Description { get; set; }
        public string? TestimonialName { get; set; }
        public string? Title { get; set; }
        public string? Company { get; set; }
        public string? ImageUrl { get; set; }
    }
}
