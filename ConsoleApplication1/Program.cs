using System;
using ToDoList.DataAccess;
using ToDoList.Models;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates a database using the context defined in the data access class
            using (var db = new ToDoListContext())
            {
                Console.Write("Enter new Task: ");
                var taskName = Console.ReadLine();
                
                //Creates a new isntance of the class task and calls it task, initialises it and assigns the value in taskName in TaskText
                var task = new Task { Tasktext = taskName };
                
                db.TaskDb.Add(task);
                db.SaveChanges();

                //Query database to see if it added the task to the task table
                var viewTasks = from todo in db.TaskDb
                                orderby todo.Tasktext
                                select todo;
                foreach (var item in viewTasks)
                {
                    Console.Write(item.Tasktext);
                }
                Console.WriteLine("Press Any Key To Exit");
                Console.ReadKey();
                        
            }
            

        }
    }
}
