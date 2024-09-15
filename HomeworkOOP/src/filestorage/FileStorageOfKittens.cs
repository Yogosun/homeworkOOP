using HomeworkOOP.inc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace HomeworkOOP.src.filestorage
{
    public class FileStorageOfKittens : IStorage
    {
        private string _fileName;

        public FileStorageOfKittens(string fileName)
        {
            _fileName = fileName;
        }

        public List<TaskMod> LoadTasks()
        {
            // Проверка, существует ли файл перед его чтением
            if (!File.Exists(_fileName))
            {
                Console.WriteLine($"File {_fileName} not found. Starting with an empty task list.");
                return new List<TaskMod>(); // Если файл не найден, возвращаем пустой список
            }

            // Чтение содержимого файла и десериализация
            var json = File.ReadAllText(_fileName);
            return JsonSerializer.Deserialize<List<TaskMod>>(json) ?? new List<TaskMod>();
        }

        public void SaveTasks(List<TaskMod> tasks)
        {
            // Сериализация списка задач в формат JSON и запись в файл
            var json = JsonSerializer.Serialize(tasks);
            File.WriteAllText(_fileName, json);
            Console.WriteLine($"Tasks have been saved to {_fileName}.");
        }
    }
}
