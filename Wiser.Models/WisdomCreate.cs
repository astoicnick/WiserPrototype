using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiser.Data;

namespace Wiser.Models
{
    public class WisdomCreate
    {
        public int? AuthorId { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string Content { get; set; }
        public Genre WisdomGenre { get; set; }
        public Guid OwnerId { get; set; }


    }
}
