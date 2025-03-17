using System;
using System.Collections.Generic;

namespace ICTChampionShip.Models;

public partial class Chatroom
{
    public int Id { get; set; }

    public string? Topic { get; set; }

    public virtual ICollection<ChatMessage> ChatMessages { get; set; } = new List<ChatMessage>();
}
