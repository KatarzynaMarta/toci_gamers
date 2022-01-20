using System;
using System.Collections.Generic;

namespace Toci.Lgw.Database.Persistence.Models
{
    public partial class Duel
    {
        public int Id { get; set; }
        public int? Idplayerone { get; set; }
        public int? Idplayertwo { get; set; }
        public int? Idgame { get; set; }
        public int? Result { get; set; }

        public virtual Game? IdgameNavigation { get; set; }
        public virtual Gamer? IdplayeroneNavigation { get; set; }
        public virtual Gamer? IdplayertwoNavigation { get; set; }
    }
}
