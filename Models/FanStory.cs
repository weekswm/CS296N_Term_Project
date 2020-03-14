using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CS296N_Term_Project.Models
{
    public class FanStory
    {
        public int FanStoryID { get; set; }

        [Required]
        [StringLength(2000, MinimumLength = 10)]
        [UIHint("Story")]
        public string StoryText { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 8)]
        [UIHint("Story Teller")]
        public string Name { get; set; }

        private List<Comment> comments = new List<Comment>();
        public List<Comment> Comments { get { return comments; } }
    }
}
