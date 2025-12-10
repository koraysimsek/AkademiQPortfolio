using System;
using System.Collections.Generic;

namespace PortfolyoSitesi.Data
{
    public partial class News
    {
        public int NewsId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? CreatedDate { get; set; }
    }
}
