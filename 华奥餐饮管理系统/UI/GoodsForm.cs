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
    public partial class GoodsForm : Form
    {
        public GoodsForm()
        {
            InitializeComponent();
        }

        private void GoodsForm_Load(object sender, EventArgs e)
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
            DataTable dt = ProductsBLL.getTable();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;

            //房间类型
            cmdType.Items.Add("所有类别");
            cmdType.SelectedIndex = 0;
            DataTable dt2 = ProductsBLL.getTable();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                cmdType.Items.Add(dt2.Rows[i]["商品类别名称"].ToString());
            }

            //餐桌设置
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
            DataTable dt3 = ProductsBLL.getTableType();
            dataGridView2.DataSource = dt3;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[3].Visible = false;

        }
        //下拉框值变查询
        private void cmdType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmdType.SelectedIndex;
            string name = cmdType.SelectedItem.ToString();
            DataTable dt = ProductsBLL.getTableCmdBox(name);
            dataGridView2.DataSource = dt;
        }

        //添加商品类型
        private void btnAddType_Click(object sender, EventArgs e)
        {
            ProductTypeModel ptype = new ProductTypeModel();
            ptype.PTID1 = -1;
            CommodityCategoryEditorForm cce = new CommodityCategoryEditorForm(ptype);
            cce.Show();
            this.Hide();
        }

        private void btnUpdateType_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count>0)
            {
                int index = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                string name = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                ProductTypeModel ptype = new ProductTypeModel(index,name);
                CommodityCategoryEditorForm cce = new CommodityCategoryEditorForm(ptype);
                cce.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("请选择数据！");
            }
        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定删除该行数据？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int index = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                ProductTypeModel ptype = new ProductTypeModel();
                ptype.PTID1 = index;
                int result = ProductsBLL.getDeleteType(ptype);
                if (result > 0)
                {
                    MessageBox.Show("OK");
                    cmdType.Items.Clear();
                    GoodsForm_Load(null,null);
                }
                else
                {
                    MessageBox.Show("NO");
                }
            }
        }

        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            ProductsModel pm = new ProductsModel();
            pm.ProductID1 = -1;
            CommoditiesEditorForm ce = new CommoditiesEditorForm(pm);
            ce.Show();
            this.Hide();
        }

        private void btnUpdateGoods_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count>0)
            {
                int index = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value);
                string name = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value.ToString();
                string jp = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[3].Value.ToString();
                string type = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value.ToString();
                double price = Convert.ToDouble(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[4].Value);
                ProductsModel pm = new ProductsModel(index,name,type,jp,price);
                CommoditiesEditorForm ce = new CommoditiesEditorForm(pm);
                ce.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("请选择数据！");
            }
        }

        private void btnDeleteGoods_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定删除该行数据？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr==DialogResult.Yes)
            {
                int index = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value);
                ProductsModel pm = new ProductsModel();
                pm.ProductID1 = index;
                int result = ProductsBLL.getDeleteGoods(pm);
                if (result > 0)
                {
                    MessageBox.Show("OK");
                    cmdType.Items.Clear();
                    GoodsForm_Load(null, null);
                }
                else
                {
                    MessageBox.Show("NO");
                }    
            }
        }
    }
}
