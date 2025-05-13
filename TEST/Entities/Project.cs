namespace TEST.Entities;

public class Project
{
    public int IdProject { get; set; }
    public string Name { get; set; }
    public DateTime Deadline { get; set; }
    
    public List<Task> Tasks { get; set; }
}