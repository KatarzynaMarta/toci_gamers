using System;
using System.Collections.Generic;

namespace Toci.Lgw.Database.Persistence.Models
{
    public partial class Enrolledcompetitor
    {
        public int Id { get; set; }
        public int? Idgamers { get; set; }
        public int? Idcompetitions { get; set; }

        public virtual Competition? IdcompetitionsNavigation { get; set; }
        public virtual Gamer? IdgamersNavigation { get; set; }
    }
}
