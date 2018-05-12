using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Model;
using BLL;


namespace UI
{
    public partial class FunctionForm : Form
    {
        string name;
        int id;
        
        public FunctionForm()
        {
            InitializeComponent();
        }

        public void FunctionForm_Load(object sender, EventArgs e)
        {
           //最大化
            this.WindowState = FormWindowState.Maximized;
            //禁止放大缩小
            this.MaximizeBox = false;
            #region 属性栏
            billing.Image = imageList1.Images[4];
            Insert.Image = imageList1.Images[0];
            settleAccounts.Image = imageList1.Images[7];
            vip.Image = imageList1.Images[5];
            inquire.Image = imageList1.Images[3];
            room.Image = imageList1.Images[2];
            commodity.Image = imageList1.Images[1];
            system.Image = imageList1.Images[6];
            tabControl2.Dock = DockStyle.Fill;
            #endregion
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
            this.Text = xnl[0].InnerText;
            //下标题
            this.tslName.Text = xnl[0].InnerText;
            //登录人
            this.tslDL.Text = "当前登录";
            this.tslDLName.Text = "";
            
            //启动总状态，5分钟一次
            timer2.Start();
            //总状态
            lblCount.Text = RommBLL.getObjectZTS().ToString();
            //占用
            lblZY.Text = RommBLL.getObjectZY().ToString();
            //可用
            lblKG.Text = RommBLL.getObjectKY().ToString();
            //预定
            lblYD.Text = RommBLL.getObjectYD().ToString();
            //停用
            lblTY.Text = RommBLL.getObjectTY().ToString();
            //上座率
            lblSZL.Text = RommBLL.getObjectSZL().ToString() + "%";
            
            //房间类型加载Room类型
            DataTable dt = RommBLL.getTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //创建子页
                TabPage tp = new TabPage();
                tp.Text = dt.Rows[i]["房间类型"].ToString();
                //创建ListView
                ListView lv = new ListView();                
                lv.Dock = DockStyle.Fill;
                DataTable dt2 = RommBLL.getTableDT(dt.Rows[i]["房间类型"].ToString());
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    lv.LargeImageList = imageList1;
                    ListViewItem lvi = new ListViewItem(dt2.Rows[j]["餐台名称"].ToString());
                    if (dt2.Rows[j]["餐台状态"].ToString()=="可用")
                    {
                        lvi.ImageIndex = 8;
                    }
                    else if (dt2.Rows[j]["餐台状态"].ToString()=="占用")
                    {
                        lvi.ImageIndex = 9;
                    }else if (dt2.Rows[j]["餐台状态"].ToString()=="预订")
                    {
                        lvi.ImageIndex = 10;
                    }
                    else if (dt2.Rows[j]["餐台状态"].ToString() == "停用")
                    {
                        lvi.ImageIndex = 11;
                    }
                    //if (dt2.Rows[j]["餐台状态"].ToString() == "可用")
                    //{
                    //    this.宾客结账ToolStripMenuItem.Enabled = false;
                    //    this.增加消费ToolStripMenuItem.Enabled = false;
                    //    this.顾客开单ToolStripMenuItem.Enabled = true;
                    //    this.顾客预订ToolStripMenuItem.Enabled = true;
                    //}
                    lvi.Name = dt2.Rows[j]["TableID"].ToString();
                    lvi.Tag = dt2.Rows[j]["餐台名称"].ToString();
                    lv.Items.Add(lvi);
                    
                }
                lv.DoubleClick += lv_DoubleClick;
                lv.Click += lv_Click;
                lv.ContextMenuStrip = this.contextMenuStrip1;
                tp.Controls.Add(lv);
                tabControl2.TabPages.Add(tp);

