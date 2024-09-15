using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOOP.src
{
    public class TaskMod
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public TaskMod(int id, string description)
        {
            Id = id;
            Description = description;
            IsCompleted = false;
        }

        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }

        public override string ToString()
        {
            var status = IsCompleted ? "Succsess!" : "FAILED";
            return $"{status} {Id}. {Description}";
        }
    }
}
