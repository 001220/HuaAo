using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace DAL
{
    public class VipsDAL
    {
        //会员查询
        public static DataTable getTableVip()
        {
            string sql = @"select VipID '会员编号',VipName '会员姓名',VipSex '性别',VGName '会员等级',VGDiscount '会员折扣率',VipTel '联系电话',CONVERT(varchar(10),VipStartDate,21) '办理日期',CONVERT(varchar(10),VipEndDate,21) '到期日期' from Vips vs join VIPGrade vg on vs.GradeID=vg.VGID";
            return DBHelper.getTable(sql);
        }

        //会员添加修改等级查询
        public static DataTable getTableVipIndex()
        {
            string sql = @"select VGID,VGName from VIPGrade ";
            return DBHelper.getTable(sql);
        }

        //会员插入等级查询
        public static Object getTableVipIndex(string name)
        {
            string sql = string.Format(@"select VGID from VIPGrade where VGName='{0}'",name);
            return DBHelper.getExecuteScalar(sql);
        }

        //添加管理员
        public static int getAddVip(VipsModel vip)
        {
            string sql = string.Format(@"insert into Vips values('{0}','{1}',{2},'{3}','{4}','{5}')",vip.VipName1,vip.VipSex1,vip.GradeID1,vip.VipTel1,vip.VipStartDate1,vip.VipEndDate1);
            return DBHelper.getExecuteNonQuery(sql);
        }

        //修改
        public static int getUpdateVip(VipsModel vip)
        {
            string sql = string.Format(@"update Vips  set VipName='{0}',VipSex='{1}',GradeID={2},VipTel='{3}',VipEndDate='{4}' from  Vips where VipID = {5}",vip.VipName1,vip.VipSex1,vip.GradeID1,vip.VipTel1,vip.VipEndDate1,vip.VipID1);
            return DBHelper.getExecuteNonQuery(sql);
        }

        //删除
        public static int getDeleteVip(VipsModel vip)
        {
            string sql = string.Format(@"delete Vips where VipID={0}",vip.VipID1);
            return DBHelper.getExecuteNonQuery(sql);
        }

        //查询
        public static DataTable getSelectVip(VipsModel vip)
        {
            string sql = string.Format(@"select VipID '会员编号',VipName '会员姓名',VipSex '性别',VGName '会员等级',VGDiscount '会员折扣率',VipTel '联系电话',CONVERT(varchar(10),VipStartDate,21) '办理日期',CONVERT(varchar(10),VipEndDate,21) '到期日期' from Vips vs join VIPGrade vg on vs.GradeID=vg.VGID where VipID like '%{0}%' or VipName like '%{1}%'",vip.VipID21,vip.VipName1);
            return DBHelper.getTable(sql);
        }
          //结账查询
        public static DataTable getTableJZ() {
            string sql = string.Format(@"select VipName '姓名',VipSex '性别',VGName '等级',VGDiscount '折扣',case when  DATEDIFF(DAY,VipStartDate,VipEndDate)>0 then '可用' when DATEDIFF(DAY,VipStartDate,VipEndDate)<0 then '不可用' end as '状态',VipID from Vips vs join dbo.VIPGrade vg on vg.VGID=vs.GradeID");
            return DBHelper.getTable(sql);
        }
    }
}
