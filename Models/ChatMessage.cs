using System;
using System.Collections.Generic;

namespace ICTChampionShip.Models;

public partial class ChatMessage
{
    public int Id { get; set; }

    public int? SenderId { get; set; }

    public int? ChatroomId { get; set; }

    public DateTime? Date { get; set; }

    public string? Message { get; set; }

    public virtual Chatroom? Chatroom { get; set; }

    public virtual Employee? Sender { get; set; }
}
