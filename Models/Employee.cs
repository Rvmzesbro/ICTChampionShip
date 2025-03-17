using System;
using System.Collections.Generic;

namespace ICTChampionShip.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? DepartmentId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<ChatMessage> ChatMessages { get; set; } = new List<ChatMessage>();

    public virtual Department? Department { get; set; }
}
