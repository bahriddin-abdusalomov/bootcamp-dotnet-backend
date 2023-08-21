namespace TaskScheduler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TaskTracker<TaskUnit> taskList = new TaskTracker<TaskUnit>();

            taskList.Add(new TaskUnit("HomeTask1", "NImadurlar", DateTime.UtcNow));
            taskList.Add(new TaskUnit("HomeTask2", "NImadurlar", DateTime.UtcNow));
            taskList.Add(new TaskUnit("HomeTask3", "NImadurlar", DateTime.Now));
            taskList.Add(new TaskUnit("HomeTask4", "NImadurlar", DateTime.Now));
            taskList.Add(new TaskUnit("HomeTask5", "NImadurlar", DateTime.Now));

            taskList.LatestTasks(taskList);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\nName: {taskList[i].Name}" +
                    $"\nDesciription: {taskList[i].Desciription}" +
                    $"\nDuaDate: {taskList[i].DuaDate}");
            }
        }
    }
}