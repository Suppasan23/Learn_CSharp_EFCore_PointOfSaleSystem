using System;
using System.Collections.Generic;

namespace Learn_CSharp_EFCore_PointOfSaleSystem.Models.Db;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductBarcode { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public decimal? CostPrice { get; set; }

    public decimal? SellingPrice { get; set; }

    public int? UnitInStock { get; set; }

    public byte? ReoderLevel { get; set; }

    public string? CategoryName { get; set; }

    public string? UnitName { get; set; }

    public string? Note { get; set; }
}
