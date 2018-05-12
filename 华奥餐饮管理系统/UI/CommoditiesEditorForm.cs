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
    public partial class CommoditiesEditorForm : Form
    {
        ProductsModel pm;
        public CommoditiesEditorForm()
        {
            InitializeComponent();
        }
        public CommoditiesEditorForm(ProductsModel pm)
        {
            this.pm = pm;
            InitializeComponent();
        }

        private void CommoditiesEditorForm_Load(object sender, EventArgs e)
        {
            //标题
            this.Text = "商品编辑";
            //加载
            DataTable dt = ProductsBLL.getTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmdType.Items.Add(dt.Rows[i]["商品类别名称"].ToString());
            }
            //默认选择第一个
            cmdType.SelectedIndex = 0;
            if (pm.ProductID1!=-1)
            {
                txtName.Text = pm.ProductName1;
                txtJp.Text = pm.ProductJP1;
                cmdType.Text = pm.PTID1;
                txtPrice.Text = pm.ProductPrice1.ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (pm.ProductID1==-1)
            {
                //新增
                string name = txtName.Text.Trim();
                string jp = txtJp.Text.Trim();
                string type = (cmdType.SelectedIndex + 1).ToString();
                double price = Convert.ToDouble(txtPrice.Text.Trim());
                ProductsModel pm2 = new ProductsModel(name,type,jp,price);
                int result = ProductsBLL.getAddGoods(pm2);
                if (result > 0)
                {
                    MessageBox.Show("OK");
                    this.Close();
                    GoodsForm gf = new GoodsForm();
                    gf.Show();
                }
                else
                {
                    MessageBox.Show("NO");
                }
            }
            else
            {
                //修改
                string name = txtName.Text.Trim();
                string jp = txtJp.Text.Trim();
                string type = (cmdType.SelectedIndex + 1).ToString();
                double price = Convert.ToDouble(txtPrice.Text.Trim());
                ProductsModel pm2 = new ProductsModel(pm.ProductID1,name, type, jp, price);
                int result = ProductsBLL.getUpdateGoods(pm2);
                if (result > 0)
                {
                    MessageBox.Show("OK");
                    this.Close();
                    GoodsForm gf = new GoodsForm();
                    gf.Show();
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
