﻿namespace DAQNaviHelperDemo
{
    partial class frmDemo
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
            this.btnTest = new System.Windows.Forms.Button();
            this.btnGetAiData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAiStop = new System.Windows.Forms.Button();
            this.txtAiInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAiData = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDiSwitch = new System.Windows.Forms.Button();
            this.chkDiList = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkDoList = new System.Windows.Forms.CheckedListBox();
            this.btnDoSwitch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAiInterval)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnGetAiData
            // 
            this.btnGetAiData.Location = new System.Drawing.Point(185, 19);
            this.btnGetAiData.Name = "btnGetAiData";
            this.btnGetAiData.Size = new System.Drawing.Size(77, 23);
            this.btnGetAiData.TabIndex = 1;
            this.btnGetAiData.Text = "获取Ai数据";
            this.btnGetAiData.UseVisualStyleBackColor = true;
            this.btnGetAiData.Click += new System.EventHandler(this.btnGetAiData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAiStop);
            this.groupBox1.Controls.Add(this.txtAiInterval);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAiData);
            this.groupBox1.Controls.Add(this.btnGetAiData);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 168);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "模拟输入";
            // 
            // btnAiStop
            // 
            this.btnAiStop.Location = new System.Drawing.Point(268, 19);
            this.btnAiStop.Name = "btnAiStop";
            this.btnAiStop.Size = new System.Drawing.Size(44, 23);
            this.btnAiStop.TabIndex = 5;
            this.btnAiStop.Text = "停止";
            this.btnAiStop.UseVisualStyleBackColor = true;
            this.btnAiStop.Click += new System.EventHandler(this.btnAiStop_Click);
            // 
            // txtAiInterval
            // 
            this.txtAiInterval.DecimalPlaces = 1;
            this.txtAiInterval.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtAiInterval.Location = new System.Drawing.Point(111, 20);
            this.txtAiInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtAiInterval.Name = "txtAiInterval";
            this.txtAiInterval.Size = new System.Drawing.Size(60, 21);
            this.txtAiInterval.TabIndex = 4;
            this.txtAiInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "采样时间（秒）：";
            // 
            // txtAiData
            // 
            this.txtAiData.Location = new System.Drawing.Point(6, 48);
            this.txtAiData.Multiline = true;
            this.txtAiData.Name = "txtAiData";
            this.txtAiData.Size = new System.Drawing.Size(306, 108);
            this.txtAiData.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkDiList);
            this.groupBox2.Controls.Add(this.btnDiSwitch);
            this.groupBox2.Location = new System.Drawing.Point(12, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(105, 190);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数字输入";
            // 
            // btnDiSwitch
            // 
            this.btnDiSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiSwitch.Location = new System.Drawing.Point(6, 18);
            this.btnDiSwitch.Name = "btnDiSwitch";
            this.btnDiSwitch.Size = new System.Drawing.Size(93, 23);
            this.btnDiSwitch.TabIndex = 0;
            this.btnDiSwitch.Text = "开启";
            this.btnDiSwitch.UseVisualStyleBackColor = true;
            this.btnDiSwitch.Click += new System.EventHandler(this.btnDiSwitch_Click);
            // 
            // chkDiList
            // 
            this.chkDiList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDiList.Enabled = false;
            this.chkDiList.FormattingEnabled = true;
            this.chkDiList.Location = new System.Drawing.Point(7, 48);
            this.chkDiList.Name = "chkDiList";
            this.chkDiList.Size = new System.Drawing.Size(92, 132);
            this.chkDiList.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkDoList);
            this.groupBox3.Controls.Add(this.btnDoSwitch);
            this.groupBox3.Location = new System.Drawing.Point(123, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(105, 190);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数字输出";
            // 
            // chkDoList
            // 
            this.chkDoList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDoList.Enabled = false;
            this.chkDoList.FormattingEnabled = true;
            this.chkDoList.Location = new System.Drawing.Point(7, 48);
            this.chkDoList.Name = "chkDoList";
            this.chkDoList.Size = new System.Drawing.Size(92, 132);
            this.chkDoList.TabIndex = 1;
            // 
            // btnDoSwitch
            // 
            this.btnDoSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoSwitch.Location = new System.Drawing.Point(6, 18);
            this.btnDoSwitch.Name = "btnDoSwitch";
            this.btnDoSwitch.Size = new System.Drawing.Size(93, 23);
            this.btnDoSwitch.TabIndex = 0;
            this.btnDoSwitch.Text = "开启";
            this.btnDoSwitch.UseVisualStyleBackColor = true;
            this.btnDoSwitch.Click += new System.EventHandler(this.btnDoSwitch_Click);
            // 
            // frmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTest);
            this.Name = "frmDemo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmDemo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAiInterval)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnGetAiData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAiData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtAiInterval;
        private System.Windows.Forms.Button btnAiStop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox chkDiList;
        private System.Windows.Forms.Button btnDiSwitch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox chkDoList;
        private System.Windows.Forms.Button btnDoSwitch;
    }
}

