using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToLetBdEntity
{
    public class PostRepository:IPostRepository
    {
        ToLetBdDbContext context = new ToLetBdDbContext();
        public List<Post> GetAll()
        {
            return this.context.Posts.ToList();
        }

        public Post Get(int id)
        {
            return this.context.Posts.SingleOrDefault(p => p.Id == id);
        }

        public int Insert(Post post)
        {
            this.context.Posts.Add(post);
            return this.context.SaveChanges();
        }

        public int Update(Post post)
        {
            Post p = this.context.Posts.SingleOrDefault(pp => pp.Id == post.Id);
            p.PostDateTime = post.PostDateTime;
            p.RoomRent = post.RoomRent;
            p.NoOfRoom = post.NoOfRoom;
            p.Title = post.Title;
            p.Address = post.Address;
            p.ShortDesc = post.ShortDesc;
            p.Status = post.Status;
            return this.context.SaveChanges();
        }

        public int Delete(int id)
        {
            Post p = this.context.Posts.SingleOrDefault(pp => pp.Id == id);
            this.context.Posts.Remove(p);
            return this.context.SaveChanges();
        }
    }
}
