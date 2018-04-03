using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToLetBdEntity;

namespace ToLetBdInterface
{
    public interface ICommentRepository
    {
        List<Comment> GetAll();
        Comment Get(int id);
        int Insert(Comment comment);
    }
}
