using System;
using System.Collections.Generic;

namespace EF_task_03.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public override string ToString()
    {
        return $"Name : {this.CategoryName} , ID : {this.CategoryId}";

    }
}
