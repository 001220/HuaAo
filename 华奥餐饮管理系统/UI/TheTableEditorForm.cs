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
    public partial class TheTableEditorForm : Form
    {
        TablesModel tables;
        public TheTableEditorForm()
        {
            InitializeComponent();
        }
        public TheTableEditorForm(TablesModel tables)
        {
            this.tables = tables;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tables.RTID1==-1)
            {
                //增加
                string name = txtName.Text.Trim();
                int type = cmdType.SelectedIndex + 1;
                string area = txtAdrees.Text.Trim();
                int start = 0;
                TablesModel tables2 = new TablesModel(name,type,area,start);
                int result = RommBLL.getAddMeal(tables2);
                if (result>0)
                {
                    MessageBox.Show("OK");
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
                int type = cmdType.SelectedIndex + 1;
                string area = txtAdrees.Text.Trim();
                int start = 0;
                TablesModel tables2 = new TablesModel(tables.TableID1,name,type,area,start);
                int result = RommBLL.getUpdateMeal(tables2);
                if (result > 0)
                {
                    MessageBox.Show("OK");
                }
                else
                {
                    MessageBox.Show("NO");
                }
                


            }
        }

        private void TheTableEditorForm_Load(object sender, EventArgs e)
        {
            //标题
            this.Text = "餐桌编辑";
            //加载下拉框
            DataTable dt2 = RommBLL.getTable();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                cmdType.Items.Add(dt2.Rows[i]["房间类型"].ToString());
            }
            txtName.Text = tables.TableName1;
            txtAdrees.Text = tables.TableArea1;
            cmdType.SelectedIndex = tables.RTID1;

        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
