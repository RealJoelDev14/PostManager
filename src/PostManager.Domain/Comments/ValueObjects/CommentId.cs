using PostManager.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostManager.Domain.Comments.ValueObjects
{
    public class CommentId : EntityId<Guid>
    {
        private CommentId(Guid value) : base(value)
        {

        }

        public static CommentId Create(Guid value)
        {
            return new CommentId(value);
        }
        public static CommentId CreateUnique()
        {
            return new CommentId(Guid.NewGuid());
        }
    }
}
