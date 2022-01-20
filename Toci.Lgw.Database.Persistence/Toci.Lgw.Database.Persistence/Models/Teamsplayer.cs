using System;
using System.Collections.Generic;

namespace Toci.Lgw.Database.Persistence.Models
{
    public partial class Teamsplayer
    {
        public int Id { get; set; }
        public int? Idteams { get; set; }
        public int? Idgamer { get; set; }

        public virtual Gamer? IdgamerNavigation { get; set; }
        public virtual Team? IdteamsNavigation { get; set; }
    }
}
