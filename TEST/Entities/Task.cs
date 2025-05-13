﻿namespace TEST.Entities;

public class Task
{
    public int IdTask { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime Deadline { get; set; }
    
    
    public int IdProject { get; set; }
    public int IdTaskType { get; set; }
    public int IdAssignedTo { get; set; }
    public int IdCreator { get; set; }
    
    public Project Project { get; set; }
    public TaskType TaskType { get; set; }
    public TeamMember TeamMember { get; set; }
    
}