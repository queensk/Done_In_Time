using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Done_In_Time.Data
{
    public class TodoItem
    {
        public Guid Id  {get; set;} = Guid.NewGuid();
        public string? Title { get; set; } = string.Empty;
        public bool IsDone { get; set; }=false;
    }
}