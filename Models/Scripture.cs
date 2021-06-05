using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesScripture.Models
{
    public class Scripture
    {
        public int ScriptureID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Scripture")]
        public string ScriptureRef { get; set; }

        [Display(Name = "Date Entered")]
        [DataType(DataType.Date)]
        public DateTime DateEntered { get; set; }

        [StringLength(600, MinimumLength = 2)]
        [Required]
        public string Note { get; set; }
    }
}