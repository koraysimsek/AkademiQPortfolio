using System;
using System.Collections.Generic;

namespace PortfolyoSitesi.Data
{
    public partial class Message
    {
        public int MessageId { get; set; }
        public string? NameSurname { get; set; }
        public string? Email { get; set; }
        public string? Subject { get; set; }
        public string? MessageContent { get; set; }
    }
}
