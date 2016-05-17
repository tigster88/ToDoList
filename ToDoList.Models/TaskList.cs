using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class TaskList : IDataEntity
    {
        public int Id { get; set; }
        public string TaskListName { get; set; }
        public virtual TaskList Task { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
