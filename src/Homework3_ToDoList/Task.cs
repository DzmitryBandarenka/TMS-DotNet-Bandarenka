
namespace Homework3_ToDoList
{
    public class Task
    {
        public Week WeekTask = new Week();
        public string task { get; set; }
        public Task(Week weekTask, string tasks)
        {
            WeekTask = weekTask;
            task = tasks;
        }



    }
}