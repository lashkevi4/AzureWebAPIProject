using System;
using System.Collections.Generic;

namespace AzureWebAPIProject.Models;

public partial class Person
{
    public int PersonId { get; set; }

    public string LastName { get; set; } = null!;

    public string? FirstName { get; set; }

    public int? Age { get; set; }
}
