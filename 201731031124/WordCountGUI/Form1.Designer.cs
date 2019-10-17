namespace WordCountGUI
{
    partial class Form1
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
            this.leadInBtn = new System.Windows.Forms.Button();
            this.inputBtn = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.orderBox = new System.Windows.Forms.TextBox();
            this.orderBtn = new System.Windows.Forms.Button();
            this.leadOutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leadInBtn
            // 
            this.leadInBtn.Location = new System.Drawing.Point(825, 85);
            this.leadInBtn.Name = "leadInBtn";
            this.leadInBtn.Size = new System.Drawing.Size(100, 30);
            this.leadInBtn.TabIndex = 0;
            this.leadInBtn.Text = "导入文件";
            this.leadInBtn.UseVisualStyleBackColor = true;
            this.leadInBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // inputBtn
            // 
            this.inputBtn.Location = new System.Drawing.Point(266, 255);
            this.inputBtn.Name = "inputBtn";
            this.inputBtn.Size = new System.Drawing.Size(118, 29);
            this.inputBtn.TabIndex = 1;
            this.inputBtn.Text = "提交内容";
            this.inputBtn.UseVisualStyleBackColor = true;
            this.inputBtn.Click += new System.EventHandler(this.InputBtn_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(170, 30);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(425, 200);
            this.inputBox.TabIndex = 2;
            this.inputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // orderBox
            // 
            this.orderBox.Location = new System.Drawing.Point(186, 415);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(391, 25);
            this.orderBox.TabIndex = 3;
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(278, 470);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(118, 30);
            this.orderBtn.TabIndex = 4;
            this.orderBtn.Text = "执行指令";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // leadOutBtn
            // 
            this.leadOutBtn.Location = new System.Drawing.Point(825, 470);
            this.leadOutBtn.Name = "leadOutBtn";
            this.leadOutBtn.Size = new System.Drawing.Size(100, 30);
            this.leadOutBtn.TabIndex = 5;
            this.leadOutBtn.Text = "结果导出";
            this.leadOutBtn.UseVisualStyleBackColor = true;
            this.leadOutBtn.Click += new System.EventHandler(this.LeadOutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "在此输入测试内容";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "在此输入要执行的指令";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(654, 240);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(407, 200);
            this.outputBox.TabIndex = 8;
            this.outputBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(663, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "结果";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 556);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leadOutBtn);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.inputBtn);
            this.Controls.Add(this.leadInBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button leadInBtn;
        private System.Windows.Forms.Button inputBtn;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox orderBox;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button leadOutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label3;
    }
}

