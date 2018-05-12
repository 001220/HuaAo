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
using System.Xml;

namespace UI
{
    public partial class SystemSettingsForm : Form
    {
        public SystemSettingsForm()
        {
            InitializeComponent();
        }

        private void SystemSettingsForm_Load(object sender, EventArgs e)
        {
            //标题
            this.Text = "系统设置";
            //管理员设置
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
            DataTable dt = adminsBLL.getTableAdmin();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[2].Visible = false;

            
            //会员等级设置
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
            DataTable dt2 = adminsBLL.getTableVip();
            dataGridView2.DataSource = dt2;

            //其他设置
            //读取XML文件
            //创建XML文件流
            XmlDocument doc = new XmlDocument();
            //加载xml
            doc.Load(@"setup.xml");
            //获得根节点
            XmlElement root = doc.DocumentElement;
            //获得子节点
            XmlNodeList xnl = root.ChildNodes;
            //标题
            txtTitle.Text = xnl[0].InnerText;
            //名称
            txtPJ.Text = xnl[1].InnerText;

        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            AdminsModel admin = new AdminsModel();
            admin.UserID1 = -1;
            OperatorAddForm of = new OperatorAddForm(admin);
            of.Show();
            this.Hide();
        }

        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int index = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                string userName = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                string pwd = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                string name = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                ProductTypeModel ptype = new ProductTypeModel(index, name);
                AdminsModel admin = new AdminsModel(index,userName,pwd,name);
                OperatorAddForm of = new OperatorAddForm(admin);
                of.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("请选择数据！");
            }
        }

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定删除该行数据？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int index = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                AdminsModel admin = new AdminsModel();
                admin.UserID1 = index;
                int result = adminsBLL.getDeleteAdmin(admin);
                if (result > 0)
                {
                    MessageBox.Show("OK");
                    SystemSettingsForm_Load(null,null);
                }
                else
                {
                    MessageBox.Show("NO");
                }
            }
        }

        //新增会员等级
        private void btnAddVip_Click(object sender, EventArgs e)
        {
            VipGradeModel vip = new VipGradeModel();
            vip.VGID1 = -1;
            MemberLevelEditorForm mef = new MemberLevelEditorForm(vip);
            mef.Show();
            this.Hide();
        }
        //修改
        private void btnUpdateVip_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count>0)
            {
                int index = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value);
                string top = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value.ToString();
                double zk = Convert.ToDouble(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value);
                VipGradeModel vip = new VipGradeModel(index, top, zk);
                MemberLevelEditorForm mef = new MemberLevelEditorForm(vip);
                mef.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("请选择数据！");
            }
            
        }
        //删除
        private void btnDeleteVip_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定删除该行数据？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int index = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value);
                VipGradeModel vip = new VipGradeModel();
                vip.VGID1 = index;
                int result = adminsBLL.getDeleteVip(vip);
                if (result > 0)
                {
                    MessageBox.Show("OK");
                    SystemSettingsForm_Load(null, null);
                }
                else
                {
                    MessageBox.Show("NO");
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string pj = txtPJ.Text.Trim();
            //设置XML文件
            //创建XML文件流
            XmlDocument doc = new XmlDocument();
            //加载xml
            doc.Load(@"setup.xml");
            //获得根节点
            XmlElement root = doc.DocumentElement;
            //获得子节点
            XmlNodeList xnl = root.ChildNodes;
            //标题
            xnl[0].InnerText = title;
            //名称
            xnl[1].InnerText = pj;
            doc.Save(@"setup.xml");
            MessageBox.Show("OK");
            
        }
    }
}
