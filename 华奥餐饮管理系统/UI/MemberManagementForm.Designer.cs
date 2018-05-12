namespace UI
{
    partial class MemberManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberManagementForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tpbAdd = new System.Windows.Forms.ToolStripButton();
            this.tpbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tpbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripLabel();
            this.tpbText = new System.Windows.Forms.ToolStripTextBox();
            this.tpbSelect = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(996, 535);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(988, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "会员基本信息维护";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 427);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "会员信息";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(976, 407);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tpbAdd,
            this.tpbUpdate,
            this.tpbDelete,
            this.toolStripTextBox1,
            this.tpbText,
            this.tpbSelect});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(982, 76);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tpbAdd
            // 
            this.tpbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tpbAdd.Image")));
            this.tpbAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tpbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tpbAdd.Name = "tpbAdd";
            this.tpbAdd.Size = new System.Drawing.Size(36, 73);
            this.tpbAdd.Text = "添加";
            this.tpbAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tpbAdd.Click += new System.EventHandler(this.tpbAdd_Click);
            // 
            // tpbUpdate
            // 
            this.tpbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tpbUpdate.Image")));
            this.tpbUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tpbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tpbUpdate.Name = "tpbUpdate";
            this.tpbUpdate.Size = new System.Drawing.Size(36, 73);
            this.tpbUpdate.Text = "修改";
            this.tpbUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tpbUpdate.Click += new System.EventHandler(this.tpbUpdate_Click);
            // 
            // tpbDelete
            // 
            this.tpbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tpbDelete.Image")));
            this.tpbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tpbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tpbDelete.Name = "tpbDelete";
            this.tpbDelete.Size = new System.Drawing.Size(36, 73);
            this.tpbDelete.Text = "删除";
            this.tpbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tpbDelete.Click += new System.EventHandler(this.tpbDelete_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(61, 73);
            this.toolStripTextBox1.Text = "编号/姓名";
            // 
            // tpbText
            // 
            this.tpbText.Name = "tpbText";
            this.tpbText.Size = new System.Drawing.Size(121, 76);
            // 
            // tpbSelect
            // 
            this.tpbSelect.Image = ((System.Drawing.Image)(resources.GetObject("tpbSelect.Image")));
            this.tpbSelect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tpbSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tpbSelect.Name = "tpbSelect";
            this.tpbSelect.Size = new System.Drawing.Size(36, 73);
            this.tpbSelect.Text = "查询";
            this.tpbSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tpbSelect.Click += new System.EventHandler(this.tpbSelect_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "advancedsettings.png");
            this.imageList1.Images.SetKeyName(1, "button_cancel.png");
            this.imageList1.Images.SetKeyName(2, "edit_add.png");
            this.imageList1.Images.SetKeyName(3, "viewmag.png");
            // 
            // MemberManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 535);
            this.Controls.Add(this.tabControl1);
            this.Name = "MemberManagementForm";
            this.Text = "MemberManagementForm";
            this.Load += new System.EventHandler(this.MemberManagementForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tpbAdd;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton tpbUpdate;
        private System.Windows.Forms.ToolStripButton tpbDelete;
        private System.Windows.Forms.ToolStripLabel toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox tpbText;
        private System.Windows.Forms.ToolStripButton tpbSelect;
    }
}