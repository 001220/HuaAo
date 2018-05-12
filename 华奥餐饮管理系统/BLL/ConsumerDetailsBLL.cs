using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data;

namespace BLL
{
    public class ConsumerDetailsBLL
    {
        //消费列表
        public static DataTable getTableLB()
        {
            return ConsumerDetailsDAL.getTableLB();
        }
        //消费查询
        public static DataTable getTableXF(int index)
        {
            return ConsumerDetailsDAL.getTableXF(index);
        }
        //保存
        public static int getInsert(ConsumerDetailsModel sdm)
        {
            string sql = string.Format(@"insert into ConsumerDetail values('{0}',{1},{2},{3},{4},{5},{6},'{7}')", sdm.CBID1, sdm.ProductID1, sdm.CDPrice1, sdm.CDNum1, sdm.CDSale1, sdm.CDMoney1, sdm.CDType1, sdm.CDDate1);
            return DBHelper.getExecuteNonQuery(sql);
        }
        //删除
        public static int getDelete(ConsumerDetailsModel sdm)
        {
            return ConsumerDetailsDAL.getDelete(sdm);
        }

        //查询项目名称以及项目类别
        public static DataTable getTableNameANDType(string name)
        {
            return ConsumerDetailsDAL.getTableNameANDType(name);
        }
        //保存消费详细消费表
        public static int getXFInsert(ConsumerDetailsModel cdm)
        {
            return ConsumerDetailsDAL.getXFInsert(cdm);
        }

        //删除存在的再添加
        public static int getDeleteXF(ConsumerDetailsModel cdm)
        {
            string sql = string.Format(@"delete dbo.ConsumerDetail where CDID={0}", cdm.CDID1);
            return DBHelper.getExecuteNonQuery(sql);
        }
        //结账收费查询
        public static DataTable getTableJZ(ConsumerDetailsModel cdm)
        {
            return ConsumerDetailsDAL.getTableJZ(cdm);
        }
        //修改消费金额和优惠额度
        public static int getUpdateXF(ConsumerDetailsModel cdm,ProductsModel pm)
        {
            return ConsumerDetailsDAL.getUpdateXF(cdm,pm);
        }
        //消费查询
        public static DataTable getXF()
        {
            return ConsumerDetailsDAL.getXF();
        }
        //消费日查询
        public static DataTable getXFDay(int day)
        {
            return ConsumerDetailsDAL.getXFDay(day);
        }
        //消费月查询
        public static DataTable getXFMM(int MM)
        {
            return ConsumerDetailsDAL.getXFMM(MM);
        }
        //消费周查询
        public static DataTable getXFWeek(int yyyy, int MM, int startDay, int endDay)
        {
            return ConsumerDetailsDAL.getXFWeek(yyyy,MM,startDay,endDay);
        }
        //条件查询
        public static DataTable getXFTJ(string startTime, string endTime, int index, int no)
        {
            return ConsumerDetailsDAL.getXFTJ(startTime,endTime,index,no);
        }

    }
}
