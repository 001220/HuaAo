namespace UI
{
    partial class FunctionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunctionForm));
            this.tlpSx = new System.Windows.Forms.ToolStrip();
            this.billing = new System.Windows.Forms.ToolStripButton();
            this.Insert = new System.Windows.Forms.ToolStripButton();
            this.settleAccounts = new System.Windows.Forms.ToolStripButton();
            this.vip = new System.Windows.Forms.ToolStripButton();
            this.inquire = new System.Windows.Forms.ToolStripDropDownButton();
            this.账单查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品消费查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.room = new System.Windows.Forms.ToolStripButton();
            this.commodity = new System.Windows.Forms.ToolStripButton();
            this.system = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tlpZt = new System.Windows.Forms.ToolStrip();
            this.tslName = new System.Windows.Forms.ToolStripLabel();
            this.tslDL = new System.Windows.Forms.ToolStripLabel();
            this.tslDLName = new System.Windows.Forms.ToolStripLabel();
            this.tslTime = new System.Windows.Forms.ToolStripLabel();
            this.tslTime2 = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblSZL = new System.Windows.Forms.Label();
            this.lblTY = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblYD = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblKG = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblZY = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.宾客结账ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加消费ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.顾客开单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.顾客预订ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpFs = new System.Windows.Forms.ToolStrip();
            this.tsbZT = new System.Windows.Forms.ToolStripSplitButton();
            this.显示可用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示占用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示停用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示预定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbFS = new System.Windows.Forms.ToolStripSplitButton();
            this.大图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tlpSx.SuspendLayout();
            this.tlpZt.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tlpFs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpSx
            // 
            this.tlpSx.AutoSize = false;
            this.tlpSx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tlpSx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billing,
            this.Insert,
            this.settleAccounts,
            this.vip,
            this.inquire,
            this.room,
            this.commodity,
            this.system});
            this.tlpSx.Location = new System.Drawing.Point(0, 0);
            this.tlpSx.Name = "tlpSx";
            this.tlpSx.Size = new System.Drawing.Size(1408, 92);
            this.tlpSx.TabIndex = 0;
            this.tlpSx.Text = "toolStrip1";
            // 
            // billing
            // 
            this.billing.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.billing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.billing.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.billing.Name = "billing";
            this.billing.Size = new System.Drawing.Size(60, 89);
            this.billing.Text = "顾客开单";
            this.billing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.billing.Click += new System.EventHandler(this.billing_Click);
            // 
            // Insert
            // 
            this.Insert.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Insert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Insert.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(60, 89);
            this.Insert.Text = "增加消费";
            this.Insert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // settleAccounts
            // 
            this.settleAccounts.Image = ((System.Drawing.Image)(resources.GetObject("settleAccounts.Image")));
            this.settleAccounts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.settleAccounts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settleAccounts.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.settleAccounts.Name = "settleAccounts";
            this.settleAccounts.Size = new System.Drawing.Size(60, 89);
            this.settleAccounts.Text = "宾客结账";
            this.settleAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.settleAccounts.Click += new System.EventHandler(this.settleAccounts_Click);
            // 
            // vip
            // 
            this.vip.Image = ((System.Drawing.Image)(resources.GetObject("vip.Image")));
            this.vip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.vip.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.vip.Name = "vip";
            this.vip.Size = new System.Drawing.Size(60, 89);
            this.vip.Text = "会员管理";
            this.vip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // inquire
            // 
            this.inquire.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.账单查询ToolStripMenuItem,
            this.商品消费查询ToolStripMenuItem});
            this.inquire.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inquire.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inquire.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.inquire.Name = "inquire";
            this.inquire.Size = new System.Drawing.Size(69, 89);
            this.inquire.Text = "营业查询";
            this.inquire.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // 账单查询ToolStripMenuItem
            // 
            this.账单查询ToolStripMenuItem.Name = "账单查询ToolStripMenuItem";
            this.账单查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.账单查询ToolStripMenuItem.Text = "账单查询";
            this.账单查询ToolStripMenuItem.Click += new System.EventHandler(this.账单查询ToolStripMenuItem_Click);
            // 
            // 商品消费查询ToolStripMenuItem
            // 
            this.商品消费查询ToolStripMenuItem.Name = "商品消费查询ToolStripMenuItem";
            this.商品消费查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.商品消费查询ToolStripMenuItem.Text = "商品消费查询";
            this.商品消费查询ToolStripMenuItem.Click += new System.EventHandler(this.商品消费查询ToolStripMenuItem_Click);
            // 
            // room
            // 
            this.room.Image = ((System.Drawing.Image)(resources.GetObject("room.Image")));
            this.room.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.room.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.room.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(84, 89);
            this.room.Text = "房间餐桌管理";
            this.room.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // commodity
            // 
            this.commodity.Image = ((System.Drawing.Image)(resources.GetObject("commodity.Image")));
            this.commodity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.commodity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.commodity.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.commodity.Name = "commodity";
            this.commodity.Size = new System.Drawing.Size(60, 89);
            this.commodity.Text = "商品设置";
            this.commodity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // system
            // 
            this.system.Image = ((System.Drawing.Image)(resources.GetObject("system.Image")));
            this.system.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.system.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.system.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.system.Name = "system";
            this.system.Size = new System.Drawing.Size(60, 89);
            this.system.Text = "系统设置";
            this.system.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "db_update.png");
            this.imageList1.Images.SetKeyName(1, "folder_tar.png");
            this.imageList1.Images.SetKeyName(2, "kfm_home.png");
            this.imageList1.Images.SetKeyName(3, "kghostview.png");
            this.imageList1.Images.SetKeyName(4, "kteatime.png");
            this.imageList1.Images.SetKeyName(5, "Login Manager.png");
            this.imageList1.Images.SetKeyName(6, "run.png");
            this.imageList1.Images.SetKeyName(7, "Sign - Dollar.png");
            this.imageList1.Images.SetKeyName(8, "0.jpg");
            this.imageList1.Images.SetKeyName(9, "1.jpg");
            this.imageList1.Images.SetKeyName(10, "2.jpg");
            this.imageList1.Images.SetKeyName(11, "3.jpg");
            // 
            // tlpZt
            // 
            this.tlpZt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpZt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslName,
            this.tslDL,
            this.tslDLName,
            this.tslTime,
            this.tslTime2});
            this.tlpZt.Location = new System.Drawing.Point(0, 734);
            this.tlpZt.Name = "tlpZt";
            this.tlpZt.Size = new System.Drawing.Size(1408, 25);
            this.tlpZt.TabIndex = 2;
            this.tlpZt.Text = "toolStrip2";
            // 
            // tslName
            // 
            this.tslName.Name = "tslName";
            this.tslName.Size = new System.Drawing.Size(96, 22);
            this.tslName.Text = "toolStripLabel1";
            this.tslName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tslDL
            // 
            this.tslDL.Margin = new System.Windows.Forms.Padding(700, 1, 0, 2);
            this.tslDL.Name = "tslDL";
            this.tslDL.Size = new System.Drawing.Size(96, 22);
            this.tslDL.Text = "toolStripLabel2";
            // 
            // tslDLName
            // 
            this.tslDLName.Name = "tslDLName";
            this.tslDLName.Size = new System.Drawing.Size(96, 22);
            this.tslDLName.Text = "toolStripLabel3";
            // 
            // tslTime
            // 
            this.tslTime.Margin = new System.Windows.Forms.Padding(600, 1, 0, 2);
            this.tslTime.Name = "tslTime";
            this.tslTime.Size = new System.Drawing.Size(96, 17);
            this.tslTime.Text = "toolStripLabel4";
            // 
            // tslTime2
            // 
            this.tslTime2.Name = "tslTime2";
            this.tslTime2.Size = new System.Drawing.Size(96, 17);
            this.tslTime2.Text = "toolStripLabel5";
            this.tslTime2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(275, 642);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage1.Controls.Add(this.lblSZL);
            this.tabPage1.Controls.Add(this.lblTY);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.lblYD);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lblKG);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lblZY);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lblCount);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(267, 616);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "状态";
            // 
            // lblSZL
            // 
            this.lblSZL.AutoSize = true;
            this.lblSZL.Location = new System.Drawing.Point(98, 294);
            this.lblSZL.Name = "lblSZL";
            this.lblSZL.Size = new System.Drawing.Size(41, 12);
            this.lblSZL.TabIndex = 1;
            this.lblSZL.Text = "label2";
            // 
            // lblTY
            // 
            this.lblTY.AutoSize = true;
            this.lblTY.Location = new System.Drawing.Point(98, 252);
            this.lblTY.Name = "lblTY";
            this.lblTY.Size = new System.Drawing.Size(41, 12);
            this.lblTY.TabIndex = 1;
            this.lblTY.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "上 座 率：";
            // 
            // lblYD
            // 
            this.lblYD.AutoSize = true;
            this.lblYD.Location = new System.Drawing.Point(98, 201);
            this.lblYD.Name = "lblYD";
            this.lblYD.Size = new System.Drawing.Size(41, 12);
            this.lblYD.TabIndex = 1;
            this.lblYD.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "当前停用：";
            // 
            // lblKG
            // 
            this.lblKG.AutoSize = true;
            this.lblKG.Location = new System.Drawing.Point(98, 159);
            this.lblKG.Name = "lblKG";
            this.lblKG.Size = new System.Drawing.Size(41, 12);
            this.lblKG.TabIndex = 1;
            this.lblKG.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "当前预订：";
            // 
            // lblZY
            // 
            this.lblZY.AutoSize = true;
            this.lblZY.Location = new System.Drawing.Point(98, 116);
            this.lblZY.Name = "lblZY";
            this.lblZY.Size = new System.Drawing.Size(41, 12);
            this.lblZY.TabIndex = 1;
            this.lblZY.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "当前可供：";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(98, 74);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(41, 12);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "当前占用：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "餐台总数：";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("宋体", 18F);
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "餐桌总状态";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.宾客结账ToolStripMenuItem,
            this.增加消费ToolStripMenuItem,
            this.顾客开单ToolStripMenuItem,
            this.顾客预订ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 92);
            // 
            // 宾客结账ToolStripMenuItem
            // 
            this.宾客结账ToolStripMenuItem.Name = "宾客结账ToolStripMenuItem";
            this.宾客结账ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.宾客结账ToolStripMenuItem.Text = "宾客结账";
            this.宾客结账ToolStripMenuItem.Click += new System.EventHandler(this.宾客结账ToolStripMenuItem_Click);
            // 
            // 增加消费ToolStripMenuItem
            // 
            this.增加消费ToolStripMenuItem.Name = "增加消费ToolStripMenuItem";
            this.增加消费ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.增加消费ToolStripMenuItem.Text = "增加消费";
            this.增加消费ToolStripMenuItem.Click += new System.EventHandler(this.增加消费ToolStripMenuItem_Click);
            // 
            // 顾客开单ToolStripMenuItem
            // 
            this.顾客开单ToolStripMenuItem.Name = "顾客开单ToolStripMenuItem";
            this.顾客开单ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.顾客开单ToolStripMenuItem.Text = "顾客开单";
            this.顾客开单ToolStripMenuItem.Click += new System.EventHandler(this.顾客开单ToolStripMenuItem_Click);
            // 
            // 顾客预订ToolStripMenuItem
            // 
            this.顾客预订ToolStripMenuItem.Name = "顾客预订ToolStripMenuItem";
            this.顾客预订ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.顾客预订ToolStripMenuItem.Text = "顾客预订";
            // 
            // tlpFs
            // 
            this.tlpFs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpFs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbZT,
            this.tsbFS});
            this.tlpFs.Location = new System.Drawing.Point(275, 709);
            this.tlpFs.Name = "tlpFs";
            this.tlpFs.Size = new System.Drawing.Size(1133, 25);
            this.tlpFs.TabIndex = 4;
            this.tlpFs.Text = "toolStrip3";
            // 
            // tsbZT
            // 
            this.tsbZT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbZT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示可用ToolStripMenuItem,
            this.显示占用ToolStripMenuItem,
            this.显示停用ToolStripMenuItem,
            this.显示预定ToolStripMenuItem,
            this.显示全部ToolStripMenuItem});
            this.tsbZT.Image = ((System.Drawing.Image)(resources.GetObject("tsbZT.Image")));
            this.tsbZT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbZT.Name = "tsbZT";
            this.tsbZT.Size = new System.Drawing.Size(72, 22);
            this.tsbZT.Text = "过滤状态";
            // 
            // 显示可用ToolStripMenuItem
            // 
            this.显示可用ToolStripMenuItem.Name = "显示可用ToolStripMenuItem";
            this.显示可用ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.显示可用ToolStripMenuItem.Text = "显示可用";
            this.显示可用ToolStripMenuItem.Click += new System.EventHandler(this.显示可用ToolStripMenuItem_Click);
            // 
            // 显示占用ToolStripMenuItem
            // 
            this.显示占用ToolStripMenuItem.Name = "显示占用ToolStripMenuItem";
            this.显示占用ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.显示占用ToolStripMenuItem.Text = "显示占用";
            this.显示占用ToolStripMenuItem.Click += new System.EventHandler(this.显示占用ToolStripMenuItem_Click);
            // 
            // 显示停用ToolStripMenuItem
            // 
            this.显示停用ToolStripMenuItem.Name = "显示停用ToolStripMenuItem";
            this.显示停用ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.显示停用ToolStripMenuItem.Text = "显示停用";
            this.显示停用ToolStripMenuItem.Click += new System.EventHandler(this.显示停用ToolStripMenuItem_Click);
            // 
            // 显示预定ToolStripMenuItem
            // 
            this.显示预定ToolStripMenuItem.Name = "显示预定ToolStripMenuItem";
            this.显示预定ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.显示预定ToolStripMenuItem.Text = "显示预定";
            this.显示预定ToolStripMenuItem.Click += new System.EventHandler(this.显示预定ToolStripMenuItem_Click);
            // 
            // 显示全部ToolStripMenuItem
            // 
            this.显示全部ToolStripMenuItem.Name = "显示全部ToolStripMenuItem";
            this.显示全部ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.显示全部ToolStripMenuItem.Text = "显示全部";
            this.显示全部ToolStripMenuItem.Click += new System.EventHandler(this.显示全部ToolStripMenuItem_Click);
            // 
            // tsbFS
            // 
            this.tsbFS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbFS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.大图标ToolStripMenuItem,
            this.小图标ToolStripMenuItem,
            this.列表ToolStripMenuItem});
            this.tsbFS.Image = ((System.Drawing.Image)(resources.GetObject("tsbFS.Image")));
            this.tsbFS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFS.Name = "tsbFS";
            this.tsbFS.Size = new System.Drawing.Size(72, 22);
            this.tsbFS.Text = "查看方式";
            // 
            // 大图标ToolStripMenuItem
            // 
            this.大图标ToolStripMenuItem.Name = "大图标ToolStripMenuItem";
            this.大图标ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.大图标ToolStripMenuItem.Text = "大图标";
            this.大图标ToolStripMenuItem.Click += new System.EventHandler(this.大图标ToolStripMenuItem_Click);
            // 
            // 小图标ToolStripMenuItem
            // 
            this.小图标ToolStripMenuItem.Name = "小图标ToolStripMenuItem";
            this.小图标ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.小图标ToolStripMenuItem.Text = "小图标";
            this.小图标ToolStripMenuItem.Click += new System.EventHandler(this.小图标ToolStripMenuItem_Click);
            // 
            // 列表ToolStripMenuItem
            // 
            this.列表ToolStripMenuItem.Name = "列表ToolStripMenuItem";
            this.列表ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.列表ToolStripMenuItem.Text = "列表";
            this.列表ToolStripMenuItem.Click += new System.EventHandler(this.列表ToolStripMenuItem_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl2.Location = new System.Drawing.Point(275, 92);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1133, 617);
            this.tabControl2.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FunctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 759);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tlpFs);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tlpZt);
            this.Controls.Add(this.tlpSx);
            this.Name = "FunctionForm";
            this.Text = "FunctionForm";
            this.Load += new System.EventHandler(this.FunctionForm_Load);
            this.tlpSx.ResumeLayout(false);
            this.tlpSx.PerformLayout();
            this.tlpZt.ResumeLayout(false);
            this.tlpZt.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tlpFs.ResumeLayout(false);
            this.tlpFs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlpSx;
        private System.Windows.Forms.ToolStripButton billing;
        private System.Windows.Forms.ToolStripButton Insert;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripButton settleAccounts;
        private System.Windows.Forms.ToolStripButton vip;
        private System.Windows.Forms.ToolStripButton room;
        private System.Windows.Forms.ToolStripButton commodity;
        private System.Windows.Forms.ToolStripButton system;
        private System.Windows.Forms.ToolStrip tlpZt;
        private System.Windows.Forms.ToolStripLabel tslName;
        private System.Windows.Forms.ToolStripLabel tslDL;
        private System.Windows.Forms.ToolStripLabel tslDLName;
        private System.Windows.Forms.ToolStripLabel tslTime;
        private System.Windows.Forms.ToolStripLabel tslTime2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip tlpFs;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.Label lblSZL;
        private System.Windows.Forms.Label lblTY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblYD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblKG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblZY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSplitButton tsbZT;
        private System.Windows.Forms.ToolStripMenuItem 显示可用ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示占用ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示停用ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示预定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示全部ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton tsbFS;
        private System.Windows.Forms.ToolStripMenuItem 大图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列表ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 宾客结账ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加消费ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 顾客开单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 顾客预订ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripDropDownButton inquire;
        private System.Windows.Forms.ToolStripMenuItem 账单查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品消费查询ToolStripMenuItem;
    }
}