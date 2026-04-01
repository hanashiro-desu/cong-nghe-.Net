using System;
using System.Collections.Generic;

namespace Lab10_QLBanHang.Models;

public partial class Khachhang
{
    public int MaKh { get; set; }

    public string HoTen { get; set; } = null!;

    public string? SoDienThoai { get; set; }

    public string? DiaChi { get; set; }

    public string? Email { get; set; }

    public DateTime? NgayDangKy { get; set; }

    public virtual ICollection<Donhang> Donhangs { get; set; } = new List<Donhang>();
}
