using System;
using System.Collections.Generic;

namespace Lab10_QLBanHang.Models;

public partial class Donhang
{
    public int MaDh { get; set; }

    public DateTime NgayDat { get; set; }

    public string TrangThai { get; set; } = null!;

    public string? GhiChu { get; set; }

    public int? MaKh { get; set; }

    public virtual ICollection<Chitietdh> Chitietdhs { get; set; } = new List<Chitietdh>();

    public virtual Khachhang? MaKhNavigation { get; set; }
}
