﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise;
internal class Laptop : IProduct
{
    public string ProductName {get; set;} = string.Empty;
    public int ProductPrice {get; set;}
    public string ProductSize {get; set;} = string.Empty;
}
