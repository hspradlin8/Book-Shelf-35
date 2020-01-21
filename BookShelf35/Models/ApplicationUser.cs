using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf35.Models
{
    public class ApplicationUser : IdentityUser 
    {
        //do not put an Id on applicationUser bc it is inherited from IdentityUser
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public List<Book> Books { get; set; }
        public List<Author> Author { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
