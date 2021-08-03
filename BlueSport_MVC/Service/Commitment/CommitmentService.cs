using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport_MVC.Service.Commitment
{
    public class CommitmentService : ICommitmentService
    {
        public List<BlueSport_MVC.Models.CommitmentModel> GetCommitments()
        {
            var data = new List<Models.CommitmentModel>();
            data.Add(new Models.CommitmentModel()
            {
                Icon = "icon-chinhhang",
                Title = "Chính hãng 100%",
                Detail = "Hơn 100 thương hiệu nổi tiếng"
            });
            data.Add(new Models.CommitmentModel()
            {
                Icon = "icon-mpgiaohang",
                Title = "Miễn phí giao hàng",
                Detail = "Cho đơn hàng trên 500.000đ"
            });
            data.Add(new Models.CommitmentModel()
            {
                Icon = "icon-doi1",
                Title = "1 đổi 1 trong vòng 1 năm",
                Detail = "Tại 200 cửa hàng trên toàn quốc",
                PathText = "Xem chi tiết",
                PathUrl = "#"
            });
            data.Add(new Models.CommitmentModel()
            {
                TextIcon = "0%",
                Title = "Trả góp 0%",
                Detail = "Qua thẻ hoặc duyệt hồ sơ với mọi sản phẩm trên 1.5 triệu",
            });
            return data;
        }
    }
}
