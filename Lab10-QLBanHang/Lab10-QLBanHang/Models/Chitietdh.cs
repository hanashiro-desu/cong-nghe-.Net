using System;
using System.Collections.Generic;

namespace Lab10_QLBanHang.Models;

public partial class Chitietdh
{
    public int MaCt { get; set; }

    public int MaDh { get; set; }

    public int MaSp { get; set; }

    public int SoLuong { get; set; }

    public double DonGia { get; set; }

    public virtual Donhang MaDhNavigation { get; set; } = null!;

    public virtual Sanpham MaSpNavigation { get; set; } = null!;
}
