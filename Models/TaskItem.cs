class TaskItem
{
    string title = "";
    string description = "";
    DateTime deadline;
    bool isComplete = false;

    public DateTime Deadline { get => deadline; set => deadline = value; }
}