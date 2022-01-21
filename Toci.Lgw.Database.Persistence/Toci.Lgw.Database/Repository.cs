using Microsoft.EntityFrameworkCore;
using Toci.Lgw.Database.Persistence.Models;

namespace Toci.Lgw.Database
{
    public class Repository<TModel> where TModel : class
    {
        protected DbContext Context = new TociGamersContext();

        public IEnumerable<TModel> Select()
        {
            return null;
        }

        public TModel Insert(TModel record)
        {
            Context.Set<TModel>().Add(record);
            Context.SaveChanges();

            return record;
        }
    }
}