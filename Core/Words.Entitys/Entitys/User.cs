using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words.Entitys.Entitys
{
    public class User:BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public bool EmailConfirm { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICollection<Entry> Entries { get; set; }

        public ICollection<Favorite> Favorites { get; set; }

        public ICollection<Vote> Votes { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
