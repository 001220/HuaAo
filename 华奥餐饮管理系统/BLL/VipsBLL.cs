using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using DAL;

namespace BLL
{
    public class VipsBLL
    {

        //会员查询
        public static DataTable getTableVip()
        {
            return VipsDAL.getTableVip();
        }
        //会员添加修改等级查询
        public static DataTable getTableVipIndex()
        {
            return VipsDAL.getTableVipIndex();
        }

        //会员插入等级查询
        public static object getTableVipIndex(string name)
        {
            return VipsDAL.getTableVipIndex(name);            
        }

        //添加管理员
        public static int getAddVip(VipsModel vip)
        {
            return VipsDAL.getAddVip(vip);
        }

        //修改
        public static int getUpdateVip(VipsModel vip)
        {
            return VipsDAL.getUpdateVip(vip);
        }

        //删除
        public static int getDeleteVip(VipsModel vip)
        {
            return VipsDAL.getDeleteVip(vip);
        }
        //查询
        public static DataTable getSelectVip(VipsModel vip)
        {
            return VipsDAL.getSelectVip(vip);
        }
        //结账查询
        public static DataTable getTableJZ() {
            return VipsDAL.getTableJZ();
        }
    }
}
