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
    public partial class MemberLevelEditorForm : Form
    {
        private VipGradeModel vip;
        public MemberLevelEditorForm()
        {
            InitializeComponent();
        }
        public MemberLevelEditorForm(VipGradeModel vip)
        {
            this.vip = vip;
            InitializeComponent();
        }

        private void MemberLevelEditorForm_Load(object sender, EventArgs e)
        {
            //标题
            this.Text = "会员等级编辑";
            if (vip.VGID1!=-1)
            {
                txtTop.Text = vip.VGName1;
                txtZk.Text = vip.VGDiscount1.ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (vip.VGID1==-1)
            {
                //新增
                string top = txtTop.Text.Trim();
                double zk = Convert.ToDouble(txtZk.Text.Trim());
                VipGradeModel vip2 = new VipGradeModel(top,zk);
                int result = adminsBLL.getAddVip(vip2);
                if (result > 0)
                {
                    MessageBox.Show("OK");
                    this.Close();
                    SystemSettingsForm ssf = new SystemSettingsForm();
                    ssf.Show();
                }
                else
                {
                    MessageBox.Show("NO");
                }
            }
            else
            {
                //修改
                string top = txtTop.Text.Trim();
                double zk = Convert.ToDouble(txtZk.Text.Trim());
                VipGradeModel vip2 = new VipGradeModel(vip.VGID1,top, zk);
                int result = adminsBLL.getUpdateVip(vip2);
                if (result > 0)
                {
                    MessageBox.Show("OK");
                    this.Close();
                    SystemSettingsForm ssf = new SystemSettingsForm();
                    ssf.Show();
                }
                else
                {
                    MessageBox.Show("NO");
                }
            }
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
