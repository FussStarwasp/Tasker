using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using WebGrease;

namespace Tasker.Models
{
    public class Items
    {
        public int Id{ get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        [Display(Name="Serial Number")]
        public string SerialNumber { get; set; }

        public ItemType ItemType { get; set; }
        public string Notes { get; set; }
        [Display(Name="Misc. Notes")]
        public string OtherNotes { get; set; }
        public ICollection<ChoreItems> ChoreItems { get; set; }

    }
}