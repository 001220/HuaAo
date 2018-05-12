using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TablesModel
    {
        public TablesModel()
        {

        }
        public TablesModel(int TableID,string TableName,int RTID, string TableArea,int TableState)
        {
            this.TableID = TableID;
            this.TableName = TableName;
            this.RTID = RTID;
            this.TableArea = TableArea;
            this.TableState = TableState;
        }
        public TablesModel(string TableName, int RTID, string TableArea, int TableState)
        {
            this.TableName = TableName;
            this.RTID = RTID;
            this.TableArea = TableArea;
            this.TableState = TableState;
        }
        private int TableID;

        public int TableID1
        {
            get { return TableID; }
            set { TableID = value; }
        }
        private string TableName;

        public string TableName1
        {
            get { return TableName; }
            set { TableName = value; }
        }
        private int RTID;

        public int RTID1
        {
            get { return RTID; }
            set { RTID = value; }
        }
        private string TableArea;

        public string TableArea1
        {
            get { return TableArea; }
            set { TableArea = value; }
        }
        private int TableState;

        public int TableState1
        {
            get { return TableState; }
            set { TableState = value; }
        }

    }
}
