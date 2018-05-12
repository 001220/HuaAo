using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace DAL
{
    public class ProductsDAL
    {
        //商品类型查询
        public static DataTable getTable()
        {
            string sql = @"select PTID,PTName '商品类别名称' from dbo.ProductType";
            return DBHelper.getTable(sql);
        }
        //商品查询
        public static DataTable getTableMeal()
        {
            string sql = @"select ProductID,ProductName '商品名称',PTName '商品类别',ProductJP,ProductPrice '商品价格' from dbo.Products p join dbo.ProductType pt on p.PTID=pt.PTID";
            return DBHelper.getTable(sql);
        }
        //商品类型下拉框查询
        public static DataTable getTableCmdBox(string name)
        {
            string sql = "";
            if (name == "所有类别")
            {
                sql += "select ProductID,ProductName '商品名称',PTName '商品类别',ProductJP,ProductPrice '商品价格' from dbo.Products p join dbo.ProductType pt on p.PTID=pt.PTID";
            }
            else
            {
                sql += string.Format(@"select ProductID,ProductName '商品名称',PTName '商品类别',ProductJP,ProductPrice '商品价格' from dbo.Products p join dbo.ProductType pt on p.PTID=pt.PTID where PTName='{0}'", name);
            }
            return DBHelper.getTable(sql);
        }

        //添加商品类型
        public static int getAddType(ProductTypeModel ptype)
        {
            string sql = string.Format(@"insert into dbo.ProductType values('{0}')",ptype.PTName1);
            return DBHelper.getExecuteNonQuery(sql);
        }

        //修改
        public static int getUpdateType(ProductTypeModel ptype)
        {
            string sql = string.Format(@"update ProductType set PTName='{0}' where PTID={1}",ptype.PTName1,ptype.PTID1);
            return DBHelper.getExecuteNonQuery(sql);
        }

        //删除
        public static int getDeleteType(ProductTypeModel ptype)
        {
            string sql = string.Format(@"delete ProductType where PTID={0}",ptype.PTID1);
            return DBHelper.getExecuteNonQuery(sql);
        }

       


        //添加商品
        public static int getAddGoods(ProductsModel ptype)
        {
            string sql = string.Format(@"insert into Products values('{0}',{1},'{2}',{3})",ptype.ProductName1,ptype.PTID1,ptype.ProductJP1,ptype.ProductPrice1);
            return DBHelper.getExecuteNonQuery(sql);
        }

        //修改
        public static int getUpdateGoods(ProductsModel ptype)
        {
            string sql = string.Format(@"update Products set ProductName='{0}',PTID={1},ProductJP='{2}',ProductPrice={3} where ProductID={4}", ptype.ProductName1, ptype.PTID1, ptype.ProductJP1, ptype.ProductPrice1,ptype.ProductID1);
            return DBHelper.getExecuteNonQuery(sql);
        }

        //删除
        public static int getDeleteGoods(ProductsModel ptype)
        {
            string sql = string.Format(@"delete Products where ProductID={0}",ptype.ProductID1);
            return DBHelper.getExecuteNonQuery(sql);
        }

        //商品查询id
        public static DataTable getTableID(ProductsModel pm)
        {
            string sql = string.Format(@"select ProductID,ProductName '商品名称',PTName '商品类别',ProductJP,ProductPrice '商品价格' from dbo.Products p join dbo.ProductType pt on p.PTID=pt.PTID where ProductName='{0}'",pm.ProductName1);
            return DBHelper.getTable(sql);
        }
    }
}
