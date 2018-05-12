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
    public partial class EditingRoomForm : Form
    {

        RoomTypeModel room;
        public EditingRoomForm(RoomTypeModel room)
        {
            this.room = room; 
            InitializeComponent();
        }

        public EditingRoomForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            int minMoney = Convert.ToInt32(txtMin.Text.Trim());
            int flag = cb.Checked ? 1 : 0;
            int count = Convert.ToInt32(txtCount.Text.Trim());

            if (room.RTID1==-1)
            {
                //添加
                RoomTypeModel room2 = new RoomTypeModel(name, minMoney, flag, count);
                int result = RommBLL.getAdd(room2);
                if (result>0)
                {
                    MessageBox.Show("OK");
                }
                else
                {
                    MessageBox.Show("NO");
                }
            }
            else
            {
                //修改
                RoomTypeModel room2 = new RoomTypeModel(room.RTID1,name, minMoney, flag, count);
                int result = RommBLL.getUpdate(room2);
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

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditingRoomForm_Load(object sender, EventArgs e)
        {
            //房间类型编辑
            this.Text = "房间类型编辑";
            //修改
            if (room.RTName1!="" && room.RTID1 != -1)
            {
                DataTable dt = RommBLL.getTableEditor(room);
                txtName.Text = dt.Rows[0]["房间类型"].ToString();
                txtMin.Text = dt.Rows[0]["最低消费"].ToString();
                
                string flag = dt.Rows[0]["是否开启折扣"].ToString();
                txtCount.Text = dt.Rows[0]["容纳人数"].ToString();
                if (flag=="True")
                {
                    cb.Checked = true;
                }
                else
                {
                    cb.Checked = false;
                }

            }
        }
    }
}
