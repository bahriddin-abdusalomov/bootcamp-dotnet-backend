using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TaskScheduler
{
    public class TaskTracker<T> 
    {
        private List<T> _objects = new List<T>();

        public T this[int index]
        {
            get { return _objects[index]; }
        }

        public void Add(T item)
        {
            _objects.Add(item);
        }

        public void Remove(T item) 
        { 
            _objects.Remove(item);
        }

        public void LatestTasks()
        {
            foreach (T item in _objects)
            {
                _objects.Remove(item);
            }
        }

        public int TasksNumber(List<T> list)
        {
            return _objects.Count;
        }

    }
}
