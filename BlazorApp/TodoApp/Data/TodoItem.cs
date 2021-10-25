using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Data
{
    public class TodoItem
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string note { get; set; }
        public bool done { get; set; }
    }
}
