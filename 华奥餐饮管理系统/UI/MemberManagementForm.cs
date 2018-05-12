using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;


namespace UI
{
    public partial class MemberManagementForm : Form
    {
        public MemberManagementForm()
        {
            InitializeComponent();
        }

        private void MemberManagementForm_Load(object sender, EventArgs e)
        {
            //标题
            this.Text = "商品设置";
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
            DataTable dt = VipsBLL.getTableVip();
            dataGridView1.DataSource = dt;

            //相应图片赋值
            tpbAdd.Image = imageList1.Images[2];
            tpbUpdate.Image = imageList1.Images[0];
            tpbDelete.Image = imageList1.Images[1];
            tpbSelect.Image = imageList1.Images[3];
            

        }

        //增加
        private void tpbAdd_Click(object sender, EventArgs e)
        {
            VipsModel vip = new VipsModel();
            vip.VipID1 = -1;
            MemberEditorForm mef = new MemberEditorForm(vip);
            mef.Show();
            this.Hide();
        }

        //修改
        private void tpbUpdate_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            string name = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            string sex = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            string top = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            string tel = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            string startTime = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
            string endTime = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value.ToString();
            VipsModel vip = new VipsModel(index,name,sex,top,tel,startTime,endTime);
            MemberEditorForm mef = new MemberEditorForm(vip);
            mef.Show();
            this.Hide();
        }

        //删除
        private void tpbDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定删除该行数据？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int index = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                VipsModel vip = new VipsModel();
                vip.VipID1 = index;
                int result = VipsBLL.getDeleteVip(vip);
                if (result > 0)
                {
                    MessageBox.Show("OK");
                    MemberManagementForm_Load(null,null);
                }
                else
                {
                    MessageBox.Show("NO");
                }

            }
            
        }

        //查询
        private void tpbSelect_Click(object sender, EventArgs e)
        {
            string name = tpbText.Text.Trim();
            VipsModel vip = new VipsModel();
            vip.VipID21 = name;
            vip.VipName1 = name;
            DataTable dt = VipsBLL.getSelectVip(vip);
            dataGridView1.DataSource = dt;
        }
    }
}
