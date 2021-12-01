using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoLidtApplication.Models
{
    public class ToDo
    {
        public int Id { set; get; }
        public string description { set; get; }
        public bool IsDone { get; set; }
        public virtual ApplicationUser User { set; get; }

    }
}