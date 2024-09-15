using HomeworkOOP.inc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOOP.src.commands
{
    public class CommandRemoveTask : ICommand
    {
        private TaskModManager _taskManager;
        private int _taskId;

        public CommandRemoveTask(TaskModManager taskManager, int taskId)
        {
            _taskManager = taskManager;
            _taskId = taskId;
        }

        public void Execute()
        {
            _taskManager.RemoveTask(_taskId);
        }
    }
}
