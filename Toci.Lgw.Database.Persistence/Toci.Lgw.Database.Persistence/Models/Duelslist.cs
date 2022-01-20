using System;
using System.Collections.Generic;

namespace Toci.Lgw.Database.Persistence.Models
{
    public partial class Duelslist
    {
        public int? Result { get; set; }
        public string? Name { get; set; }
        public string? Gamerone { get; set; }
        public string? Gamertwo { get; set; }
    }
}
