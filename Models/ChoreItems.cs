using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tasker.Models
{
    public class ChoreItems
    {
        [Key]
        [Column(Order = 0)]
        public int ChoreId { get; set; }

        [Key]
        [Column(Order =1)]
        public int ItemId { get; set; }
    }
}