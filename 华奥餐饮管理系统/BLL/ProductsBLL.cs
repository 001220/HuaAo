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
    public class ProductsBLL
    {
        //商品类型查询
        public static DataTable getTable()
        {
            return ProductsDAL.getTable();
        }

        //商品类型查询
        public static DataTable getTableType()
        {
            return ProductsDAL.getTableMeal();
        }
        //下拉框查询
        public static DataTable getTableCmdBox(string name)
        {

            return ProductsDAL.getTableCmdBox(name);
        }

        //添加商品类型
        public static int getAddType(ProductTypeModel ptype)
        {
            return ProductsDAL.getAddType(ptype);
        }

        //修改
        public static int getUpdateType(ProductTypeModel ptype)
        {
            return ProductsDAL.getUpdateType(ptype);
        }

        //删除
        public static int getDeleteType(ProductTypeModel ptype)
        {
            return ProductsDAL.getDeleteType(ptype);
        }

        //添加商品
        public static int getAddGoods(ProductsModel pm)
        {
            return ProductsDAL.getAddGoods(pm);
        }

        //修改
        public static int getUpdateGoods(ProductsModel pm)
        {
            return ProductsDAL.getUpdateGoods(pm);
        }

        //删除
        public static int getDeleteGoods(ProductsModel pm)
        {
            return ProductsDAL.getDeleteGoods(pm);
        }
        //商品查询id
        public static DataTable getTableID(ProductsModel pm)
        {
            return ProductsDAL.getTableID(pm);
        }
    }
}
