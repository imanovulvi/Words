using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words.Entitys.Entitys
{
    public class Entry:BaseEntity
    {
        public string Subject { get; set; }
        public string Content { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<Favorite> Favorites { get; set; }

        public ICollection<Vote> Votes { get; set; }
    }
}
