using HomeworkOOP.inc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOOP.src.commands
{
    public class CommandAddTask : ICommand
    {
        private TaskModManager _taskManager;
        private string _description;

        public CommandAddTask(TaskModManager taskManager, string description)
        {
            _taskManager = taskManager;
            _description = description;
        }

        public void Execute()
        {
            _taskManager.AddTask(_description);
        }
    }
}