                //当前时间
                tslTime.Text = "当前时间";
                timer1.Start();
            }
        }

        void lv_DoubleClick(object sender, EventArgs e)
        {
            ListView listV = sender as ListView;
            string name = listV.SelectedItems[0].Tag.ToString();
            DataTable dt = RommBLL.getTableMeal(name);
            if (dt.Rows[0]["餐台状态"].ToString()=="可用")
            {
                TablesModel tables = new TablesModel();
                tables.TableName1 = name;
                tables.TableID1 = id;
                BillingForm bf = new BillingForm(tables,6);
                bf.Show();
            }
        }
        void lv_Click(object sender, EventArgs e)
        {
            ListView listV = sender as ListView;
            name = listV.SelectedItems[0].Tag.ToString();
            id = Convert.ToInt32(listV.SelectedItems[0].Name.ToString());
        }
         

        private void timer1_Tick(object sender, EventArgs e)
        {
            tslTime2.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //总状态
            lblCount.Text = RommBLL.getObjectZTS().ToString();
            //占用
            lblZY.Text = RommBLL.getObjectZY().ToString();
            //可用
            lblKG.Text = RommBLL.getObjectKY().ToString();
            //预定
            lblYD.Text = RommBLL.getObjectYD().ToString();
            //停用
            lblTY.Text = RommBLL.getObjectTY().ToString();
            //上座率
            lblSZL.Text = RommBLL.getObjectSZL().ToString() + "%";
        }

        private void 显示全部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.TabPages.Clear();
            //房间类型加载Room类型
            DataTable dt = RommBLL.getTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //创建子页
                TabPage tp = new TabPage();
                tp.Text = dt.Rows[i]["房间类型"].ToString();
                //创建ListView
                ListView lv = new ListView();
                lv.Dock = DockStyle.Fill;
                DataTable dt2 = RommBLL.getTableDT(dt.Rows[i]["房间类型"].ToString());
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    lv.LargeImageList = imageList1;
                    ListViewItem lvi = new ListViewItem(dt2.Rows[j]["餐台名称"].ToString());
                    if (dt2.Rows[j]["餐台状态"].ToString() == "可用")
                    {
                        lvi.ImageIndex = 8;
                    }
                    else if (dt2.Rows[j]["餐台状态"].ToString() == "占用")
                    {
                        lvi.ImageIndex = 9;
                    }
                    else if (dt2.Rows[j]["餐台状态"].ToString() == "预订")
                    {
                        lvi.ImageIndex = 10;
                    }
                    else if (dt2.Rows[j]["餐台状态"].ToString() == "停用")
                    {
                        lvi.ImageIndex = 11;
                    }
                    
                    lv.Items.Add(lvi);
                }
                lv.ContextMenuStrip = this.contextMenuStrip1;
                tp.Controls.Add(lv);
                tabControl2.TabPages.Add(tp);
            }
        }

        private void 显示预定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.TabPages.Clear();
            //房间类型加载Room类型
            DataTable dt = RommBLL.getTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //创建子页
                TabPage tp = new TabPage();
                tp.Text = dt.Rows[i]["房间类型"].ToString();
                //创建ListView
                ListView lv = new ListView();
                lv.Dock = DockStyle.Fill;
                DataTable dt2 = RommBLL.getTableDT(dt.Rows[i]["房间类型"].ToString(),2);
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    if (dt2.Rows[j]["餐台状态"].ToString() == "预订")
                    {
                        lv.LargeImageList = imageList1;
                        ListViewItem lvi = new ListViewItem(dt2.Rows[j]["餐台名称"].ToString());
                        if (dt2.Rows[j]["餐台状态"].ToString() == "可用")
                        {
                            lvi.ImageIndex = 8;
                        }
                        else if (dt2.Rows[j]["餐台状态"].ToString() == "占用")
                        {
                            lvi.ImageIndex = 9;
                        }
                        else if (dt2.Rows[j]["餐台状态"].ToString() == "预订")
                        {
                            lvi.ImageIndex = 10;
                        }
                        else if (dt2.Rows[j]["餐台状态"].ToString() == "停用")
                        {
                            lvi.ImageIndex = 11;
                        }
                        if (dt2.Rows[j]["餐台状态"].ToString() == "预订")
                        {
                            this.宾客结账ToolStripMenuItem.Enabled = true;
                            this.增加消费ToolStripMenuItem.Enabled = true;
                            this.顾客开单ToolStripMenuItem.Enabled = true;
                            this.顾客预订ToolStripMenuItem.Enabled = false;
                        }
                        lv.Items.Add(lvi);
                     }
                }
                lv.ContextMenuStrip = this.contextMenuStrip1;
                tp.Controls.Add(lv);
                tabControl2.TabPages.Add(tp);
            }
        }

        private void 显示停用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.TabPages.Clear();
            //房间类型加载Room类型
            DataTable dt = RommBLL.getTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //创建子页
                TabPage tp = new TabPage();
                tp.Text = dt.Rows[i]["房间类型"].ToString();
                //创建ListView
                ListView lv = new ListView();
                lv.Dock = DockStyle.Fill;
                DataTable dt2 = RommBLL.getTableDT(dt.Rows[i]["房间类型"].ToString(),3);
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    if (dt2.Rows[j]["餐台状态"].ToString() == "停用")
                    {
                        lv.LargeImageList = imageList1;
                        ListViewItem lvi = new ListViewItem(dt2.Rows[j]["餐台名称"].ToString());
                        if (dt2.Rows[j]["餐台状态"].ToString() == "可用")
                        {
                            lvi.ImageIndex = 8;
                        }
                        else if (dt2.Rows[j]["餐台状态"].ToString() == "占用")
                        {
                            lvi.ImageIndex = 9;
                        }
                        else if (dt2.Rows[j]["餐台状态"].ToString() == "预订")
                        {
                            lvi.ImageIndex = 10;
                        }
                        else if (dt2.Rows[j]["餐台状态"].ToString() == "停用")
                        {
                            lvi.ImageIndex = 11;
                        }
                        if (dt2.Rows[j]["餐台状态"].ToString() == "停用")
                        {
                            this.宾客结账ToolStripMenuItem.Enabled = false;
                            this.增加消费ToolStripMenuItem.Enabled = false;
                            this.顾客开单ToolStripMenuItem.Enabled = false;
                            this.顾客预订ToolStripMenuItem.Enabled = false;
                        }
                        lv.Items.Add(lvi);
                    }
                }
                lv.ContextMenuStrip = this.contextMenuStrip1;
                tp.Controls.Add(lv);
                tabControl2.TabPages.Add(tp);
            }
        }

        private void 显示占用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.TabPages.Clear();
            //房间类型加载Room类型
            DataTable dt = RommBLL.getTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //创建子页
                TabPage tp = new TabPage();
                tp.Text = dt.Rows[i]["房间类型"].ToString();
                //创建ListView
                ListView lv = new ListView();
                lv.Dock = DockStyle.Fill;
                DataTable dt2 = RommBLL.getTableDT(dt.Rows[i]["房间类型"].ToString(),1);
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    if (dt2.Rows[j]["餐台状态"].ToString() == "占用")
                    {
                        lv.LargeImageList = imageList1;
                        ListViewItem lvi = new ListViewItem(dt2.Rows[j]["餐台名称"].ToString());
                        if (dt2.Rows[j]["餐台状态"].ToString() == "可用")
                        {
                            lvi.ImageIndex = 8;
                        }
                        else if (dt2.Rows[j]["餐台状态"].ToString() == "占用")
                        {
                            lvi.ImageIndex = 9;
                        }
                        else if (dt2.Rows[j]["餐台状态"].ToString() == "预订")
                        {
                            lvi.ImageIndex = 10;
                        }
                        else if (dt2.Rows[j]["餐台状态"].ToString() == "停用")
                        {
                            lvi.ImageIndex = 11;
                        }
                        if (dt2.Rows[j]["餐台状态"].ToString() == "占用")
                        {
                            this.顾客开单ToolStripMenuItem.Enabled = false;
                            this.宾客结账ToolStripMenuItem.Enabled = true;
                            this.增加消费ToolStripMenuItem.Enabled = true;
                            this.顾客预订ToolStripMenuItem.Enabled = true;
                        }
                        lv.Items.Add(lvi);
                    }
                }
                lv.ContextMenuStrip = this.contextMenuStrip1;
                tp.Controls.Add(lv);
                tabControl2.TabPages.Add(tp);
            }
        }

        private void 显示可用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.TabPages.Clear();
            //房间类型加载Room类型
            DataTable dt = RommBLL.getTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //创建子页
                TabPage tp = new TabPage();
                tp.Text = dt.Rows[i]["房间类型"].ToString();
                //创建ListView
                ListView lv = new ListView();
                lv.Dock = DockStyle.Fill;
                DataTable dt2 = RommBLL.getTableDT(dt.Rows[i]["房间类型"].ToString(),0);
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    if (dt2.Rows[j]["餐台状态"].ToString() == "可用")
                    {
                        lv.LargeImageList = imageList1;
                        ListViewItem lvi = new ListViewItem(dt2.Rows[j]["餐台名称"].ToString());
                        if (dt2.Rows[j]["餐台状态"].ToString() == "可用")
                        {
                            lvi.ImageIndex = 8;
                        }
                        else if (dt2.Rows[j]["餐台状态"].ToString() == "占用")
                        {
                            lvi.ImageIndex = 9;
                        }
                        else if (dt2.Rows[j]["餐台状态"].ToString() == "预订")
                        {
                            lvi.ImageIndex = 10;
                        }
                        else if (dt2.Rows[j]["餐台状态"].ToString() == "停用")
                        {
                            lvi.ImageIndex = 11;
                        }
                        if (dt2.Rows[j]["餐台状态"].ToString() == "可用")
                        {
                            this.顾客开单ToolStripMenuItem.Enabled = true;
                            this.宾客结账ToolStripMenuItem.Enabled = false;
                            this.增加消费ToolStripMenuItem.Enabled = false;
                            this.顾客预订ToolStripMenuItem.Enabled = true;
                        }
                        lv.Items.Add(lvi);
                    }
                }
                lv.ContextMenuStrip = this.contextMenuStrip1;
                tp.Controls.Add(lv);
                tabControl2.TabPages.Add(tp);
            }
        }

        private void 列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.TabPages.Clear();
            //房间类型加载Room类型
            DataTable dt = RommBLL.getTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //创建子页
                TabPage tp = new TabPage();
                tp.Text = dt.Rows[i]["房间类型"].ToString();
                //创建ListView
                ListView lv = new ListView();
                lv.Dock = DockStyle.Fill;
                DataTable dt2 = RommBLL.getTableDT(dt.Rows[i]["房间类型"].ToString());
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    lv.LargeImageList = imageList1;
                    lv.View = View.Details;
                    ListViewItem lvi = new ListViewItem(dt2.Rows[j]["餐台名称"].ToString());
                    lvi.Name = dt2.Rows[j]["餐台名称"].ToString();                    
                    if (dt2.Rows[j]["餐台状态"].ToString() == "可用")
                    {
                        lvi.ImageIndex = 8;
                    }
                    else if (dt2.Rows[j]["餐台状态"].ToString() == "占用")
                    {
                        lvi.ImageIndex = 9;
                    }
                    else if (dt2.Rows[j]["餐台状态"].ToString() == "预订")
                    {
                        lvi.ImageIndex = 10;
                    }
                    else if (dt2.Rows[j]["餐台状态"].ToString() == "停用")
                    {
                        lvi.ImageIndex = 11;
                    }
                    
                    lv.Items.Add(lvi);
                }
                lv.ContextMenuStrip = this.contextMenuStrip1;
                tp.Controls.Add(lv);
                tabControl2.TabPages.Add(tp);
            }
        }

        private void 小图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.TabPages.Clear();
            //房间类型加载Room类型
            DataTable dt = RommBLL.getTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //创建子页
                TabPage tp = new TabPage();
                tp.Text = dt.Rows[i]["房间类型"].ToString();
                //创建ListView
                ListView lv = new ListView();
                lv.Dock = DockStyle.Fill;
                DataTable dt2 = RommBLL.getTableDT(dt.Rows[i]["房间类型"].ToString());
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    lv.LargeImageList = imageList1;
                    lv.View = View.SmallIcon;
                    ListViewItem lvi = new ListViewItem(dt2.Rows[j]["餐台名称"].ToString());
                    if (dt2.Rows[j]["餐台状态"].ToString() == "可用")
                    {
                        lvi.ImageIndex = 8;
                    }
                    else if (dt2.Rows[j]["餐台状态"].ToString() == "占用")
                    {
                        lvi.ImageIndex = 9;
                    }
                    else if (dt2.Rows[j]["餐台状态"].ToString() == "预订")
                    {
                        lvi.ImageIndex = 10;
                    }
                    else if (dt2.Rows[j]["餐台状态"].ToString() == "停用")
                    {
                        lvi.ImageIndex = 11;
                    }
                    
                    lv.Items.Add(lvi);
                }
                lv.ContextMenuStrip = this.contextMenuStrip1;
                tp.Controls.Add(lv);
                tabControl2.TabPages.Add(tp);
            }
        }

        private void 大图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.TabPages.Clear();
            //房间类型加载Room类型
            DataTable dt = RommBLL.getTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //创建子页
                TabPage tp = new TabPage();
                tp.Text = dt.Rows[i]["房间类型"].ToString();
                //创建ListView
                ListView lv = new ListView();
                lv.Dock = DockStyle.Fill;
                DataTable dt2 = RommBLL.getTableDT(dt.Rows[i]["房间类型"].ToString());
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    lv.LargeImageList = imageList1;
                    ListViewItem lvi = new ListViewItem(dt2.Rows[j]["餐台名称"].ToString());
                    if (dt2.Rows[j]["餐台状态"].ToString() == "可用")
                    {
                        lvi.ImageIndex = 8;
                    }
                    else if (dt2.Rows[j]["餐台状态"].ToString() == "占用")
                    {
                        lvi.ImageIndex = 9;
                    }
                    else if (dt2.Rows[j]["餐台状态"].ToString() == "预订")
                    {
                        lvi.ImageIndex = 10;
                    }
                    else if (dt2.Rows[j]["餐台状态"].ToString() == "停用")
                    {
                        lvi.ImageIndex = 11;
                    }
                    
                    lv.Items.Add(lvi);
                }
                lv.ContextMenuStrip = this.contextMenuStrip1;
                tp.Controls.Add(lv);
                tabControl2.TabPages.Add(tp);
            }
        }

        private void 顾客开单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = RommBLL.getTableMeal(name);
            if (dt.Rows[0]["餐台状态"].ToString() == "可用")
            {
                TablesModel tables = new TablesModel();
                tables.TableName1 = name;
                tables.TableID1 = id;
                BillingForm bf = new BillingForm(tables,6);
                bf.Show();
            }
        }

        private void 账单查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillForm bf = new BillForm();
            bf.Show();
        }
        //增加消费
        private void 增加消费ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablesModel tables = new TablesModel();
            tables.TableID1 = id;
            tables.TableName1 = name;
            //查询出当前餐桌得编号
            ConsumerBillModel cbm = new ConsumerBillModel();
            cbm.TableID1 = id;
            cbm.CBClose1 = 0;
            DataTable dt = ConsumerBillBLL.getNo(cbm);
            cbm.CBID1 = dt.Rows[0]["账单编号"].ToString();
            AddForm af = new AddForm(tables, cbm);
            af.Show();
        }
        //增加消费
        private void Insert_Click(object sender, EventArgs e)
        {
            TablesModel tables = new TablesModel();
            tables.TableID1 = id;
            tables.TableName1 = name;
            //查询出当前餐桌得编号
            ConsumerBillModel cbm = new ConsumerBillModel();
            cbm.TableID1 = id;
            cbm.CBClose1 = 0;
            DataTable dt = ConsumerBillBLL.getNo(cbm);
            cbm.CBID1 = dt.Rows[0]["账单编号"].ToString();
            AddForm af = new AddForm(tables,cbm);
            af.Show();
        }
        //顾客开单
        private void billing_Click(object sender, EventArgs e)
        {

        }
        //结账
        private void settleAccounts_Click(object sender, EventArgs e)
        {
            TablesModel tables = new TablesModel();
            tables.TableID1 = id;
            tables.TableName1 = name;
            //查询出当前餐桌得编号
            ConsumerBillModel cbm = new ConsumerBillModel();
            cbm.TableID1 = id;
            cbm.CBClose1 = 0;
            DataTable dt = ConsumerBillBLL.getNo(cbm);
            cbm.CBID1 = dt.Rows[0]["账单编号"].ToString();
            AccountsForm1 af = new AccountsForm1(cbm,tables);
            af.Show();
        }
        //结账
        private void 宾客结账ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablesModel tables = new TablesModel();
            tables.TableID1 = id;
            tables.TableName1 = name;
            //查询出当前餐桌得编号
            ConsumerBillModel cbm = new ConsumerBillModel();
            cbm.TableID1 = id;
            cbm.CBClose1 = 0;
            DataTable dt = ConsumerBillBLL.getNo(cbm);
            cbm.CBID1 = dt.Rows[0]["账单编号"].ToString();
            AccountsForm1 af = new AccountsForm1(cbm, tables);
            af.Show();
        }

        private void 商品消费查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
    }
}
