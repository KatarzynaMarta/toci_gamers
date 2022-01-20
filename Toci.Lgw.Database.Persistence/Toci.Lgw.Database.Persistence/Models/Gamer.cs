using System;
using System.Collections.Generic;

namespace Toci.Lgw.Database.Persistence.Models
{
    public partial class Gamer
    {
        public Gamer()
        {
            DuelIdplayeroneNavigations = new HashSet<Duel>();
            DuelIdplayertwoNavigations = new HashSet<Duel>();
            Enrolledcompetitors = new HashSet<Enrolledcompetitor>();
            Gamerplayedgames = new HashSet<Gamerplayedgame>();
            Gamersgames = new HashSet<Gamersgame>();
            Teamsplayers = new HashSet<Teamsplayer>();
        }

        public int Id { get; set; }
        public string? Nick { get; set; }

        public virtual ICollection<Duel> DuelIdplayeroneNavigations { get; set; }
        public virtual ICollection<Duel> DuelIdplayertwoNavigations { get; set; }
        public virtual ICollection<Enrolledcompetitor> Enrolledcompetitors { get; set; }
        public virtual ICollection<Gamerplayedgame> Gamerplayedgames { get; set; }
        public virtual ICollection<Gamersgame> Gamersgames { get; set; }
        public virtual ICollection<Teamsplayer> Teamsplayers { get; set; }
    }
}
