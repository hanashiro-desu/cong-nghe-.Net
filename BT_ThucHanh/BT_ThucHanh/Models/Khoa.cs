using System;
using System.Collections.Generic;

namespace BT_ThucHanh.Models;

public partial class Khoa
{
    public string Makhoa { get; set; } = null!;

    public string? Tenkhoa { get; set; }

    public virtual ICollection<SinhVien> SinhViens { get; set; } = new List<SinhVien>();
}
