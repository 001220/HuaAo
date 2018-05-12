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
    public partial class BillingForm : Form
    {
        private TablesModel tables;
        private int admin;
        public BillingForm(TablesModel tables,int admin)
        {
            this.tables = tables;
            this.admin = admin;
            InitializeComponent();
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            //标题
            this.Text = "顾客开单";
            TablesModel tables2 = new TablesModel();
            tables2.TableName1 = tables.TableName1;
            DataTable dt = RommBLL.getTableKD(tables2);
            lblType.Text = tables.TableName1;
            lblRoomType.Text = dt.Rows[0]["RTName"].ToString();
            lblMinMoney.Text = dt.Rows[0]["RTConsume"].ToString();
        }

        private void brnOK_Click(object sender, EventArgs e)
        {

            TablesModel tables2 = new TablesModel();
            tables2.TableName1 = tables.TableName1;
            tables2.TableState1 = 1;
            int result = RommBLL.getUpdateZT(tables2);
            string count = txtCount.Text.Trim();
            if (result > 0)
            {
                MessageBox.Show("OK");
                if (cb.Checked)
                {
                    string no = "ZD" + DateTime.Now.ToString("yyyyMMddhhmm");
                    string time = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    ConsumerBillModel cbm = new ConsumerBillModel(no, tables.TableID1, count, "-1", "1", time, "", admin, Convert.ToDouble("0"), 0);
                    ConsumerBillBLL.getInsert(cbm);
                    AddForm af = new AddForm(tables,cbm);
                    af.Show();
                }
                else
                {
                    string no = "ZD" + DateTime.Now.ToString("yyyyMMddhhmm");
                    string time = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    ConsumerBillModel cbm = new ConsumerBillModel(no, tables.TableID1, count, "-1", "1", time, "", admin, Convert.ToDouble("0"), 0);
                    ConsumerBillBLL.getInsert(cbm);
                }

                FunctionForm ff = new FunctionForm();
                ff.FunctionForm_Load(null,null);
                this.Close();
            }
            else
            {
                MessageBox.Show("NO");
            }

        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
