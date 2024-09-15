using HomeworkOOP.inc;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace HomeworkOOP.src
{
    public class FileStorage : IStorage
    {
        private string _fileName;

        public FileStorage(string fileName)
        {
            _fileName = fileName;
        }

        public List<TaskMod> LoadTasks()
        {
            if (!File.Exists(_fileName))
                return new List<TaskMod>();

            var json = File.ReadAllText(_fileName);
            return JsonSerializer.Deserialize<List<TaskMod>>(json) ?? new List<TaskMod>();
        }

        public void SaveTasks(List<TaskMod> tasks)
        {
            var json = JsonSerializer.Serialize(tasks);
            File.WriteAllText(_fileName, json);
        }
    }
}
