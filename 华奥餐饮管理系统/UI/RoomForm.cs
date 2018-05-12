using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;

namespace UI
{
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            //标题
            this.Text = "房间-餐台设置";
            //房间类型
            //背景
            dataGridView1.BackgroundColor = Color.White;
            //禁止添加
            dataGridView1.AllowUserToAddRows = false;
            //禁止调整列
            dataGridView1.AllowUserToResizeColumns = false;
            //禁止调整行
            dataGridView1.AllowUserToResizeRows = false;
            //取消头列
            dataGridView1.RowHeadersVisible = false;
            //禁止多选
            dataGridView1.MultiSelect = false;
            //加载数据
            DataTable dt = RommBLL.getTable();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;

            //房间类型
            cmdType.Items.Add("所有餐台");
            cmdType.SelectedIndex = 0;
            DataTable dt2 = RommBLL.getTable();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                cmdType.Items.Add(dt2.Rows[i]["房间类型"].ToString());
            }
            
            //餐桌设置
            //背景
            dataGridView2.BackgroundColor = Color.White;
            //禁止添加
            dataGridView2.AllowUserToAddRows = false;
            //禁止调整列
            dataGridView2.AllowUserToResizeColumns = false;
            //禁止调整行
            dataGridView2.AllowUserToResizeRows = false;
            //取消头列
            dataGridView2.RowHeadersVisible = false;
            //禁止多选
            dataGridView2.MultiSelect = false;
            //加载数据
            DataTable dt3 = RommBLL.getTableMeal();
            dataGridView2.DataSource = dt3;
            dataGridView2.Columns[0].Visible = false;

        }

        //下拉框值变查询
        private void cmdType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmdType.SelectedIndex;
            string name = cmdType.SelectedItem.ToString();
            DataTable dt = RommBLL.getTableCmdBox(name);
            dataGridView2.DataSource = dt;
        }
        //添加房间
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            RoomTypeModel room = new RoomTypeModel();
            room.RTID1 = -1;
            EditingRoomForm editing = new EditingRoomForm(room);
            editing.Show();
        }
        //修改房间
        private void btnUpdateRomm_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            string name = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            int minMoney = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value);
            int flag = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value);
            int count = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value);
            RoomTypeModel room = new RoomTypeModel(index,name,minMoney,flag,count);
            EditingRoomForm editing = new EditingRoomForm(room);
            editing.Show();
        }
        //删除房间
        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            RoomTypeModel room = new RoomTypeModel();
            room.RTID1 = index ;
            int result = RommBLL.getDelete(room);
            if (result>0)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("NO");
            }
            
        }
        //添加餐桌
        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            TablesModel tables = new TablesModel();
            tables.RTID1 = -1;
            TheTableEditorForm tableEditor = new TheTableEditorForm(tables);
            tableEditor.Show();

        }
        //修改餐桌
        private void btnUpdateMeal_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value);
            string name = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value.ToString();
            string area = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[3].Value.ToString();
            int start = 0;
            TablesModel tables = new TablesModel(index,name,0,area,start);
            TheTableEditorForm tableEditor = new TheTableEditorForm(tables);
            tableEditor.Show();
        }
        //删除餐桌
        private void btnDeleteMeal_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value);
            TablesModel tables = new TablesModel();
            tables.TableID1 = index;
            int result = RommBLL.getDeleteMeal(tables);
            if (result > 0)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("NO");
            }
        }
    }
}
