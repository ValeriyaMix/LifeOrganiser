using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoManager
{
    public class ToDoList: IToDoList
    {
        List<string> tasksList = new List<string>();

        List<string> postponedTasksList = new List<string>();
        
        List<string> completedTasksList = new List<string>();

        int numberToPostpone = 0;

        int numberCompletedTasks = 0;

        public string Task { get; private set; }
        public DateTime TaskDate { get; private set; }
        public string TaskCategory { get; private set; }
        public string TaskStatus { get; private set; }

        public ToDoList(string task, DateTime taskDate, string taskCategory)
        {
            Task = task;
            TaskDate = taskDate;
            TaskCategory = taskCategory;
        }

        public List<string> Create()
        {
            tasksList.Add(Task);

            return tasksList;
        }

        public List<string> Postpone()
        {
            postponedTasksList.Add(Task);
            tasksList.Remove(Task);
            numberToPostpone += 1;

            return postponedTasksList;
        }

        public List<string> Delete()
        {
            if(tasksList.Contains(Task))
            {
                tasksList.Remove(Task);
            }
            else if(postponedTasksList.Contains(Task))
            {
                postponedTasksList.Remove(Task);
            }
            numberCompletedTasks += 1;

            return completedTasksList;
        }

    }
}
