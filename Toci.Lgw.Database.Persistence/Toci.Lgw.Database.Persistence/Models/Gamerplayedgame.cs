using System;
using System.Collections.Generic;

namespace Toci.Lgw.Database.Persistence.Models
{
    public partial class Gamerplayedgame
    {
        public int Id { get; set; }
        public int? Idgamers { get; set; }
        public int? Idgames { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? Finish { get; set; }

        public virtual Gamer? IdgamersNavigation { get; set; }
        public virtual Game? IdgamesNavigation { get; set; }
    }
}
