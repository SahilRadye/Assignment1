using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemoApp_WGS.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Name is Required")]
        public string StudentName { get; set; }


        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }


        [Required(ErrorMessage = "Course is required")]
        public string Course { get; set; }


        [Required(ErrorMessage = "Rating is required")]
        public string Rating { get; set; }


        [Required(ErrorMessage = "Suggestion is required")]
        public string Suggestion { get; set; }
    }
}