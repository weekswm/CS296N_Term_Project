using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CS296N_Term_Project.Models
{
    public class CommentViewModel
    {
        [Required]
        [StringLength(50, MinimumLength = 8)]
        [UIHint("Person Commenting")]
        public string Commenter { get; set; }

        [Required]
        [StringLength(2000, MinimumLength = 10)]
        [UIHint("Comment")]
        public string CommentText { get; set; }

        public string StoryText { get; set; }
    }
}
