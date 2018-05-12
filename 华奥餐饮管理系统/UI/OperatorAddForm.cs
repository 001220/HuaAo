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
    public partial class OperatorAddForm : Form
    {
        private AdminsModel admin;
        public OperatorAddForm()
        {
            InitializeComponent();
        }
        public OperatorAddForm(AdminsModel admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void OperatorAddForm_Load(object sender, EventArgs e)
        {
            //标题
            this.Text = "操作员添加";
            //密码替换符
            this.txtPwd.PasswordChar = '●';
            this.txtPwd2.PasswordChar = '●';

            if (admin.UserID1!=-1)
            {
                txtUserName.Text = admin.UserName1;
                txtPwd.Text = admin.UserPwd1;
                txtPwd2.Text = admin.UserPwd1;
                txtName.Text = admin.UserCompellation1;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (admin.UserID1==-1)
            {
                //新增
                if (txtPwd.Text.Trim()==txtPwd2.Text.Trim())
                {
                    string userName = txtUserName.Text.Trim();
                    string pwd = txtPwd.Text.Trim();
                    string pwd2 = txtPwd2.Text.Trim();
                    string name = txtName.Text.Trim();
                    AdminsModel admin2 = new AdminsModel(userName,pwd,name);
                    int result = adminsBLL.getAddAdmin(admin2);
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
                    MessageBox.Show("密码不一致！请重新输入！");
                }

            }
            else
            {
                 //修改

                if (txtPwd.Text.Trim() == txtPwd2.Text.Trim())
                {
                    string userName = txtUserName.Text.Trim();
                    string pwd = txtPwd.Text.Trim();
                    string pwd2 = txtPwd2.Text.Trim();
                    string name = txtName.Text.Trim();
                    AdminsModel admin2 = new AdminsModel(admin.UserID1, userName, pwd, name);
                    int result = adminsBLL.getUpdateAdmin(admin2);
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
                    MessageBox.Show("密码不一致！请重新输入！");
                }
                
            }
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
