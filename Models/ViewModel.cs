using System;
using System.ComponentModel.DataAnnotations;
//what is this?

namespace ViewModelFun.Models
{
    public class ViewModel
    {
        // [Required(ErrorMessage="you must supply a title")]
        // [MinLength(5, ErrorMessage="you must have 5 characters")]

        // public string LoremMessage{get;set;}
        // public int Number{get;set;}
        public string FirstName{get;set;}
        public string LastName{get;set;}


        // [Display(Name = "releaseDate")]

        // public int TheInt{get;set;}
        // public List<User> TheList{get;set;}
    }
}