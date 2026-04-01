using System;
using System.Collections.Generic;

namespace BT_ThucHanh.Models;

public partial class SinhVien
{
    public int MaSo { get; set; }

    public string? HoTen { get; set; }

    public DateTime? NgaySinh { get; set; }

    public bool? GioiTinh { get; set; }

    public string? DiaChi { get; set; }

    public int? DienThoai { get; set; }

    public string? Makhoa { get; set; }

    public virtual ICollection<KetQua> KetQuas { get; set; } = new List<KetQua>();

    public virtual Khoa? MakhoaNavigation { get; set; }
}
