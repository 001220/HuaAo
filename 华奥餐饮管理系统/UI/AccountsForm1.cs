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
using System.Xml;
using System.IO;

namespace UI
{
    public partial class AccountsForm1 : Form
    {
        private ConsumerBillModel cbm;
        private TablesModel tables;
        public AccountsForm1(ConsumerBillModel cbm,TablesModel tables)
        {
            this.cbm = cbm;
            this.tables = tables;
            InitializeComponent();
        }
        //结账
        private void button1_Click(object sender, EventArgs e)
        {
            
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
            string name = xnl[0].InnerText;

            //创建文件
            MessageBox.Show(string.Format("{0}.txt",lblNo.Text.Trim()));
            File.Create(@"" + lblNo.Text.Trim() + ".txt").Close();
            //创建文本
            string text = "---------"+name+"-----------\n";
            text += string.Format("账单编号：{0}",lblNo.Text);
            text += string.Format("\n餐桌编号：{0}",lblTableName.Text);
            text += string.Format("\n打印时间:{0}",DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            text += string.Format("\n--------------------------------------");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
            text += string.Format("\n消费项目@单价@数量@应收金额@优惠额度");
            text += string.Format("\n{0}@{1}@{2}@{3}@{4}",dataGridView1.Rows[i].Cells[1].Value.ToString(),dataGridView1.Rows[i].Cells[2].Value.ToString(),dataGridView1.Rows[i].Cells[6].Value.ToString(),dataGridView1.Rows[i].Cells[7].Value.ToString(),dataGridView1.Rows[i].Cells[5].Value.ToString());
            
            }
            text += string.Format("\n--------------------------------------");
            text += string.Format("\n消费总额{0}",lblMoney.Text.Trim());
            text += string.Format("\n优惠总额{0}",lblYMoney.Text.Trim());
            MessageBox.Show(text);
            //创建文件流
            FileStream fs = new FileStream(@"" + lblNo.Text.Trim() + ".txt", FileMode.Open);
            //创建读取对象，调用读取方法
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(text);
            //关闭资源
            sw.Close();
            fs.Close();

            //修改消费金额和优惠额度
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                MessageBox.Show(dataGridView1.Rows[j].Cells[5].Value.ToString());
                ConsumerDetailsModel cdm = new ConsumerDetailsModel();
                cdm.CBID1 = lblNo.Text.Trim();
                cdm.CDSale1 = Convert.ToDouble(dataGridView1.Rows[j].Cells[5].Value.ToString());
                cdm.CDMoney1 = Convert.ToDouble(dataGridView1.Rows[j].Cells[7].Value.ToString());
                ProductsModel pm = new ProductsModel();
                pm.ProductName1 = dataGridView1.Rows[j].Cells[1].Value.ToString();
                DataTable dt = ProductsBLL.getTableID(pm);
                pm.ProductID1 = Convert.ToInt32(dt.Rows[0]["ProductID"].ToString());
                ConsumerDetailsBLL.getUpdateXF(cdm,pm);
            }

            //修改餐桌状态以及
            string endTime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string money = lblMoney2.Text.Trim();
            string no = lblNo.Text.Trim();
            ConsumerBillModel cbm = new ConsumerBillModel();
            cbm.CBID1 = no;
            cbm.CBEndDate1 = endTime;
            cbm.CBSale1 = Convert.ToDouble(money);
            MessageBox.Show(cbm.CBSale1.ToString());
            ConsumerBillBLL.getUpdateJZ(cbm);

            //餐桌状态
            TablesModel tables = new TablesModel();
            tables.TableName1 = lblTableName.Text.Trim();
            tables.TableState1 = 0;
            int result = RommBLL.getUpdateZT(tables);
            if (result>0)
            {
                //new FunctionForm().FunctionForm_Load(null,null);
            }
        }

        private void AccountsForm1_Load(object sender, EventArgs e)
        {
            //标题
            this.Text = "宾客结账";
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
            //账单单号
            this.lblNo.Text = cbm.CBID1.ToString();
            //餐台
            this.lblTableName.Text = tables.TableName1;
            //加载消费列表
            ConsumerDetailsModel cdm = new ConsumerDetailsModel();
            cdm.CBID1 = cbm.CBID1;
            DataTable dt = ConsumerDetailsBLL.getTableJZ(cdm);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            //总计金额
            double sum = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dt.Rows[i]["应收金额"]);
            }
            //消费金额
            double sum2 = sum/Convert.ToDouble(lblBL.Text);
            lblMoney2.Text = sum2.ToString();
            //应收金额
            this.lblMoney.Text = sum.ToString();
            this.lblYMoney.Text = (sum2 - sum).ToString();
            //影藏会员
            this.panel1.Visible = false;
            DataTable dt2 = VipsBLL.getTableJZ();
            dataGridView2.DataSource = dt2;
            dataGridView2.Columns[5].Visible = false;
            
        }

        private void txtNo_MouseDown(object sender, MouseEventArgs e)
        {
            this.panel1.Visible = true;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //选择会员
            if (dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[4].Value.ToString() == "可用")
            {
                //会员名称
                lblName.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString();
                //会员级别
                lblTop.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value.ToString();
                //折扣比率
                lblBL.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[3].Value.ToString();
                //会员编号
                txtNo.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[5].Value.ToString();
                ConsumerBillModel cbm2 = new ConsumerBillModel();
                cbm2.CBID1 = cbm.CBID1;
                cbm2.VipID1 = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[5].Value.ToString();
                cbm2.CBDiscount1 = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[3].Value.ToString();
                int result = ConsumerBillBLL.getUpdateVip(cbm2);
                if (result > 0)
                {
                    this.panel1.Visible = false;
                    AccountsForm1_Load(null, null);
                }
            }
            else
            {
                MessageBox.Show("会员不可用！");
            }

        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            //取消
            this.panel1.Visible = false;
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            if (txtMoney.Text.Trim()=="")
            {
                txtMoney.Text = "0";
                double money = Convert.ToDouble(txtMoney.Text.Trim());
                double yMoney = Convert.ToDouble(lblMoney.Text.Trim());
                lblZMoney.Text = (money - yMoney).ToString();
                double zMoney = Convert.ToDouble(lblZMoney.Text.Trim());
                lblSMoney.Text = (money - zMoney).ToString();
            }
            else
            {
                double money = Convert.ToDouble(txtMoney.Text.Trim());
                double yMoney = Convert.ToDouble(lblMoney.Text.Trim());
                lblZMoney.Text = (money - yMoney).ToString();
                double zMoney = Convert.ToDouble(lblZMoney.Text.Trim());
                lblSMoney.Text = (money - zMoney).ToString();
            }
        }
    }
}
