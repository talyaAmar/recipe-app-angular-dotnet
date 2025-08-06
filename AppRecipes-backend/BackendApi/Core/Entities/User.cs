using System;
using System.Collections.Generic;

namespace webApi.Entities;

public partial class User
{
    public int Code { get; set; }

    public string? FirsName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}
