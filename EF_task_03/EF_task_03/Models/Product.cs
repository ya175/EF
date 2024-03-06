using System;
using System.Collections.Generic;

namespace EF_task_03.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int BrandId { get; set; }

    public int CategoryId { get; set; }

    public short ModelYear { get; set; }

    public decimal ListPrice { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<Stock> Stocks { get; set; } = new List<Stock>();

    public override string ToString()
    {
        return $"Id : {ProductId} , Name : {ProductName} , BrandID : {BrandId} , CategoryId : {CategoryId} , Model Year : {ModelYear} , Price : {ListPrice}";
            }
}
