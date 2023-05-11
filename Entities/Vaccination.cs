using System;
using System.Collections.Generic;

namespace Entities;

public partial class Vaccination
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public string? Manufacturer { get; set; }

    public int MemberId { get; set; }

    public virtual Member Member { get; set; } = null!;
}
