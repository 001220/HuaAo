using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace DAL
{
    public class ConsumerDetailsDAL
    {
        //列表
        public static DataTable getTableLB() {
            string sql = string.Format(@"select ProductName '商品编号',CDPrice '单价',CDAmount '数量',CDMoney '金额',CDDate '点单时间',PTName '项目类别' from ConsumerDetail cd join Products ps on cd.ProdcutID=ps.ProductID join dbo.ProductType pt on ps.PTID=pt.PTID join dbo.ConsumerBill cb  on cb.CBID=cd.CBID");
            return DBHelper.getTable(sql);
        }
        //消费列表
        public static DataTable getTableXF(int index)//
        {
            string sql = string.Format(@"select ProductName '商品编号',CDPrice '单价',CDAmount '数量',CDMoney '金额',CDDate '点单时间',PTName '项目类别',CDID from ConsumerDetail cd join Products ps on cd.ProdcutID=ps.ProductID join dbo.ProductType pt on ps.PTID=pt.PTID join dbo.ConsumerBill cb  on cb.CBID=cd.CBID where TableID={0} and CBClose=0", index);
            return DBHelper.getTable(sql);
        }
        //保存
        public static int getInsert(ConsumerDetailsModel sdm) {
            string sql = string.Format(@"insert into ConsumerDetail values('{0}',{1},{2},{3},{4},{5},{6},'{7}')",sdm.CBID1,sdm.ProductID1,sdm.CDPrice1,sdm.CDNum1,sdm.CDSale1,sdm.CDMoney1,sdm.CDType1,sdm.CDDate1);
            return DBHelper.getExecuteNonQuery(sql);
        }
        //删除
        public static int getDelete(ConsumerDetailsModel sdm)
        {
            string sql = string.Format(@"delete ConsumerBill where CBID={0}",sdm.CBID1);
            return DBHelper.getExecuteNonQuery(sql);
        }

        //查询项目名称以及项目类别
        public static DataTable getTableNameANDType(string name)
        {
            string sql = string.Format(@"select ProductID,ProductName '商品名称',p.PTID,ProductJP,ProductPrice '商品价格' from Products p join dbo.ProductType pt on p.PTID=pt.PTID where ProductName='{0}'",name);
            return DBHelper.getTable(sql);
        }
        //保存消费详细消费表
        public static int getXFInsert(ConsumerDetailsModel cdm) {
            string sql = string.Format(@"insert into ConsumerDetail values('{0}',{1},{2},{3},{4},{5},{6},'{7}')",cdm.CBID1,cdm.ProductID1,cdm.CDPrice1,cdm.CDNum1,cdm.CDSale1,cdm.CDMoney1,cdm.CDType1,cdm.CDDate1);
            return DBHelper.getExecuteNonQuery(sql);
        }
        //删除存在的再添加
        public static int getDeleteXF(ConsumerDetailsModel cdm) {
            string sql = string.Format(@"delete dbo.ConsumerDetail where CDID={0}",cdm.CDID1);
            return DBHelper.getExecuteNonQuery(sql);
        }
        //结账收费查询
        public static DataTable getTableJZ(ConsumerDetailsModel cdm) {
            string sql = string.Format(@"select CDID,ProductName '商品项目',CDPrice '单价',CBDiscount '打折比率',(CBDiscount*CDPrice) '折后单价',(CDPrice*CDAmount)-((CBDiscount*CDPrice)*CDAmount) '打折金额',CDAmount '消费数量',((CBDiscount*CDPrice)*CDAmount) '应收金额',CDDate '消费时间'from ConsumerDetail cd join dbo.ConsumerBill cb on cb.CBID=cd.cbid join Products ps on ps.ProductID=cd.ProdcutID where cd.CBID = '{0}'", cdm.CBID1);
            return DBHelper.getTable(sql);
        }
        //修改消费金额和优惠额度
        public static int getUpdateXF(ConsumerDetailsModel cdm, ProductsModel pm)
        {
            string sql = string.Format(@"update ConsumerDetail set CDSale={0},CDMoney={1} where CBID='{2}' and ProdcutID={3}", cdm.CDSale1, cdm.CDMoney1, cdm.CBID1,pm.ProductID1);
            return DBHelper.getExecuteNonQuery(sql);
        }

        //消费查询
        public static DataTable getXF()
        {
            string sql = string.Format(@"select ProductName '消费项目',CDPrice '单价',CDAmount '消费数量',CDMoney '消费金额',CDSale '优惠金额',(CDMoney+CDSale) '实际金额',CDDate '消费时间' from ConsumerDetail cd join Products ps on cd.ProdcutID=ps.ProductID");
            return DBHelper.getTable(sql);
        }
        //消费日查询
        public static DataTable getXFDay(int day)
        {
            string sql = string.Format(@"select ProductName '消费项目',CDPrice '单价',CDAmount '消费数量',CDMoney '消费金额',CDSale '优惠金额',(CDMoney+CDSale) '实际金额',CDDate '消费时间' from ConsumerDetail cd join Products ps on cd.ProdcutID=ps.ProductID where DATENAME(DAY,CDDate)={0}", day);
            return DBHelper.getTable(sql);
        }
        //消费月查询
        public static DataTable getXFMM(int MM)
        {
            string sql = string.Format(@"select ProductName '消费项目',CDPrice '单价',CDAmount '消费数量',CDMoney '消费金额',CDSale '优惠金额',(CDMoney+CDSale) '实际金额',CDDate '消费时间' from ConsumerDetail cd join Products ps on cd.ProdcutID=ps.ProductID where DATENAME(MM,CDDate)={0}", MM);
            return DBHelper.getTable(sql);
        }
        //消费周查询
        public static DataTable getXFWeek(int yyyy, int MM, int startDay, int endDay)
        {
            string sql = string.Format(@"select ProductName '消费项目',CDPrice '单价',CDAmount '消费数量',CDMoney '消费金额',CDSale '优惠金额',(CDMoney+CDSale) '实际金额',CDDate '消费时间' from ConsumerDetail cd join Products ps on cd.ProdcutID=ps.ProductID where DATENAME(DAY,CDDate)>={0} and DATENAME(DAY,CDDate)<={1} and DATENAME(YYYY,CDDate)={2} and DATENAME(MM,CDDate)={3}", startDay, endDay, yyyy, MM);
            return DBHelper.getTable(sql);
        }

        //条件查询
        public static DataTable getXFTJ(string startTime, string endTime, int index, int no)
        {
            string sql = string.Format(@"select ProductName '消费项目',CDPrice '单价',CDAmount '消费数量',CDMoney '消费金额',CDSale '优惠金额',(CDMoney+CDSale) '实际金额',CDDate '消费时间' from ConsumerDetail cd join Products ps on cd.ProdcutID=ps.ProductID left join ConsumerBill cb on cb.CBID=cd.CBID where CDDate>='{0}' and CDDate<='{1}' and AdminID={2} and TableID={3}", startTime, endTime, index, no);
            return DBHelper.getTable(sql);
        }
       
    }
}
