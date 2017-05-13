using SGC.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGC.Core;
using System.Linq.Expressions;

namespace SGC.Infra.Repository
{
    public class UserRepository : ICrudUser
    {

        private DBBaseContext _context;
        public UserRepository(DBBaseContext context)
        {
            _context = context;
        }

        public User Create(User user)
        {
            _context.Set<User>().Add(user);
            _context.SaveChanges();
            return user;
        }

        public User Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Get(Expression<Func<User, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public User Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
