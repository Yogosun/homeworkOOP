using HomeworkOOP.inc;
using HomeworkOOP.src;
using HomeworkOOP.src.commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Application
{
    private TaskModManager _taskManager;

    public Application(IStorage storage)
    {
        _taskManager = new TaskModManager(storage);
    }

    public void Run()
    {
        Console.WriteLine("Task Manager. Type 'help' to see commands.");
        while (true)
        {
            Console.Write("Enter command: ");
            var commandInput = Console.ReadLine()?.Trim();
            HandleCommand(commandInput);
            if (commandInput == "exit")
                break;
        }
    }

    private void HandleCommand(string commandInput)
    {
        var parts = commandInput.Split(' ');
        var commandName = parts[0];
        var args = string.Join(" ", parts.Skip(1));

        ICommand command;

        try
        {
            switch (commandName)
            {
                case ("add"):
                    command = new CommandAddTask(_taskManager, args);
                    break;

                case ("remove"):
                    command = new CommandRemoveTask(_taskManager, int.Parse(parts[1]));
                    break;

                case ("complete"):
                    command = new CommandCompleteTask(_taskManager, int.Parse(parts[1]));
                    break;

                case ("edit"):
                    command = new CommandEditTask(_taskManager, int.Parse(parts[1]), string.Join(" ", parts.Skip(2)));
                    break;

                case ("list"):
                    command = new CommandListTasks(_taskManager);
                    break;

                case ("help"):
                    Console.WriteLine("Доступны следующие команды:" + '\r' + '\n' + "[1] add      <описание>            - добавить задачу;"
                                                                    + '\r' + '\n' + "[2] remove   <id>                  - удалить задачу;"
                                                                    + '\r' + '\n' + "[3] complete <id>                  - выполнить задачу;"
                                                                    + '\r' + '\n' + "[4] edit     <id> <новое описание> - изменить задачу;"
                                                                    + '\r' + '\n' + "[5] list                           - вывести список задач;"
                                                                    + '\r' + '\n' + "[6] exit                           - выйти из программы."
                                                                    + '\r' + '\n');
                    return;

                default:
                    command = null;
                    break;
            }

            if (command != null)
            {
                command.Execute();
            }
            else
            {
                Console.WriteLine("Unknown command. Type 'help' to see available commands.");
            }
        }
        catch(Exception e)
        {
            Console.WriteLine("Что-то пошло не так.. Посмотри help, пожалуйста");
        }
    }
}
