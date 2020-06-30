using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tasker.Models
{
    public class Chore
    {
        public int Id { get; set; }
        [Display(Name="Chore Name")]

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsComplete { get; set; }

        
        [Display(Name="Date Added")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Due Added")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DueDate { get; set; }

        [Display(Name="Days Allocated")]
        public int NumberOfDaysToComplete { get; set; }

        public ChoreStatus ChoreStatus { get; set; }
        public ICollection<ChoreItems> ChoreItems { get; set; }





    }
}