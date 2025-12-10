using System;
using System.Collections.Generic;

namespace PortfolyoSitesi.Data
{
    public partial class About
    {
        public int AboutId { get; set; }
        public string? NameSurname { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? University { get; set; }
        public string? Section { get; set; }
        public string? StartYear { get; set; }
        public string? EndYear { get; set; }
        public string? ImageUrl { get; set; }
    }
}
