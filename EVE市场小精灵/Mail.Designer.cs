namespace EVE市场小精灵
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_type = new System.Windows.Forms.Label();
            this.lab_pos = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lab_l2 = new System.Windows.Forms.Label();
            this.lab_l1 = new System.Windows.Forms.Label();
            this.lab_j2 = new System.Windows.Forms.Label();
            this.lab_j1 = new System.Windows.Forms.Label();
            this.lab_c1 = new System.Windows.Forms.Label();
            this.lab_c2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_type);
            this.groupBox1.Controls.Add(this.lab_pos);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "区域";
            // 
            // lab_type
            // 
            this.lab_type.AutoSize = true;
            this.lab_type.Location = new System.Drawing.Point(302, 23);
            this.lab_type.Name = "lab_type";
            this.lab_type.Size = new System.Drawing.Size(29, 12);
            this.lab_type.TabIndex = 1;
            this.lab_type.Text = "查看";
            // 
            // lab_pos
            // 
            this.lab_pos.AutoSize = true;
            this.lab_pos.Location = new System.Drawing.Point(11, 23);
            this.lab_pos.Name = "lab_pos";
            this.lab_pos.Size = new System.Drawing.Size(29, 12);
            this.lab_pos.TabIndex = 0;
            this.lab_pos.Text = "您在";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lab_c2);
            this.groupBox2.Controls.Add(this.lab_c1);
            this.groupBox2.Controls.Add(this.lab_l2);
            this.groupBox2.Controls.Add(this.lab_l1);
            this.groupBox2.Controls.Add(this.lab_j2);
            this.groupBox2.Controls.Add(this.lab_j1);
            this.groupBox2.Location = new System.Drawing.Point(13, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 87);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "价格";
            // 
            // lab_l2
            // 
            this.lab_l2.AutoSize = true;
            this.lab_l2.Location = new System.Drawing.Point(193, 52);
            this.lab_l2.Name = "lab_l2";
            this.lab_l2.Size = new System.Drawing.Size(23, 12);
            this.lab_l2.TabIndex = 3;
            this.lab_l2.Text = "卖:";
            // 
            // lab_l1
            // 
            this.lab_l1.AutoSize = true;
            this.lab_l1.Location = new System.Drawing.Point(193, 27);
            this.lab_l1.Name = "lab_l1";
            this.lab_l1.Size = new System.Drawing.Size(23, 12);
            this.lab_l1.TabIndex = 2;
            this.lab_l1.Text = "收:";
            // 
            // lab_j2
            // 
            this.lab_j2.AutoSize = true;
            this.lab_j2.Location = new System.Drawing.Point(13, 52);
            this.lab_j2.Name = "lab_j2";
            this.lab_j2.Size = new System.Drawing.Size(47, 12);
            this.lab_j2.TabIndex = 1;
            this.lab_j2.Text = "吉他卖:";
            // 
            // lab_j1
            // 
            this.lab_j1.AutoSize = true;
            this.lab_j1.Location = new System.Drawing.Point(13, 27);
            this.lab_j1.Name = "lab_j1";
            this.lab_j1.Size = new System.Drawing.Size(47, 12);
            this.lab_j1.TabIndex = 0;
            this.lab_j1.Text = "吉他收:";
            // 
            // lab_c1
            // 
            this.lab_c1.AutoSize = true;
            this.lab_c1.Location = new System.Drawing.Point(376, 27);
            this.lab_c1.Name = "lab_c1";
            this.lab_c1.Size = new System.Drawing.Size(35, 12);
            this.lab_c1.TabIndex = 4;
            this.lab_c1.Text = "差价:";
            // 
            // lab_c2
            // 
            this.lab_c2.AutoSize = true;
            this.lab_c2.Location = new System.Drawing.Point(376, 52);
            this.lab_c2.Name = "lab_c2";
            this.lab_c2.Size = new System.Drawing.Size(35, 12);
            this.lab_c2.TabIndex = 5;
            this.lab_c2.Text = "比例:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 170);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "EVE市场小精灵 By: Sir丶雨轩";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lab_type;
        private System.Windows.Forms.Label lab_pos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lab_l2;
        private System.Windows.Forms.Label lab_l1;
        private System.Windows.Forms.Label lab_j2;
        private System.Windows.Forms.Label lab_j1;
        private System.Windows.Forms.Label lab_c2;
        private System.Windows.Forms.Label lab_c1;
    }
}

