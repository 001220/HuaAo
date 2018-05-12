using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace DAL
{
    public class ConsumerBillDAL
    {
        //项目清单
        public static DataTable getTableZD() {
            string sql = string.Format(@"select ProductJP,ProductName '项目名称',ProductPrice '单价',PTName '项目类别' from Products pd join ProductType pt on pd.PTID=pt.PTID");
            return DBHelper.getTable(sql);
        }

        //项目列表
        public static DataTable getTableLB(ProductTypeModel ptype)
        {
            string sql = string.Format(@"select ProductName '项目名称',ProductPrice '单价',PTName '项目类别' from Products pd join ProductType pt on pd.PTID=pt.PTID where pt.PTName='{0}'", ptype.PTName1);
            return DBHelper.getTable(sql);
        }

        //项目列表标题
        public static DataTable getTableLB()
        {
            string sql = string.Format(@"select * from dbo.ProductType");
            return DBHelper.getTable(sql);
        }
        //商品搜索
        public static DataTable getTableSS(ProductsModel pm)
        {
            string sql = string.Format(@"select ProductName '项目名称',ProductPrice '单价',PTName '项目类别' from Products pd join ProductType pt on pd.PTID=pt.PTID where ProductJP like '%{0}%'", pm.ProductJP1);
            return DBHelper.getTable(sql);
        }
        //商品搜索列表 
        public static DataTable getTableSSLB(ProductTypeModel ptype,ProductsModel pm)
        {
            string sql = string.Format(@"select ProductName '项目名称',ProductPrice '单价',PTName '项目类别' from Products pd join ProductType pt on pd.PTID=pt.PTID where pt.PTName='{0}' and pd.ProductJP like '%{1}%'",ptype.PTName1,pm.ProductJP1);
            return DBHelper.getTable(sql);
        }
         //开单
         public static int getInsert(ConsumerBillModel cbm){
             string sql = string.Format(@"insert into ConsumerBill values('{0}',{1},'{2}','{3}','{4}','{5}','{6}',{7},{8},{9})",cbm.CBID1,cbm.TableID1,cbm.CBAmount1,cbm.VipID1,cbm.CBDiscount1,cbm.CBStartDate1,cbm.CBEndDate1,cbm.AdminID1,cbm.CBSale1,cbm.CBClose1);
             //string sql = string.Format(@"insert into ConsumerBill values('{0}',{1},'{2}','{3}','{4}','{5}','{6}',{7},{8},{9})", cbm.CBID1, cbm.TableID1, cbm.CBAmount1, cbm.VipID1, cbm.CBDiscount1, cbm.CBStartDate1, cbm.CBEndDate1, cbm.CBSale1, cbm.CBClose1);             
             return DBHelper.getExecuteNonQuery(sql);
         }
        //查找未结账的编号
         public static DataTable getNo(ConsumerBillModel cbm)
         {
             string sql = string.Format(@"select CBID '账单编号',TableID '餐桌编号',CBAmount '顾客人数',VipID '会员编号',CBDiscount '会员折扣',CBStartDate '开单时间',CBEndDate '结账时间',AdminID '收银员编号',CBSale '消费金额',CBClose '结账' from ConsumerBill where TableID ={0} and CBClose={1}",cbm.TableID1,cbm.CBClose1);
             return DBHelper.getTable(sql);
         }

        //修改会员和折扣
         public static int getUpdateVip(ConsumerBillModel cbm) {
             string sql = string.Format(@"update ConsumerBill set VipID={0},CBDiscount={1} where CBID='{2}'",cbm.VipID1,cbm.CBDiscount1,cbm.CBID1);
             return DBHelper.getExecuteNonQuery(sql);
         }
        //修改是否结账
         public static int getUpdateJZ(ConsumerBillModel cbm)
         {
             string sql = string.Format(@"update ConsumerBill set CBEndDate='{0}',CBSale={1},CBClose=1 where CBID='{2}'",cbm.CBEndDate1,cbm.CBSale1,cbm.CBID1);
             return DBHelper.getExecuteNonQuery(sql);
         }

        //账单查询
         public static DataTable getZD()
         {
             string sql = string.Format(@"select cb.CBID '账单编号',cb.TableID '餐桌编号',CBEndDate '收款时间',CBSale '实收金额',(select SUM(CDMoney) from ConsumerDetail where CBID = cb.CBID) '消费金额',(CBSale-(select SUM(CDMoney) from ConsumerDetail where CBID = cb.CBID)) '优惠额度',VipName '会员名字' from ConsumerBill cb left join dbo.Vips vs on cb.VipID=vs.VipID");
             return DBHelper.getTable(sql);
         }
         //账单日查询
         public static DataTable getZDDay(int day)
         {
             string sql = string.Format(@"select cb.CBID '账单编号',cb.TableID '餐桌编号',CBEndDate '收款时间',CBSale '实收金额',(select SUM(CDMoney) from ConsumerDetail where CBID = cb.CBID) '消费金额',(CBSale-(select SUM(CDMoney) from ConsumerDetail where CBID = cb.CBID)) '优惠额度',VipName '会员名字' from ConsumerBill cb left join dbo.Vips vs on cb.VipID=vs.VipID where DATENAME(DAY,CBEndDate)={0}",day);
             return DBHelper.getTable(sql);
         }
         //账单月查询
         public static DataTable getZDMM(int MM)
         {
             string sql = string.Format(@"select cb.CBID '账单编号',cb.TableID '餐桌编号',CBEndDate '收款时间',CBSale '实收金额',(select SUM(CDMoney) from ConsumerDetail where CBID = cb.CBID) '消费金额',(CBSale-(select SUM(CDMoney) from ConsumerDetail where CBID = cb.CBID)) '优惠额度',VipName '会员名字' from ConsumerBill cb left join dbo.Vips vs on cb.VipID=vs.VipID where DATENAME(DAY,CBEndDate)>=7 and DATENAME(DAY,CBEndDate)<=13 and DATENAME(YYYY,CBEndDate)=2018 and DATENAME(MM,CBEndDate)={0}",MM);
             return DBHelper.getTable(sql);
         }
         //账单周查询
         public static DataTable getZDWeek(int yyyy,int MM,int startDay,int endDay)
         {
             string sql = string.Format(@"select cb.CBID '账单编号',cb.TableID '餐桌编号',CBEndDate '收款时间',CBSale '实收金额',(select SUM(CDMoney) from ConsumerDetail where CBID = cb.CBID) '消费金额',(CBSale-(select SUM(CDMoney) from ConsumerDetail where CBID = cb.CBID)) '优惠额度',VipName '会员名字' from ConsumerBill cb left join dbo.Vips vs on cb.VipID=vs.VipID where DATENAME(DAY,CBEndDate)>={0} and DATENAME(DAY,CBEndDate)<={1} and DATENAME(YYYY,CBEndDate)={2} and DATENAME(MM,CBEndDate)={3}", startDay, endDay,yyyy,MM);
             return DBHelper.getTable(sql);
         }
        //条件查询
         public static DataTable getZDTJ(string startTime,string endTime,int index ,int no)
         {
             string sql = string.Format(@"select cb.CBID '账单编号',cb.TableID '餐桌编号',CBEndDate '收款时间',CBSale '实收金额',(select SUM(CDMoney) from ConsumerDetail where CBID = cb.CBID) '消费金额',(CBSale-(select SUM(CDMoney) from ConsumerDetail where CBID = cb.CBID)) '优惠额度',VipName '会员名字' from ConsumerBill cb left join dbo.Vips vs on cb.VipID=vs.VipID where CBStartDate>'{0}' and CBStartDate<'{1}' and AdminID={2} and TableID={3}",startTime,endTime,index,no);
             return DBHelper.getTable(sql);
         }
    
    }
}
