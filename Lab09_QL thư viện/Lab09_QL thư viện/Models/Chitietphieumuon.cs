using System;
using System.Collections.Generic;
using System.Text;

namespace Lab09_QL_thư_viện.Models
{
    public class Chitietphieumuon
    {
        public int MaSach { get; set; }
        public int MaPhieuMuon { get; set; }

        public virtual Sach MaSachNavigation { get; set; }
        public virtual Phieumuonsach MaPhieuMuonNavigation { get; set; }
    }
}
