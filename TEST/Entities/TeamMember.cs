﻿namespace TEST.Entities;

public class TeamMember
{
    public int IdTeamMember { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    
    public List<Task> Tasks { get; set; }
}