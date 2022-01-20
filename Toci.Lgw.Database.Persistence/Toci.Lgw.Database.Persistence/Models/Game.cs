using System;
using System.Collections.Generic;

namespace Toci.Lgw.Database.Persistence.Models
{
    public partial class Game
    {
        public Game()
        {
            Competitions = new HashSet<Competition>();
            Duels = new HashSet<Duel>();
            Gamerplayedgames = new HashSet<Gamerplayedgame>();
            Gamersgames = new HashSet<Gamersgame>();
            Teams = new HashSet<Team>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Competition> Competitions { get; set; }
        public virtual ICollection<Duel> Duels { get; set; }
        public virtual ICollection<Gamerplayedgame> Gamerplayedgames { get; set; }
        public virtual ICollection<Gamersgame> Gamersgames { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
