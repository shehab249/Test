namespace TEST.Entities;

public class TaskType
{
    public int IdTaskType { get; set; }
    public string Name { get; set; }
    
    public List<Task> Tasks { get; set; }
}