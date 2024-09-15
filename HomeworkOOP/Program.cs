using HomeworkOOP.inc;
using HomeworkOOP.src.filestorage;
using HomeworkOOP.src.memorystorage;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOOP
{
    internal class Program
    {
        public static void Main()
        {
            // Выбор хранилища
            Console.WriteLine("Какое хранилище используем сегодня?" + '\r' + '\n' + "[1] ОЗУ" + '\r' + '\n' + "[2] ПЗУ" + '\r' + '\n');
            var choice = Console.ReadLine();
            IStorage storage;

            switch (choice)
            {
                case ("1"):
                    storage = new MemoryStorageOfKittens();
                    break;

                case ("2"):
                    try
                    {
                        storage = new FileStorageOfKittens("tasks.json");
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Что-то пошло не так, работаем из ОЗУ", '\r', '\n', e);
                        storage = new MemoryStorageOfKittens();
                        break;
                    }

                    

                default:
                    Console.WriteLine("ОЗУ так ОЗУ", '\r', '\n');
                    storage = new MemoryStorageOfKittens();
                    break;
            }

            var app = new Application(storage);
            app.Run();
        }
    }
}
