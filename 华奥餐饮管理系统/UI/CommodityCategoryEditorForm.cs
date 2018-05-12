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
    public partial class CommodityCategoryEditorForm : Form
    {
        ProductTypeModel ptype;
        public CommodityCategoryEditorForm()
        {
            InitializeComponent();
        }
        public CommodityCategoryEditorForm(ProductTypeModel ptype)
        {
            this.ptype = ptype;
            InitializeComponent();
        }

        private void CommodityCategoryEditorForm_Load(object sender, EventArgs e)
        {
            this.Text = "商品类别编辑";
            if (ptype.PTID1!=-1)
            {
                txtType.Text = ptype.PTName1;
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ptype.PTID1==-1)
            {
                //新增
                string name = txtType.Text.Trim();
                ProductTypeModel ptype2 = new ProductTypeModel();
                ptype2.PTName1 = name;
                int result = ProductsBLL.getAddType(ptype2);
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
                string name = txtType.Text.Trim();
                ProductTypeModel ptype2 = new ProductTypeModel(ptype.PTID1,name);
                int result = ProductsBLL.getUpdateType(ptype2);
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
