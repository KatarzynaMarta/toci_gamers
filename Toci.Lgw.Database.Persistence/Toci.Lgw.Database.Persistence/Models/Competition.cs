using System;
using System.Collections.Generic;

namespace Toci.Lgw.Database.Persistence.Models
{
    public partial class Competition
    {
        public Competition()
        {
            Enrolledcompetitors = new HashSet<Enrolledcompetitor>();
        }

        public int Id { get; set; }
        public int? Idgames { get; set; }
        public DateTime? Time { get; set; }

        public virtual Game? IdgamesNavigation { get; set; }
        public virtual ICollection<Enrolledcompetitor> Enrolledcompetitors { get; set; }
    }
}
