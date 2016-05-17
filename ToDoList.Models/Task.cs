using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class Task : IDataEntity
        {
            public int Id { get; set; }
            public string Tasktext { get; set; }
            public bool IsCompleted { get; set; }
            public virtual List<Task> Tasks { get; set; }
            public DateTime CreatedOn { get; set; }
            public DateTime UpdatedOn { get; set; }
            
        }
    
}
