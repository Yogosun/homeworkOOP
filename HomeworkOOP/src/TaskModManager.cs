using HomeworkOOP.inc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOOP.src
{
    internal class TaskModManager
    {
        private List<TaskMod> _tasks;
        private IStorage _storage;

        public TaskModManager(IStorage storage)
        {
            _storage = storage;
            _tasks = _storage.LoadTasks();
        }

        public void AddTask(string description)
        {
            int taskId = _tasks.Count + 1;
            var task = new TaskMod(taskId, description);
            _tasks.Add(task);
            _storage.SaveTasks(_tasks);
        }

        public void RemoveTask(int taskId)
        {
            _tasks.RemoveAll(t => t.Id == taskId);
            _storage.SaveTasks(_tasks);
        }

        public void CompleteTask(int taskId)
        {
            var task = _tasks.Find(t => t.Id == taskId);
            if (task != null)
            {
                task.MarkAsCompleted();
                _storage.SaveTasks(_tasks);
            }
        }

        public void EditTask(int taskId, string newDescription)
        {
            var task = _tasks.Find(t => t.Id == taskId);
            if (task != null)
            {
                task.Description = newDescription;
                _storage.SaveTasks(_tasks);
            }
        }

        public void ListTasks()
        {
            if (_tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            foreach (var task in _tasks)
            {
                Console.WriteLine(task);
            }
        }
    }
}
