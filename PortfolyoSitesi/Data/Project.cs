using System;
using System.Collections.Generic;

namespace PortfolyoSitesi.Data
{
    public partial class Project
    {
        public int ProjectId { get; set; }
        public string? ProjectName { get; set; }
        public string? Title { get; set; }
        public string? ImageUrl { get; set; }
        public int? CategoryId { get; set; }
        public string? ProjectLink { get; set; }

        public virtual Category? Category { get; set; }
    }
}
