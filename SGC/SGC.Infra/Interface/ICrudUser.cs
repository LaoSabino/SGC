using SGC.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SGC.Infra.Interface
{
    public interface ICrudUser
    {
        User Create(User user);

        User Update(User user);

        User Get(int id);

        IEnumerable<User> Get(Expression<Func<User, bool>> predicate);

        User Delete(int id);


    }
}
