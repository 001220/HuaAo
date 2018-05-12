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
    public class RommBLL
    {
        //房间类型查询
        public static DataTable getTable() {
            return RoomDAL.getTable();
        }

        //餐台类型查询
        public static DataTable getTableMeal()
        {
            return RoomDAL.getTableMeal();
        }
        //餐台类型查询
        public static DataTable getTableMeal(string name)
        {
            return RoomDAL.getTableMeal(name);
        }
        //餐台动态查询
        public static DataTable getTableDT(string name)
        {
            return RoomDAL.getTableDT(name);
        }
        //餐台动态条件查询
        public static DataTable getTableDT(string name,int index)
        {
            return RoomDAL.getTableDT(name,index);
        }
        
        //下拉框查询
        public static DataTable getTableCmdBox(string name) {

            return RoomDAL.getTableCmdBox(name);
        }

        //添加房间
        public static int getAdd(RoomTypeModel room)
        {
            return RoomDAL.getAdd(room);
        }

        //修改
        public static int getUpdate(RoomTypeModel room)
        {
            return RoomDAL.getUpdate(room);
        }

        //删除
        public static int getDelete(RoomTypeModel room)
        {
            return RoomDAL.getDelete(room);
        }
        //编辑查询
        public static DataTable getTableEditor(RoomTypeModel room)
        {
            return RoomDAL.getTableEditor(room) ;
        }

        //添加餐桌
        public static int getAddMeal(TablesModel tables)
        {
            return RoomDAL.getAddMeal(tables);
        }

        //修改
        public static int getUpdateMeal(TablesModel tables)
        {
            return RoomDAL.getUpdateMeal(tables);
        }

        //删除
        public static int getDeleteMeal(TablesModel tables)
        {
            return RoomDAL.getDeleteMeal(tables);
        }


        //主界面的状态查询
        //总台数
        public static object getObjectZTS()
        {
            return RoomDAL.getObjectZTS();
        }
        //占用
        public static object getObjectZY()
        {
            return RoomDAL.getObjectZY();
        }

        //可用
        public static object getObjectKY()
        {
            return RoomDAL.getObjectKY();            
        }
        //预定
        public static object getObjectYD()
        {
            return RoomDAL.getObjectYD();            
        }
        //停用
        public static object getObjectTY()
        {
            return RoomDAL.getObjectTY();            
        }
        //上座率
        public static object getObjectSZL()
        {
            return RoomDAL.getObjectSZL();            
        }

        public static int getUpdateZT(TablesModel tables)
        {
            return RoomDAL.getUpdateZT(tables);
        }

        //开单查询
        public static DataTable getTableKD(TablesModel tables)
        {
            return RoomDAL.getTableKD(tables);
        }
    }
}
