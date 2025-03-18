using System;
using System.Collections.Generic;

namespace ICTChampionShip.Models;

public partial class Member
{
    public int? EmployeeId { get; set; }

    public int? ChatroomId { get; set; }

    public virtual Chatroom? Chatroom { get; set; }

    public virtual Employee? Employee { get; set; }
}
