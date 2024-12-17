using System;
using System.Collections.Generic;

namespace MAwebMVC.Data.Models;

public partial class Burger
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool WithCheese { get; set; }

    public decimal Precio { get; set; }
}
