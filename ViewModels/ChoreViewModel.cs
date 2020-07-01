using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tasker.Models;

namespace Tasker.ViewModels
{
    public class ChoreViewModel
    {
        public Chore Chore { get; set; }
        public IEnumerable<Item> Items { get; set; }

    }
}