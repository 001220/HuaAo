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
    public partial class MemberEditorForm : Form
    {
        private VipsModel vip;
        public MemberEditorForm()
        {
            InitializeComponent();
        }
        public MemberEditorForm(VipsModel vip)
        {
            this.vip = vip;
            InitializeComponent();
        }

        private void MemberEditorForm_Load(object sender, EventArgs e)
        {
            //标题
            this.Text = "会员编辑";
            if (vip.VipID1!=-1)
            {
                txtNo.Text = vip.VipID1.ToString();
                txtName.Text = vip.VipName1;
                txtTel.Text = vip.VipTel1; ;
                txtTop.Text = vip.GradeID1;
                txtSex.Text = vip.VipSex1;
                dtpTime.Text = vip.VipEndDate1;
            }
            //加载数据
            DataTable dt = VipsBLL.getTableVipIndex();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txtTop.Items.Add(dt.Rows[i]["VGName"].ToString());
            }
            //下拉框性别
            txtSex.Items.Add("男");
            txtSex.Items.Add("女");
            txtTop.SelectedIndex = 0;
            txtSex.SelectedIndex = 0;
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vip.VipID1==-1)
            {
                //新增
                string name = txtName.Text.Trim();
                string tel = txtTel.Text.Trim();
                string sex = txtSex.Text.Trim();
                string top = txtTop.Text.Trim();
                string index = VipsBLL.getTableVipIndex(top).ToString();
                string startTime = DateTime.Now.ToString("yyyy-MM-dd");
                string endTime2 = dtpTime.Text.Trim();
                string endTime = "";
                string[] time = endTime2.Split('.');
                for (int i = 0; i < time.Length; i++)
                {
                    endTime += time[i];
                }
                VipsModel vip2 = new VipsModel(name, sex, index, tel, startTime, endTime);
                int result = VipsBLL.getAddVip(vip2);
                if (result > 0)
                {
                    MessageBox.Show("OK");
                    this.Close();
                    MemberManagementForm mmf = new MemberManagementForm();
                    mmf.Show();
                }
                else
                {
                    MessageBox.Show("NO");
                }

            }
            else
            {
                //修改
                //新增
                string name = txtName.Text.Trim();
                string tel = txtTel.Text.Trim();
                string sex = txtSex.Text.Trim();
                string top = txtTop.Text.Trim();
                string index = VipsBLL.getTableVipIndex(top).ToString();
                string startTime = "";
                string endTime2 = dtpTime.Text.Trim();
                string endTime = "";
                string[] time = endTime2.Split('.');
                for (int i = 0; i < time.Length; i++)
                {
                    endTime += time[i];
                }
                VipsModel vip2 = new VipsModel(vip.VipID1,name, sex, index, tel, startTime, endTime);
                int result = VipsBLL.getUpdateVip(vip2);
                if (result > 0)
                {
                    MessageBox.Show("OK");
                    this.Close();
                    MemberManagementForm mmf = new MemberManagementForm();
                    mmf.Show();
                }
                else
                {
                    MessageBox.Show("NO");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
