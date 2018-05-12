using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace DAL
{
    public class RoomDAL
    {
        //房间类型查询
        public static DataTable getTable() {
            string sql = "select RTID,RTName '房间类型',RTConsume '最低消费',RTIsDisCount '是否开启折扣',RTMount '容纳人数' from RoomType";
            return DBHelper.getTable(sql);
        }
        //餐桌查询
        public static DataTable getTableMeal()
        {
            string sql = "select TableID,TableName '餐台名称' ,RTName '房间类型',TableArea '所在区域',case [TableState] when 0 then '可用' when 1 then '占用' when 2 then '预订' when 3 then '停用' end as '餐台状态' from dbo.Tables t join  RoomType r on t.RTID=r.RTID";
            return DBHelper.getTable(sql);
        }
        //餐桌查询
        public static DataTable getTableMeal(string name)
        {
            string sql = string.Format("select TableID,TableName '餐台名称' ,RTName '房间类型',TableArea '所在区域',case [TableState] when 0 then '可用' when 1 then '占用' when 2 then '预订' when 3 then '停用' end as '餐台状态' from dbo.Tables t join  RoomType r on t.RTID=r.RTID where TableName='{0}'", name);
            return DBHelper.getTable(sql);
        }
        //餐桌动态查询
        public static DataTable getTableDT(string name)
        {
            string sql = string.Format(@"select TableID,TableName '餐台名称' ,RTName '房间类型',TableArea '所在区域',case [TableState] when 0 then '可用' when 1 then '占用' when 2 then '预订' when 3 then '停用' end as '餐台状态' from dbo.Tables t join  RoomType r on t.RTID=r.RTID where r.RTName='{0}'",name);
            return DBHelper.getTable(sql);
        }
        //餐桌动态条件查询
        public static DataTable getTableDT(string name,int index)
        {
            string sql = string.Format(@"select TableID,TableName '餐台名称' ,RTName '房间类型',TableArea '所在区域',case [TableState] when 0 then '可用' when 1 then '占用' when 2 then '预订' when 3 then '停用' end as '餐台状态' from dbo.Tables t join  RoomType r on t.RTID=r.RTID where r.RTName='{0}' and t.TableState={1}",name,index);
            return DBHelper.getTable(sql);
        }
        //房间类型下拉框查询
        public static DataTable getTableCmdBox(string name)
        {
            string sql="";
            if (name=="所有餐台")
            {
                sql += "select TableID,TableName '餐台名称' ,RTName '房间类型',TableArea '所在区域',case [TableState] when 0 then '可用' when 1 then '占用' when 2 then '预订' when 3 then '停用' end as '所在区域' from dbo.Tables t join  RoomType r on t.RTID=r.RTID";
            }
            else
            {
                sql += string.Format(@"select TableID,TableName '餐台名称' ,RTName '房间类型',TableArea '所在区域',case [TableState] when 0 then '可用' when 1 then '占用' when 2 then '预订' when 3 then '停用' end as '所在区域' from dbo.Tables t join  RoomType r on t.RTID=r.RTID where r.RTName='{0}'",name);
            }
            return DBHelper.getTable(sql);
        }

        //添加房间
        public static int getAdd(RoomTypeModel room)
        {
            string sql = string.Format(@"insert into dbo.RoomType values('{0}',{1},{2},{3})",room.RTName1,room.RTConsume1,room.RTIsDisCount1,room.RTMount1);
            return DBHelper.getExecuteNonQuery(sql);
        }

        //修改
        public static int getUpdate(RoomTypeModel room)
        {
            string sql = string.Format(@"update RoomType set RTName='{0}',RTConsume={1},RTIsDisCount={2},RTMount={3} where RTID={4}", room.RTName1,room.RTConsume1, room.RTIsDisCount1, room.RTMount1,room.RTID1);
            return DBHelper.getExecuteNonQuery(sql);
        }

        //删除
        public static int getDelete(RoomTypeModel room)
        {
            string sql = string.Format(@"delete dbo.RoomType where RTID={0}", room.RTID1);
            return DBHelper.getExecuteNonQuery(sql);
        }

        //房间类型编辑查询
        public static DataTable getTableEditor(RoomTypeModel room)
        {
            string sql = string.Format("select RTID,RTName '房间类型',RTConsume '最低消费',RTIsDisCount '是否开启折扣',RTMount '容纳人数' from RoomType where RTID={0}",room.RTID1);
            return DBHelper.getTable(sql);
        }


        //添加餐桌
        public static int getAddMeal(TablesModel tables)
        {
            string sql = string.Format(@"insert into dbo.Tables values('{0}',{1},'{2}',{3})",tables.TableName1,tables.RTID1,tables.TableArea1,tables.TableState1);
            return DBHelper.getExecuteNonQuery(sql);
        }

        //修改
        public static int getUpdateMeal(TablesModel tables)
        {
            string sql = string.Format(@"update dbo.Tables set TableName='{0}',RTID={1},TableArea='{2}',TableState={3} where TableID={4}",tables.TableName1,tables.RTID1,tables.TableArea1,tables.TableState1,tables.TableID1);
            return DBHelper.getExecuteNonQuery(sql);
        }

        //删除
        public static int getDeleteMeal(TablesModel tables)
        {
            string sql = string.Format(@"delete dbo.Tables where TableID={0}",tables.TableID1);
            return DBHelper.getExecuteNonQuery(sql);
        }



        //主界面的状态查询
         //总台数
        public static object getObjectZTS(){
            string sql = @"select COUNT(*) from Tables";
            return DBHelper.getExecuteScalar(sql);
        }
        //占用
        public static object getObjectZY()
        {
            string sql = @"select COUNT(*) from Tables where TableState=1";
            return DBHelper.getExecuteScalar(sql);
        }

        //可用
        public static object getObjectKY()
        {
            string sql = @"select COUNT(*) from Tables where TableState=0";
            return DBHelper.getExecuteScalar(sql);
        }
        //预定
        public static object getObjectYD()
        {
            string sql = @"select COUNT(*) from Tables where TableState=2";
            return DBHelper.getExecuteScalar(sql);
        }
        //停用
        public static object getObjectTY()
        {
            string sql = @"select COUNT(*) from Tables where TableState=3";
            return DBHelper.getExecuteScalar(sql);
        }
        //上座率
        public static object getObjectSZL()
        {
            string sql = @"select (select COUNT(*) from Tables where TableState=1)/(select CAST(COUNT(*) AS FLOAT) from Tables)*100 from Tables";
            return DBHelper.getExecuteScalar(sql);
        }
        //修改状态
        public static int getUpdateZT(TablesModel tables) {
            string sql = string.Format(@"update Tables set TableState={0} where TableName='{1}'",tables.TableState1,tables.TableName1);
            return DBHelper.getExecuteNonQuery(sql);
        }

        //开单查询
        public static DataTable getTableKD(TablesModel tables)
        {
            string sql = string.Format(@"select * from dbo.RoomType where RTID = (select RTID from Tables where TableName='{0}')",tables.TableName1);
            return DBHelper.getTable(sql);
        }

    }
}
