//workbook 2, 4-1 , exercise 1
namespace ToDoTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ToDoTask> tasks = new List<ToDoTask>();
            while (true)
            {
                Console.WriteLine("Please select an option\n" +
                "    1: Add a task\n" +
                "    2: A Remove a task\n" +
                "    3: List tasks by due date\n" +
                "    4: List tasks by difficulty\n" +
                "    5: Quit the application"
                );

                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine($"Your choice: {choice}\n");
                            AddTask(tasks);
                            break;
                        case 2:
                            Console.WriteLine($"Your choice: {choice}\n");
                            Console.WriteLine($"Enter Task Id to remove : ");
                            input = Console.ReadLine();
                            if(int.TryParse(input, out int taskId))
                            {
                                if(tasks.Any(x=> x.TaskId == taskId))
                                {
                                    tasks.RemoveAll(x=> x.TaskId == taskId);
                                    Console.WriteLine($"Removed tasks with given task id ");
                                }
                                else
                                {
                                    Console.WriteLine("No tasks with given Task Id ");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input");
                            }
                            break;
                        case 3:
                            Console.WriteLine($"Your choice: {choice}\nSorting task in order of due date .....\n");
                            tasks.Sort(new AscendingDueDateSorter());
                            foreach (ToDoTask task in tasks)
                            {
                                Console.WriteLine(task);
                            }
                            break;
                        case 4:
                            Console.WriteLine($"Your choice: {choice}\nSorting task in order of difficulty .....\n");
                            tasks.Sort();
                            foreach (ToDoTask task in tasks)
                            {
                                Console.WriteLine(task);
                            }
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
        }

        private static void AddTask(List<ToDoTask> tasks)
        {
            Console.WriteLine("Enter task id:");
            string input = Console.ReadLine();
            var task = new ToDoTask(int.Parse(input));
            Console.WriteLine("Enter task description:");
            task.TaskDescription = Console.ReadLine();
            Console.WriteLine("Difficulty:");
            input = Console.ReadLine(); 
            task.Difficulty = int.Parse(input);
            Console.WriteLine("Assigned to :");
            task.Assignee = Console.ReadLine(); 
            Console.WriteLine("Due Date");
            input = Console.ReadLine(); 
            task.DueDate = DateTime.Parse(input);
            tasks.Add(task);
            Console.WriteLine("Item added.\n");
        }
    }
}