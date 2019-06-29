using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiser.Models
{
    public class AuthorDetail
    {
        public string AuthorName { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? Virtue { get; set; }
        public List<WisdomCreate> Attributions { get; set; }
    }
}
