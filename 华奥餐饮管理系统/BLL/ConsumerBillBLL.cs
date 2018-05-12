using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
using DAL;

namespace BLL
{
     public class ConsumerBillBLL
    {
        //项目清单
        public static DataTable getTableZD()
        {
            return ConsumerBillDAL.getTableZD();
        }
        //项目列表标题
        public static DataTable getTableLB()
        {
            return ConsumerBillDAL.getTableLB();
        }
        //项目列表
        public static DataTable getTableLB(ProductTypeModel ptype)
        {
            return ConsumerBillDAL.getTableLB(ptype);
        }

         //商品搜索
        public static DataTable getTableSS(ProductsModel pm)
        {
            return ConsumerBillDAL.getTableSS(pm);
        }
        //商品搜索列表
        public static DataTable getTableSSLB(ProductTypeModel ptype,ProductsModel pm)
        {
            return ConsumerBillDAL.getTableSSLB(ptype,pm);
        }
         //开单
         public static int getInsert(ConsumerBillModel cbm){
             return ConsumerBillDAL.getInsert(cbm);
         }
         //查找未结账的编号
         public static DataTable getNo(ConsumerBillModel cbm)
         {
             return ConsumerBillDAL.getNo(cbm);
         }
         //修改会员和折扣
         public static int getUpdateVip(ConsumerBillModel cbm) {
             return ConsumerBillDAL.getUpdateVip(cbm);
         }
         //修改是否结账
         public static int getUpdateJZ(ConsumerBillModel cbm)
         {
             return ConsumerBillDAL.getUpdateJZ(cbm);
         }

         //账单查询
         public static DataTable getZD()
         {
             return ConsumerBillDAL.getZD();
         }
         //账单日查询
         public static DataTable getZDDay(int day)
         {
             return ConsumerBillDAL.getZDDay(day);
         }
         //账单月查询
         public static DataTable getZDMM(int MM)
         {
             return ConsumerBillDAL.getZDMM(MM);
         }
         //账单周查询
         public static DataTable getZDWeek(int yyyy, int MM, int startDay, int endDay)
         {
             return ConsumerBillDAL.getZDWeek(yyyy, MM, startDay, endDay);
         }

         //条件查询
         public static DataTable getZDTJ(string startTime, string endTime, int index, int no)
         {
             return ConsumerBillDAL.getZDTJ(startTime,endTime,index,no);
         }
    }
}
