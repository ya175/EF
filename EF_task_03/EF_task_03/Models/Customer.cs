using System;
using System.Collections.Generic;

namespace EF_task_03.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Phone { get; set; }

    public string Email { get; set; } = null!;

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    public override string ToString()
    {
        return $"Name : {FirstName} {LastName} , ID : {CustomerId} , Email : {Email}";
    }
}
