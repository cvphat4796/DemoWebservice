using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoWebservice.Models;
using QuanLyTuyenSinh.Models;
namespace QuanLyTuyenSinh.Models
{
    public class XacThucAttribute: AuthorizeAttribute
    {
        public string quyen { get; set; }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            //Lấy các ngưởi dùng đăng nhập từ Session
            SinhVien thiSinh = HttpContext.Current.Session["user"] as SinhVien;
            if (thiSinh != null)
            {
                //lấy danh sách quyền
                string[] listquyen = quyen.Split(',');
                //Xác thực quyền
                if (listquyen.FirstOrDefault(n => n.Contains(thiSinh.Sex)) != null)
                {
                    return true;
                }
            }
            //else if (admin != null)
            //{
            //    //lấy danh sách quyền
            //    string[] listquyen = quyen.Split(',');
            //    //Xác thực quyền
            //    if (listquyen.FirstOrDefault(n => n.Contains(admin.PQ_MASO)) != null)
            //    {
            //        return true;
            //    }
            //}
            //else if (soGD != null)
            //{
            //    //lấy danh sách quyền
            //    string[] listquyen = quyen.Split(',');
            //    //Xác thực quyền
            //    if (listquyen.FirstOrDefault(n => n.Contains(soGD.PQ_MASO)) != null)
            //    {
            //        return true;
            //    }
            //}

            return false;
        }

        //Nếu không có quyền thì về trang đăng nhập
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new ViewResult()
            {
                ViewName = "~/Views/TaiKhoan/DangNhap.cshtml"
            };
        }
    }
}