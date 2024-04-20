using System;
using System.Collections.Generic;

namespace Progra6_Assets_ByronG.Models;

public partial class Asset
{
    public int AssetId { get; set; }

    public string SerialNumber { get; set; } = null!;

    public string Brand { get; set; } = null!;

    public string Model { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Cost { get; set; }

    public DateOnly? AcquisitionDate { get; set; }

    public int AssetCategoryId { get; set; }

    public int DepartmentId { get; set; }

    public int DepreciationId { get; set; }

    public int UserId { get; set; }

    public virtual AssetCategory AssetCategory { get; set; } = null!;

    public virtual Department Department { get; set; } = null!;

    public virtual Depreciation Depreciation { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
