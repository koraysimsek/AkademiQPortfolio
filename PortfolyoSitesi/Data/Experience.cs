using System;
using System.Collections.Generic;

namespace PortfolyoSitesi.Data
{
    public partial class Experience
    {
        public int ExperienceId { get; set; }
        public string? Title { get; set; }
        public string? CompanyName { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public string? Description { get; set; }
    }
}
