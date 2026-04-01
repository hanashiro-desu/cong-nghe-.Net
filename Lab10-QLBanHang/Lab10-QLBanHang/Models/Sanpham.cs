using System;
using System.Collections.Generic;

namespace Lab10_QLBanHang.Models;

public partial class Sanpham
{
    public int MaSp { get; set; }

    public string TenSp { get; set; } = null!;

    public string? DanhMuc { get; set; }

    public double? DonGia { get; set; }

    public int SoLuongTon { get; set; }

    public string? MoTa { get; set; }

    public virtual ICollection<Chitietdh> Chitietdhs { get; set; } = new List<Chitietdh>();
}
