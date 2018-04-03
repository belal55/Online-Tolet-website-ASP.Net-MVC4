using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToLetBdEntity
{
    public class UserRepository:IUserRepository
    {
        ToLetBdDbContext context = new ToLetBdDbContext();
        public List<User> GetAll()
        {
            return this.context.Users.ToList();
        }

        public User Get(int id)
        {
            return this.context.Users.SingleOrDefault(u => u.Id == id);
        }

        public int Insert(User user)
        {
            this.context.Users.Add(user);
            return this.context.SaveChanges();
        }

        public int Update(User user)
        {
            User u = this.context.Users.SingleOrDefault(us => us.Id == user.Id);
            u.Name = user.Name;
            u.Email = user.Email;
            u.Password = user.Password;
            u.ImgPath = user.ImgPath;
            u.Gender = user.Gender;
            u.PhnNo = user.PhnNo;
            return this.context.SaveChanges();
        }

        public int Delete(int id)
        {
            User u = this.context.Users.SingleOrDefault(uu => uu.Id == id);
            this.context.Users.Remove(u);
            return this.context.SaveChanges();
        }
    }
}
