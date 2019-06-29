using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiser.Data
{
    public enum Genre { Proverb, Quote, Fact, Musing }
    public class Wisdom
    {
        //Keys and Ids
        [Key]
        public int WisdomId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        //Core properties
        public string Content { get; set; }
        public Genre WisdomGenre { get; set; }
        //How many upvotes
        public int PostVirtue { get; set; }
        public string Source { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
