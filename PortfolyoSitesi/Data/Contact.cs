using System;
using System.Collections.Generic;

namespace PortfolyoSitesi.Data
{
    public partial class Contact
    {
        public int ContactId { get; set; }
        public string? Description { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
    }
}
