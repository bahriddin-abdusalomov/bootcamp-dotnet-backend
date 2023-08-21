using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskScheduler
{
    public class TaskUnit 
    {
        public string Name { get; }
        public string Desciription { get; }
        public DateTime DuaDate { get; }

        public TaskUnit(string name, string desciription, DateTime duaDate)
        {
            Name = name;
            Desciription = desciription;
            DuaDate = duaDate;
        }
    }
}
