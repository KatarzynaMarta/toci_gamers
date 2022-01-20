using System;
using System.Collections.Generic;

namespace Toci.Lgw.Database.Persistence.Models
{
    public partial class Team
    {
        public Team()
        {
            Teamsplayers = new HashSet<Teamsplayer>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Idgame { get; set; }

        public virtual Game? IdgameNavigation { get; set; }
        public virtual ICollection<Teamsplayer> Teamsplayers { get; set; }
    }
}
