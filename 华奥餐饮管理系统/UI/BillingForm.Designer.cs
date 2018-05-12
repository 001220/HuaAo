namespace UI
{
    partial class BillingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblMinMoney = new System.Windows.Forms.Label();
            this.brnOK = new System.Windows.Forms.Button();
            this.btnNO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(68, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "餐台类型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(68, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "房间类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "顾客人数：";
            // 
            // cb
            // 
            this.cb.AutoSize = true;
            this.cb.Location = new System.Drawing.Point(70, 297);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(156, 16);
            this.cb.TabIndex = 1;
            this.cb.Text = "开单后立刻添加消费项目";
            this.cb.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(68, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "最低消费：";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(154, 244);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(214, 21);
            this.txtCount.TabIndex = 2;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("宋体", 11F);
            this.lblType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblType.Location = new System.Drawing.Point(226, 64);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(55, 15);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "label5";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("宋体", 11F);
            this.lblRoomType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRoomType.Location = new System.Drawing.Point(226, 122);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(55, 15);
            this.lblRoomType.TabIndex = 3;
            this.lblRoomType.Text = "label5";
            // 
            // lblMinMoney
            // 
            this.lblMinMoney.AutoSize = true;
            this.lblMinMoney.Font = new System.Drawing.Font("宋体", 11F);
            this.lblMinMoney.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMinMoney.Location = new System.Drawing.Point(226, 188);
            this.lblMinMoney.Name = "lblMinMoney";
            this.lblMinMoney.Size = new System.Drawing.Size(55, 15);
            this.lblMinMoney.TabIndex = 3;
            this.lblMinMoney.Text = "label5";
            // 
            // brnOK
            // 
            this.brnOK.Location = new System.Drawing.Point(206, 335);
            this.brnOK.Name = "brnOK";
            this.brnOK.Size = new System.Drawing.Size(75, 23);
            this.brnOK.TabIndex = 4;
            this.brnOK.Text = "确定";
            this.brnOK.UseVisualStyleBackColor = true;
            this.brnOK.Click += new System.EventHandler(this.brnOK_Click);
            // 
            // btnNO
            // 
            this.btnNO.Location = new System.Drawing.Point(293, 335);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(75, 23);
            this.btnNO.TabIndex = 4;
            this.btnNO.Text = "取消";
            this.btnNO.UseVisualStyleBackColor = true;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 382);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.brnOK);
            this.Controls.Add(this.lblMinMoney);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BillingForm";
            this.Text = "BillingForm";
            this.Load += new System.EventHandler(this.BillingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblMinMoney;
        private System.Windows.Forms.Button brnOK;
        private System.Windows.Forms.Button btnNO;
    }
}