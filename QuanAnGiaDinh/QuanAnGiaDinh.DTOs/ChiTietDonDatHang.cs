using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanAnGiaDinh.DTOs
{
    [Table("ChiTietDonHang")]
    public class ChiTietDonDatHang
    {
        public int IdDatHang { get; set; }
        public int SoLuong { get; set; }
        public int ThanhTien { get; set; }
        public int IdMenu { get; set; }
        [ForeignKey("IdDatHang")]
        public DatHang datHang { get; set; }
        [ForeignKey("IdMenu")]
        public Menu menu { get; set; }
    }
}
