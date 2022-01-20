using System;
using System.Collections.Generic;

namespace Toci.Lgw.Database.Persistence.Models
{
    public partial class Gamersgame
    {
        public int Id { get; set; }
        public int? Idgamers { get; set; }
        public int? Idgames { get; set; }

        public virtual Gamer? IdgamersNavigation { get; set; }
        public virtual Game? IdgamesNavigation { get; set; }
    }
}
