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
    public partial class AddForm : Form
    {
        TablesModel tables;
        TreeView tv;
        ConsumerBillModel cbm;
        public AddForm(TablesModel tables,ConsumerBillModel cbm)
        {
            this.tables = tables;
            this.cbm = cbm;
            InitializeComponent();
        }
       

        public AddForm()
        {
            InitializeComponent();
        }
        
        private void AddForm_Load(object sender, EventArgs e)
        {
            //标题
            this.Text = "增加消费";
            //桌号
            lblNo.Text = tables.TableName1;
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
            DataTable dt = ConsumerBillBLL.getTableZD();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            //禁止编辑
            dataGridView1.ReadOnly = true;
            //选中突出
            listView1.FullRowSelect = true;
            
            tv = new TreeView();
            tv.Dock = DockStyle.Fill;
            tv.ImageList = imageList1;
            //列表
            DataTable dt2 = ConsumerBillBLL.getTableLB();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                TreeNode root = new TreeNode(dt2.Rows[i]["PTName"].ToString());
                root.Name = dt2.Rows[i]["PTName"].ToString();
                root.ImageIndex = 0;
                tv.Nodes.Add(root);
                ProductTypeModel ptype = new ProductTypeModel();
                ptype.PTName1 = dt2.Rows[i]["PTName"].ToString();
                DataTable dt3 = ConsumerBillBLL.getTableLB(ptype);
                for (int j = 0; j < dt3.Rows.Count; j++)
                {
                    TreeNode node = new TreeNode(dt3.Rows[j]["项目名称"].ToString());
                    node.Name = dt3.Rows[j]["项目名称"].ToString();
                    node.ImageIndex = 1;
                    root.Nodes.Add(node);
                }
            }

            tabPage2.Controls.Add(tv);

            //数量
            txtCount.Text = "1";
            //加载消费列表
            DataTable dt4 = ConsumerDetailsBLL.getTableXF(tables.TableID1);
            for (int i = 0; i < dt4.Rows.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(dt4.Rows[i]["商品编号"].ToString());
                lvi.SubItems.Add(dt4.Rows[i]["单价"].ToString());
                lvi.SubItems.Add(dt4.Rows[i]["数量"].ToString());
                lvi.SubItems.Add(dt4.Rows[i]["金额"].ToString());
                lvi.SubItems.Add(dt4.Rows[i]["点单时间"].ToString());
                lvi.SubItems.Add(dt4.Rows[i]["项目类别"].ToString());
                lvi.SubItems.Add(dt4.Rows[i]["CDID"].ToString());                
                listView1.Items.Add(lvi);
            }
            //金额和数量
            getMoneyANDCount();
            //最后隐藏
            listView1.Columns[6].Width = 0;
        }

        
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            ProductsModel pm = new ProductsModel();
            pm.ProductJP1 = name;
            for (int i = 0; i < tv.Nodes.Count; i++)
            {
                if (tv.Nodes[i].Name.Contains(name))
                {
                    tv.Nodes[i].ImageIndex = 1;
                }
            }
            if (tabControl1.TabPages[0].Text=="项目清单")
            {
                DataTable dt = ConsumerBillBLL.getTableSS(pm);
                dataGridView1.DataSource = dt;
            }
            if (tabControl1.TabPages[1].Text=="项目列表")
            {
                tv.Nodes.Clear();
                //列表
                DataTable dt2 = ConsumerBillBLL.getTableLB();
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    TreeNode root = new TreeNode(dt2.Rows[i]["PTName"].ToString());
                    root.Name = dt2.Rows[i]["PTName"].ToString();
                    root.ImageIndex = 1;
                    tv.Nodes.Add(root);
                    ProductTypeModel ptype = new ProductTypeModel();
                    ptype.PTName1 = dt2.Rows[i]["PTName"].ToString();
                    DataTable dt3 = ConsumerBillBLL.getTableSSLB(ptype, pm);
                    for (int j = 0; j < dt3.Rows.Count; j++)
                    {
                        TreeNode node = new TreeNode(dt3.Rows[j]["项目名称"].ToString());
                        node.Name = dt3.Rows[j]["项目名称"].ToString();
                        root.Nodes.Add(node);
                    }
                }
                //tabPage2.Controls.Add(tv2);
            }
        }
        //选中显示
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            lblName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtCount.Text = "1";
        }
        //双击添加
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Test0");
            bool flag = true;
            string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string price = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string type = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            int count = Convert.ToInt32(txtCount.Text.Trim());
            string time = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            //listView1.ForeColor = Color.Red;
            int result = Convert.ToInt32(price) * count;
            if ( listView1.Items.Count==0)
            {
                ListViewItem lvi = new ListViewItem(name);
                lvi.SubItems.Add(price);
                lvi.SubItems.Add(count.ToString());
                lvi.SubItems.Add(result.ToString());
                lvi.SubItems.Add(time);
                lvi.SubItems.Add(type);
                lvi.SubItems[0].ForeColor = Color.Red;
                listView1.Items.Add(lvi);
                count--;
                //金额和数量
                getMoneyANDCount();
                    
            }
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if ( listView1.Items[i].SubItems[0].Text.ToString()==name)
                {
                    int result2 = Convert.ToInt32(listView1.Items[i].SubItems[3].Text) + Convert.ToInt32(price);
                    int result3 = Convert.ToInt32(listView1.Items[i].SubItems[2].Text) + count;
                    listView1.Items[i].SubItems[0].Text = name;
                    listView1.Items[i].SubItems[1].Text = price;
                    listView1.Items[i].SubItems[2].Text = result3.ToString();
                    listView1.Items[i].SubItems[3].Text = result2.ToString();
                    listView1.Items[i].SubItems[4].Text = time;
                    listView1.Items[i].SubItems[5].Text = type;
                    listView1.Items[i].ForeColor = Color.Red;
                    flag = false;
                    //金额和数量
                    getMoneyANDCount();
                    break;
                }
            }
            if (flag)
	        {
		            ListViewItem lvi2 = new ListViewItem(name);
                    lvi2.SubItems.Add(price);
                    lvi2.SubItems.Add(count.ToString());
                    lvi2.SubItems.Add(result.ToString());
                    lvi2.SubItems.Add(time);
                    lvi2.SubItems.Add(type);
                    lvi2.SubItems[0].ForeColor = Color.Red;
                    listView1.Items.Add(lvi2);
                    //金额和数量
                    getMoneyANDCount();
	        }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;
            string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            int price = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            string type = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            int count = Convert.ToInt32(txtCount.Text.Trim());
            string time = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            //listView1.ForeColor = Color.Red;
            int result = price * count;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if ( listView1.Items[i].SubItems[0].Text.ToString()==name)
                {
                    double result2 = (Convert.ToDouble(listView1.Items[i].SubItems[3].Text.ToString())+count * price);
                    int result3 = Convert.ToInt32(listView1.Items[i].SubItems[2].Text) + count;
                    listView1.Items[i].SubItems[0].Text = name;
                    listView1.Items[i].SubItems[1].Text = price.ToString();
                    listView1.Items[i].SubItems[2].Text = result3.ToString();
                    listView1.Items[i].SubItems[3].Text = result2.ToString();
                    listView1.Items[i].SubItems[4].Text = time;
                    listView1.Items[i].SubItems[5].Text = type;
                    listView1.Items[i].ForeColor = Color.Red;
                    flag = false;
                    //金额和数量
                    getMoneyANDCount();
                    break;
                }
            }

            if (flag)
            {
                    ListViewItem lvi = new ListViewItem(name);
                    lvi.SubItems.Add(price.ToString());
                    lvi.SubItems.Add(count.ToString());
                    lvi.SubItems.Add(result.ToString());
                    lvi.SubItems.Add(time);
                    lvi.SubItems.Add(type);
                    lvi.SubItems[0].ForeColor = Color.Red;
                    listView1.Items.Add(lvi);
                    getMoneyANDCount();
            }
        }
        private void getMoneyANDCount() {
            lblCount.Text = listView1.Items.Count.ToString();
            int money = 0;
            for (int l = 0; l < listView1.Items.Count; l++)
            {
                money += Convert.ToInt32(listView1.Items[l].SubItems[3].Text);

            }
            lblMoney.Text = money.ToString();
        }

        private void btnTC_Click(object sender, EventArgs e)
        {
            /*
                实现退菜原理：拿到要退菜得名称，去数据查看这个菜得数量，退菜退到下单得数量，每次减一
             * 
             */
            int count = -1;
            string name2 = "";
            //查询菜单和数量
            DataTable dt = ConsumerDetailsBLL.getTableXF(tables.TableID1);
            if (listView1.SelectedItems.Count>0)
            {
                if (listView1.SelectedItems[0].ForeColor==Color.Red)
                {
                    //为红色删除
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["商品编号"].ToString() == listView1.SelectedItems[0].SubItems[0].Text.ToString())
	                    {
		                    name2 = dt.Rows[i]["商品编号"].ToString();
                            //已经下单返回数量
                            count = Convert.ToInt32(dt.Rows[i]["数量"]);
                            break;
	                    }
                    }
                    if (name2 == listView1.SelectedItems[0].SubItems[0].Text.ToString())
                    {
                        
                        //数量减一，如果数量达到数据库数量，不能删除
                        if (listView1.SelectedItems[0].SubItems[2].Text.ToString() == count.ToString())
                        {
                            listView1.SelectedItems[0].ForeColor = Color.Black;
                            MessageBox.Show("不能退菜了了");
                        }
                        else
                        {
                            //减一
                            int result = Convert.ToInt32(listView1.SelectedItems[0].SubItems[2].Text.ToString());
                            listView1.SelectedItems[0].SubItems[2].Text = (result - 1).ToString();
                            if (listView1.SelectedItems[0].SubItems[2].Text.ToString() == count.ToString())
                            {
                                listView1.SelectedItems[0].ForeColor = Color.Black;
                            }
                            //金额发生变化
                            int money = Convert.ToInt32(listView1.SelectedItems[0].SubItems[3].Text) - Convert.ToInt32(listView1.SelectedItems[0].SubItems[1].Text);
                            listView1.SelectedItems[0].SubItems[3].Text = money.ToString();
                            int lblMoney2 = Convert.ToInt32(lblMoney.Text) - Convert.ToInt32(listView1.SelectedItems[0].SubItems[1].Text);
                            lblMoney.Text = lblMoney2.ToString();
                        }
                    }
                    else
                    {
                        //没有找到，数量是否到一，如果到了删除，否则数量减一
                        if (listView1.SelectedItems[0].SubItems[2].Text.ToString() == "1")
                        {
                            
                            int count2 = Convert.ToInt32(lblCount.Text) - 1;
                            lblCount.Text = count2.ToString();
                            //金额发生变化
                            int lblMoney2 = Convert.ToInt32(lblMoney.Text) - Convert.ToInt32(listView1.SelectedItems[0].SubItems[1].Text);
                            lblMoney.Text = lblMoney2.ToString();
                            listView1.Items.Remove(listView1.SelectedItems[0]);
                            MessageBox.Show("退菜成功！");
                        }
                        else
                        {
                            //减一
                            int result = Convert.ToInt32(listView1.SelectedItems[0].SubItems[2].Text.ToString());
                            listView1.SelectedItems[0].SubItems[2].Text = (result - 1).ToString();
                            if (listView1.SelectedItems[0].SubItems[2].Text.ToString() == count.ToString())
                            {
                                listView1.SelectedItems[0].ForeColor = Color.Black;
                            }
                            //金额发生变化
                            int money = Convert.ToInt32(listView1.SelectedItems[0].SubItems[3].Text) - Convert.ToInt32(listView1.SelectedItems[0].SubItems[1].Text);
                            listView1.SelectedItems[0].SubItems[3].Text = money.ToString();
                            int lblMoney2 = Convert.ToInt32(lblMoney.Text) - Convert.ToInt32(listView1.SelectedItems[0].SubItems[1].Text);
                            lblMoney.Text = lblMoney2.ToString();
                        }
                    }
                   
                }
                else
                {
                    //为黑色不删除
                    MessageBox.Show("此菜已经下单，无法退菜！");
                }
            }
            else
            {
                MessageBox.Show("请选择菜单");
            }
        }
        //保存
        private void button3_Click(object sender, EventArgs e)
        {
            //消费列表
            DataTable dt = ConsumerDetailsBLL.getTableXF(tables.TableID1);
           
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].ForeColor == Color.Red)
                {
                    //需小于数据库得行数
                    if (i<dt.Rows.Count)
                    {
                        //去数据库找到这个消费单号，存在删除重新添加
                        if (listView1.Items[i].SubItems[0].Text == dt.Rows[i]["商品编号"].ToString())
                        {
                            string id = listView1.Items[i].SubItems[6].Text;
                            ConsumerDetailsModel cdm2 = new ConsumerDetailsModel();
                            cdm2.CDID1 = Convert.ToInt32(id);
                            ConsumerDetailsBLL.getDeleteXF(cdm2);
                           // MessageBox.Show(id);
                        }
                    }
                    //MessageBox.Show(listView1.Items[i].SubItems[0].Text);
                    string name = listView1.Items[i].SubItems[0].Text;
                    int dMoney = Convert.ToInt32(listView1.Items[i].SubItems[1].Text);
                    int count = Convert.ToInt32(listView1.Items[i].SubItems[2].Text);
                    int money = Convert.ToInt32(listView1.Items[i].SubItems[3].Text);
                    string time = listView1.Items[i].SubItems[4].Text;
                    string type = listView1.Items[i].SubItems[5].Text;

                    int name2 = 0;
                    int type2 = 0;
                    //项目名称
                    DataTable dt2 = ConsumerDetailsBLL.getTableNameANDType(name);
                    //商品编号
                    name2 = Convert.ToInt32(dt2.Rows[0]["ProductID"]);
                    //消费类型
                    type2 = Convert.ToInt32(dt2.Rows[0]["PTID"]);  
                    //折扣
                    double zk = Convert.ToDouble(cbm.CBDiscount1);
                    //优惠额度
                    double money2 = money * zk;
                    //消费金额
                    double money3 = money - money2;
                    //MessageBox.Show(string.Format("{0}-{1}-{2}-{3}-{4}-{5}-{6}-{7}-----",cbm.CBID1,name2,dMoney,count,money2,money3,type2,time));
                    ConsumerDetailsModel cdm = new ConsumerDetailsModel(cbm.CBID1, name2, dMoney, count, money2, money3, type2, time);
                    int result = ConsumerDetailsBLL.getXFInsert(cdm);
                    //if (result>0)
                    //{
                    //    MessageBox.Show("OK");
                        
                    //}
                    //else
                    //{
                    //    MessageBox.Show("NO");
                    //}
                }
            }
            listView1.Items.Clear();
            AddForm_Load(null, null);
        } 
    }
}
