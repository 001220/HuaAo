using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Data;

namespace BLL
{
    public class adminsBLL
    {
        //操作员查询
        public static DataTable getTableAdmin()
        {
            return adminsDAL.getTableAdmin();
        }

        //会员查询查询
        public static DataTable getTableVip()
        {
            return adminsDAL.getTableVip();
        }

        //添加管理员
        public static int getAddAdmin(AdminsModel admin)
        {
            return adminsDAL.getAddAdmin(admin);
        }

        //修改
        public static int getUpdateAdmin(AdminsModel admin)
        {
            return adminsDAL.getUpdateAdmin(admin);
        }

        //删除
        public static int getDeleteAdmin(AdminsModel admin)
        {
            return adminsDAL.getDeleteAdmin(admin);
        }

        //添加会员等级
        public static int getAddVip(VipGradeModel vip)
        {
            return adminsDAL.getAddVip(vip);
        }

        //修改
        public static int getUpdateVip(VipGradeModel vip)
        {
            return adminsDAL.getUpdateVip(vip);
        }

        //删除
        public static int getDeleteVip(VipGradeModel vip)
        {
            return adminsDAL.getDeleteVip(vip);
        }
    }
}
