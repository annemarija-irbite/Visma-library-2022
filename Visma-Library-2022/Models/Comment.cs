﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Visma_Library_2022.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [ForeignKey(nameof(Book))]
        public int BookId { get; set; }
        
        public Book Book { get; set; }
        [ForeignKey(nameof(ApplicationUser))]
        public string ApplicationUserId { get; set; }

        
        public ApplicationUser ApplicationUser { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
      
        public DateTime Created { get; set; }
     
        public string Message { get; set; }
    }
}
