using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;using System.Data.Entity;

namespace AnVat_WebTM.Models
{
    public class SpDatabaseInitializer : DropCreateDatabaseAlways<SPcontext>
    {
        protected override void Seed(SPcontext context)
        {
            GetLoaiSPs().ForEach(c => context.LoaiSP.Add(c));
            GetSPs().ForEach(p => context.SanPhams.Add(p));
        }
        private static List<LoaiSP> GetLoaiSPs()
        {
            var LoaiSPs = new List<LoaiSP>
            {
                new LoaiSP
                {
                    MaLoai = 1,
                    TenLoai = "Món hôm nay"
                },
                new LoaiSP
                {
                    MaLoai = 2,
                    TenLoai = " NGẮN HẠN"
                },
                new LoaiSP
                {
                   MaLoai = 3,
                    TenLoai= "DÀI HẠN"
                },
                new LoaiSP
                {
                    MaLoai = 4,
                   TenLoai = "Đặt Hàng Nước Ngoài"
                }
            };
            return LoaiSPs;
        }
        private static List<SanPham> GetSPs()
        {
            var SPs = new List<SanPham> {
                new SanPham
                {
                    MaSP = 1,
                    TenSP = "Chân gà xả tắc",
                    GioiThieu = "Vào những ngày hè nóng nực, một món ăn nhấm nháp cùng bạn bè ngay tại nhà sẽ là một sự lựa chọn rất tốt ",
                    Anh ="chan-ga-sả-tắc-recipe-main-photo.jpg",
                    GiaTien = 16.000f,
                    MaLoai = 1
                    },
                new SanPham
                {
                    MaSP = 2,
                    TenSP = "Sushi",
                    GioiThieu = "Nigiri sushi là loại sushi có nắm cơm trộn giấm hình bầu dục, được ép bằng tay, bên trên phủ một miếng cá sống hoặc hải sản tươi sống (cũng có thể chín) hay trứng chiên. Để làm được món ăn này bạn cần phải thật tỉ mỉ trong từng chi tiết nhỏ. Cơm phải nấu từ gạo Nhật với thời gian vừa đủ, trộn ngay với hỗn hợp giấm rồi để nguội. Các loại hải sản tươi được chọn lựa kỹ càng, bảo quản phù hợp và cắt thái đẹp mắt.",
                   Anh ="sushi.jpg",
                    GiaTien = 50.000f,
                    MaLoai = 1
                },
                new SanPham
                {
                   MaSP = 3,
                    TenSP = "Tuyết yến Dưỡng nhan",
                    GioiThieu = "Chè dưỡng nhan nhựa đào được người Vân Nam coi như “tổ yến bình dân“ vì chứa nhiều dưỡng chất, collagen thực vật, giúp da trở nên mịn màng , giảm vết nhăn trên cơ thể. các thành phần nấu chè còn có tác dụng thanh nhiệt, giải độc, tốt cho tiêu hoá. ",
                    Anh ="tuyetYen.jpg",
                    GiaTien = 30.500f,
                    MaLoai = 1
                },
                new SanPham
                {
                    MaSP = 4,
                   TenSP = "Cóc ngâm chua ngọt",
                    GioiThieu = "Món cóc ngâm đường chua ngọt giòn tan là khúc giao hòa giữa vị chua, ngọt và the cay cùng độ giòn của quả cóc nên được coi là món ăn vặt vô cùng quyến rũ và được rất nhiều người ưa chuộng.",
                    Anh ="cocNgam.jpg",
                    GiaTien = 30.000f,
                    MaLoai = 2
                },
                new SanPham
                {
                    MaSP = 5,
                    TenSP = "Su Kem",
                    GioiThieu = "Bánh su kem là món tráng miệng được rất nhiều người thích vì lớp vỏ bánh hơi dai, kết hợp hoàn hảo cùng nhân kem mát lạnh có vị ngọt nhẹ nhàng bên trong. ",
                    Anh ="su.jpg",
                    GiaTien = 26.500f,
                   MaLoai = 2
                },
                   new SanPham
                {
                    MaSP = 6,
                   TenSP = "Khô bò",
                   GioiThieu = "bò khô là món ăn khoái khẩu không thể thiếu của nhiều người nhất là các bạn trẻ. Khô bò có nhiều cách chế biến khác nhau cũng như mùi vị yêu thích của từng người. Nó kết hợp tạo ra những món ngon và thú vị gỏi khô bò, gỏi xoài ...  ",
                    Anh ="khobo.jpg",
                    GiaTien = 150.000f,
                    MaLoai = 3
                },
                   new SanPham
                   {
                       MaSP =7,
                       TenSP ="Khô gà lá chanh",
                      GioiThieu="Những miếng thịt gà khô ngon ngọt thơm lừng mùi lá chanh, vị dai dai, giòn giòn hòa quyện với vị cay cay nhè nhẹ của ớt khiến ai cũng phải xiêu lòng.",
                      Anh ="khoga.jpg",
                   GiaTien = 120.000f,
                    MaLoai = 3
                   },
                      new SanPham
                {
                    MaSP = 8,
                    TenSP= "Da Heo Mắm Tỏi Ớt",
                    GioiThieu = "Da heo chiên giòn lắc tỏi ớt nóng hổi, nhai trong miệng tạo cảm giác rôm rốp rất vui tai. Khi lắc cùng tỏi ớt mang đến hương vị cay cay, the the và thơm lừng của tỏi khiến bạn ăn mãi không thôi đấy. Và đây cũng là món ăn vặt luôn được giới trẻ yêu thích bất kể thời gian.  ",
                    Anh ="daheo.jpg",
                   GiaTien = 26.000f,
                    MaLoai = 3
                },
                    new SanPham
                {
                    MaSP = 9,
                    TenSP = "Bông lan Đài Loan",
                   GioiThieu = "bánh bông lan phô mai Đài Loan! Với sự xuất hiện khá cùng thời điểm của hai tiệm bánh là Le Castella và Tai Yang King Castella thì bánh bông lan đã trở thành một món bánh được nhiều người quyết tâm ăn thử khi đến phố đi bộ dù đôi khi phải xếp hàng chờ đợi khá lâu. ",
                    Anh ="bonglan.jpg",
                    GiaTien = 17.000f,
                    MaLoai = 4
                    },
                     new SanPham
                {
                    MaSP = 10,
                    TenSP = "Miến chua cay Trùng Khánh",
                   GioiThieu = "“Ngon” đó là cảm giác đầu tiên khi ăn thử món miến này. Vị chua vừa phải kết hợp cùng độ cay nồng kích thích vị giác làm dậy lên vị ngon đến lạ kỳ. ",
                    Anh ="mien.jpg",
                    GiaTien = 80.000f,
                    MaLoai = 4
                    },
                      new SanPham
                {
                   MaSP= 11,
                    TenSP = "Bim Bim",
                    GioiThieu = "Món ăn vặt gắn liền với bao thế hệ ",
                    Anh ="nc.png",
                    GiaTien = 60.500f,
                    MaLoai = 4
                    },
            };
            return SPs;
        }
    }
}