using System;
using System.Collections.Generic;

namespace Learn_CSharp_EFCore_PointOfSaleSystem.Models.Db;

public partial class SaleDetail
{
    public int AutoId { get; set; }

    public string? SaleId { get; set; }

    public int? ProductId { get; set; }

    public string? ProductName { get; set; }

    public decimal? ProductPrice { get; set; }

    public int? ProductQuantity { get; set; }

    public decimal? SubTotal { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Sale? Sale { get; set; }
}
