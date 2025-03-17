using System;
using System.Collections.Generic;

namespace ICTChampionShip.Models;

public partial class Member
{
    public int? EmployeeId { get; set; }

    public int? ChatroomeId { get; set; }

    public virtual Chatroom? Chatroome { get; set; }

    public virtual Employee? Employee { get; set; }
}
