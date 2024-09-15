using HomeworkOOP.inc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOOP.src.commands
{
    public class CommandListTasks : ICommand
    {
        private TaskModManager _taskManager;

        public CommandListTasks(TaskModManager taskManager)
        {
            _taskManager = taskManager;
        }

        public void Execute()
        {
            _taskManager.ListTasks();
        }
    }
}
