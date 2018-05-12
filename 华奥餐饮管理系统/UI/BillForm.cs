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
    public partial class BillForm : Form
    {
        int id;
        public BillForm()
        {
            InitializeComponent();
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            //标题
            this.Text = "账单查询";
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
            DataTable dt = ConsumerBillBLL.getZD();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[2].Width = 150;
            //消费详情
            DataTable dt2 = ConsumerDetailsBLL.getXF();
            dataGridView2.DataSource = dt2;
            //查询操作员
            DataTable dt3 = adminsBLL.getTableAdmin();
            cmbRen.DataSource = dt3;
            cmbRen.ValueMember = dt3.Columns["操作员编号"].ToString();
            cmbRen.DisplayMember = dt3.Columns["操作员姓名"].ToString();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button1,0,this.button1.Height);
        }

        //今天
        private void 今天ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(DateTime.Now.ToString("dd"));
            DataTable dt = ConsumerBillBLL.getZDDay(day);
            dataGridView1.DataSource = dt;
            DataTable dt2 = ConsumerDetailsBLL.getXFDay(day);
            dataGridView2.DataSource = dt2;
        }
        //昨天
        private void 昨天ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(DateTime.Now.ToString("dd"));
            time--;
            DataTable dt = ConsumerBillBLL.getZDDay(time);
            dataGridView1.DataSource = dt;
            DataTable dt2 = ConsumerDetailsBLL.getXFDay(time);
            dataGridView2.DataSource = dt2;
        }
        //前天
        private void 前天ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(DateTime.Now.ToString("dd"));
            time-=2;
            DataTable dt = ConsumerBillBLL.getZDDay(time);
            dataGridView1.DataSource = dt;
            DataTable dt2 = ConsumerDetailsBLL.getXFDay(time);
            dataGridView2.DataSource = dt2;
        }
        //本周
        private void 本周ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int startTime = 0;
            int endTime = 0;
            int year = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            int mm = Convert.ToInt32(DateTime.Now.ToString("MM"));
            string time = DateTime.Now.DayOfWeek.ToString();
            switch (time)
            {
                case "Monday":
                    startTime = Convert.ToInt32(DateTime.Now.ToString("dd")) - 0;
                    endTime = startTime + 6;

                    MessageBox.Show(startTime.ToString());
                    break;
                case "Tuesday":
                    startTime = Convert.ToInt32(DateTime.Now.ToString("dd")) - 1;
                    endTime = startTime + 6;
                    MessageBox.Show(startTime.ToString());
                    break;
                case "Wednesday":
                    startTime = Convert.ToInt32(DateTime.Now.ToString("dd")) - 2;
                    endTime = startTime + 6;
                    MessageBox.Show(startTime.ToString());
                    break;
                case "Thursday":
                    startTime = Convert.ToInt32(DateTime.Now.ToString("dd")) - 3;
                    endTime = startTime + 6;
                    MessageBox.Show(startTime.ToString());
                    break;
                case "Friday":
                    startTime = Convert.ToInt32(DateTime.Now.ToString("dd")) - 4;
                    endTime = startTime + 6;
                    MessageBox.Show(startTime.ToString());
                    MessageBox.Show(endTime.ToString());
                    break;
                case "Saturday":
                    startTime = Convert.ToInt32(DateTime.Now.ToString("dd")) - 5;
                    endTime = startTime + 6;
                    MessageBox.Show(startTime.ToString());
                    break;
                case "Sunday":
                    startTime = Convert.ToInt32(DateTime.Now.ToString("dd")) - 6;
                    endTime = startTime + 6;
                    MessageBox.Show(startTime.ToString());
                    break;
                default:
                    break;
            }
            DataTable dt = ConsumerBillBLL.getZDWeek(year, mm, startTime, endTime);
            dataGridView1.DataSource = dt;
            DataTable dt2 = ConsumerDetailsBLL.getXFWeek(year, mm, startTime, endTime);
            dataGridView2.DataSource = dt2;
        }
        //本月
        private void 本月ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(DateTime.Now.ToString("MM"));
            DataTable dt = ConsumerBillBLL.getZDMM(time);
            dataGridView1.DataSource = dt;
            DataTable dt2 = ConsumerDetailsBLL.getXFMM(time);
            dataGridView2.DataSource = dt2;
        }
        //上月
        private void 上月ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(DateTime.Now.ToString("MM"));
            time--;
            DataTable dt = ConsumerBillBLL.getZDMM(time);
            dataGridView1.DataSource = dt;
            DataTable dt2 = ConsumerDetailsBLL.getXFMM(time);
            dataGridView2.DataSource = dt2;
        }
        //所有时间
        private void 所有时间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = ConsumerBillBLL.getZD();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[2].Width = 150;
            //消费详情
            DataTable dt2 = ConsumerDetailsBLL.getXF();
            dataGridView2.DataSource = dt2;
        }
        //条件查询
        private void button2_Click(object sender, EventArgs e)
        {
            string startTime = txtStartTime.Text.Trim();
            string endTime = txtEndTime.Text.Trim();
            startTime += " "+mtbStartTime.Text.Trim();
            endTime += " "+mtbEndTime.Text.Trim();
            int index = id;
            int No = Convert.ToInt32(txtNo.Text.Trim());
            //MessageBox.Show(startTime+"   "+endTime+"   "+index+"   "+No);
            DataTable dt = ConsumerBillBLL.getZDTJ(startTime, endTime, index, No);
            dataGridView1.DataSource = dt;
            DataTable dt2 =ConsumerDetailsBLL.getXFTJ(startTime, endTime, index, No);
            dataGridView2.DataSource = dt2;
        }

        private void cmbRen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRen.SelectedValue.ToString() !="System.Data.DataRowView")
            {
                id = Convert.ToInt32(cmbRen.SelectedValue.ToString());                
            }
        }
        
    }
}
