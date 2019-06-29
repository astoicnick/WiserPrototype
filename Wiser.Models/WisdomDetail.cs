using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiser.Data;

namespace Wiser.Models
{
    public class WisdomDetail
    {
        public Author Author { get; set; }
        public ApplicationUser Owner { get; set; }
        public int Virtue { get; set; }
        public string Content { get; set; }
        public string Source { get; set; }
        public Genre WisdomGenre { get; set; }
        public DateTime CreatedAt => DateTime.Now;
    }
}
