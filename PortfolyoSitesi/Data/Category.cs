using System;
using System.Collections.Generic;

namespace PortfolyoSitesi.Data
{
    public partial class Category
    {
        public Category()
        {
            Projects = new HashSet<Project>();
        }

        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
