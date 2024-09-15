using HomeworkOOP.inc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOOP.src.commands
{
    public class CommandEditTask : ICommand
    {
        private TaskModManager _taskManager;
        private int _taskId;
        private string _newDescription;

        public CommandEditTask(TaskModManager taskManager, int taskId, string newDescription)
        {
            _taskManager = taskManager;
            _taskId = taskId;
            _newDescription = newDescription;
        }

        public void Execute()
        {
            _taskManager.EditTask(_taskId, _newDescription);
        }
    }

}
