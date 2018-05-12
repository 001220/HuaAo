using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace DAL
{
    public class adminsDAL
    {
        //管理员查询
        public static DataTable getTableAdmin()
        {
            string sql = @"select UserID '操作员编号',UserName '操作员登录名',UserPWD,UserCompellation '操作员姓名' from admins";
            return DBHelper.getTable(sql);
        }
        //商品查询
        public static DataTable getTableVip()
        {
            string sql = @"select VGID '会员编号',VGName '会员名称',VGDiscount '会员享受折扣' from VIPGrade";
            return DBHelper.getTable(sql);
        }

        //添加管理员
        public static int getAddAdmin(AdminsModel admin)
        {
            string sql = string.Format(@"insert into admins values('{0}','{1}','{2}')",admin.UserName1,admin.UserPwd1,admin.UserCompellation1);
            return DBHelper.getExecuteNonQuery(sql);
        }

        //修改
        public static int getUpdateAdmin(AdminsModel admin)
        {
            string sql = string.Format(@"update admins set UserName='{0}',UserPWD='{1}',UserCompellation='{2}' where UserID={3}", admin.UserName1, admin.UserPwd1, admin.UserCompellation1,admin.UserID1);
            return DBHelper.getExecuteNonQuery(sql);
        }

        //删除
        public static int getDeleteAdmin(AdminsModel admin)
        {
            string sql = string.Format(@"delete admins where UserID={0}",admin.UserID1);
            return DBHelper.getExecuteNonQuery(sql);
        }


        //添加会员等级
        public static int getAddVip(VipGradeModel vip)
        {
            string sql = string.Format(@"insert VIPGrade values('{0}','{1}')",vip.VGName1,vip.VGDiscount1);
            return DBHelper.getExecuteNonQuery(sql);
        }

        //修改
        public static int getUpdateVip(VipGradeModel vip)
        {
            string sql = string.Format(@"update VIPGrade set VGName='{0}',VGDiscount='{1}' where VGID={2}",vip.VGName1,vip.VGDiscount1,vip.VGID1);
            return DBHelper.getExecuteNonQuery(sql);
        }

        //删除
        public static int getDeleteVip(VipGradeModel vip)
        {
            string sql = string.Format(@"delete VIPGrade where VGID={0}",vip.VGID1);
            return DBHelper.getExecuteNonQuery(sql);
        }
        
    }
}
