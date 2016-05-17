using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ToDoList.Models;

namespace ToDoList.DataAccess
{
    public class ToDoListContext : DbContext
    {
        public DbSet<Task> TaskDb { get; set; }
        public DbSet<TaskList> TaskListDb { get; set; }
    }
}
