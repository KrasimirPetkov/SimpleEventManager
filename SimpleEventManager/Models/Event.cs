using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleEventManager.Utility;

namespace SimpleEventManager.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Event")]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [Required]
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        [IsDateAfter("StartDate", true,ErrorMessage = "The End Date/Time must be greater than the Start Date/Time")]
        public DateTime EndDate { get; set; }
    }
}