using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words.Entitys.Entitys
{
    public class Comment:BaseEntity
    {
        public string Content { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid EntryId { get; set; }
        public Entry Entry { get; set; }



    }
}
