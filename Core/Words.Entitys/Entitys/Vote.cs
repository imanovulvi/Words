using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Words.Common.ModelViews.Enum;

namespace Words.Entitys.Entitys
{
    public class Vote:BaseEntity
    {
        public VoteType VoteType { get; set; }
        public Guid EntryID { get; set; }
        public Entry Entry { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
