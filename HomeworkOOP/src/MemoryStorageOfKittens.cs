using HomeworkOOP.inc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeworkOOP.src
{
    public class MemoryStorageOfKittens : IStorage
    {
        private List<TaskMod> _tasks = new List<TaskMod>();

        public List<TaskMod> LoadTasks()
        {
            return _tasks;
        }

        public void SaveTasks(List<TaskMod> tasks)
        {
            _tasks = tasks;
        }
    }
}
