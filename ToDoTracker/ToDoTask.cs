namespace ToDoTracker
{
    class ToDoTask : IComparable<ToDoTask>
    {
        public int TaskId { get; set; }
        public string TaskDescription { get; set; }
        public int Difficulty { get; set; }
        public string Assignee { get; set; }
        public DateTime DueDate { get; set; }

        public ToDoTask(int taskId, string taskDescription, int difficulty, string assignee, DateTime dueDate)
        {
            TaskId = taskId;
            TaskDescription = taskDescription;
            Difficulty = difficulty;
            Assignee = assignee;
            DueDate = dueDate;
        }

        public ToDoTask(int taskId)
        {
            TaskId = taskId;
            TaskDescription = "";
            Difficulty = 1;
            DueDate = DateTime.Now.AddDays(30);
        }
        public override string ToString()
        {
            return $"To-Do # {TaskId} - {TaskDescription} with difficulty level of {Difficulty} for {Assignee}, due on {DueDate:dd/MM/yyyy}";
        }

        public int CompareTo(ToDoTask other)
        {
            return other.Difficulty - Difficulty;
        }
    }
}