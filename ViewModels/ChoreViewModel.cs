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
        public IEnumerable<Items> Items { get; set; }
        public IEnumerable<Contact> Contacts { get; set; }
        public IEnumerable<ChoreStatus> ChoreStatus { get; set; }


    }
}