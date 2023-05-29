using System;
using System.Collections.Generic;

namespace Learn_CSharp_EFCore_PointOfSaleSystem.Models.Db;

public partial class Sale
{
    public int AutoId { get; set; }

    public string SaleId { get; set; } = null!;

    public int SaleReferenceNo { get; set; }

    public DateTime? SaleDate { get; set; }

    public int? EmployeeId { get; set; }

    public int? CustomerId { get; set; }

    public decimal? SaleTotal { get; set; }

    public decimal? SaleReceive { get; set; }

    public decimal? SaleChange { get; set; }

    public virtual ICollection<SaleDetail> SaleDetails { get; set; } = new List<SaleDetail>();
}
