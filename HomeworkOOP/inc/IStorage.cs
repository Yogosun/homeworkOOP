using HomeworkOOP.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOOP.inc
{
    public interface IStorage
    {
        List<TaskMod> LoadTasks();
        void SaveTasks(List<TaskMod> tasks);
    }
}
