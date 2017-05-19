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
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User Delete(int id)
        {
            var user = _context.Users.Remove(Get(id));
            _context.SaveChanges();
            return user;
        }

        public IEnumerable<User> Get(Expression<Func<User, bool>> predicate)
        {
            return _context.Users.Where(predicate);
        }

        public User Get(int id)
        {
            return _context.Users.Where(x => x.Id == id).FirstOrDefault();
        }

        public User Update(User user)
        {
            _context.Entry<User>(user).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            return user;
        }
    }
}
