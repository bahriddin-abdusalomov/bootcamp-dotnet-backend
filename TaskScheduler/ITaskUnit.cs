using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskScheduler
{
    public interface ITaskUnit
    {
        public string Name { get; } 

        public string Description { get; }

        public DateTime DueDate { get ; }
    }
}
