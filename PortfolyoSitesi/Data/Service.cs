using System;
using System.Collections.Generic;

namespace PortfolyoSitesi.Data
{
    public partial class Service
    {
        public int ServiceId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? IconUrl { get; set; }
    }
}
