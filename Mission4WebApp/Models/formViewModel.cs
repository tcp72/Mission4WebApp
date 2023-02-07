using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4WebApp.Models
{
    public class formViewModel //put entries for the things want to store in the form
    {
        [Required(ErrorMessage = "Please enter you number")]
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public float Assignment { get; set; } //public meaning other variables can access it; string is the data type; 
                                              //get; set; is saying it is making a getter and a setter (instead of writing a bunch of code as seen in the comments below
                                              //Assignment is the "name" attribute from the form
        [Required(ErrorMessage = "Please enter you number")]
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public float Project { get; set; }

        [Required(ErrorMessage = "Please enter you number")]
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public float Quiz { get; set; }

        [Required(ErrorMessage = "Please enter you number")]
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public float Exam { get; set; }

        [Required(ErrorMessage = "Please enter you number")]
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public float Final { get; set; }

        [Required(ErrorMessage = "Please enter you number")]
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public float Intex { get; set; }
    }
}

//Keep this for educational purposes to understand what was removed
////Setter
//public void setFrom(string input)
//{
//    this.From = input;
//}
////getter
//public string getFrom()
//{
//    return this.From;
//        }