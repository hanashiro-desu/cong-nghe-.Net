using System;
using System.Collections.Generic;

namespace BT_ThucHanh.Models;

public partial class KetQua
{
    public int MaSo { get; set; }

    public string MaMh { get; set; } = null!;

    public int? Diem { get; set; }

    public virtual Mon MaMhNavigation { get; set; } = null!;

    public virtual SinhVien MaSoNavigation { get; set; } = null!;
}
