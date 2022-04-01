using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Teutons.Training.Generics
{
    class Users
    {
        public int id;
        public string name;
        public string password;
    }

    public class Example
    {
        public void dupa()
        {
            GenericRepository<Users> usersDal = new GenericRepository<Users>();

            usersDal.insert(new Users() { name = "johnny" });
        }
    }
    public class GenericRepository<TModel> //EF - orm - refleksja - kowariancja, kontrawariancja
    {
        // 4
        public int insert(TModel model)
        {
            // ? users -> insert into users (id,name,password) values ('', '');
            return 1;
        }

        protected string fun(TModel item)
        {
            foreach (FieldInfo m in item.GetType().GetFields())
            {
                //yield return m.Name;
            }

            return string.Join(',', item.GetType().GetFields().Select(m => m.Name));
        }
    }
}
