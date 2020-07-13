using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Homework3_ToDoList
{
    public class Todo
    {
        public List<Task> WeekTasks = new List<Task>();


        public void Show(Week week)
        {

            Task list = WeekTasks.FirstOrDefault(c => c.WeekTask == week);
            if (list == null)

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Дел не запланировано");
                Console.ResetColor();
            }
            else
            {
                foreach (var item in WeekTasks)
                {
                    if (item.WeekTask == week)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{item.task}");
                        Console.ResetColor();
                    }

                }
            }

        }

        public void AddTask(Week day, string task)
        {
            Task tasks = new Task(day, task);
            WeekTasks.Add(tasks);
        }
    }


}