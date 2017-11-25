namespace MyFunction.MyForm
{
    partial class FrmGrab
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGetText = new System.Windows.Forms.Button();
            this.btnGetXmlPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "网址：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "http://www.matrix67.com/blog/feed";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnGetText
            // 
            this.btnGetText.Location = new System.Drawing.Point(146, 55);
            this.btnGetText.Name = "btnGetText";
            this.btnGetText.Size = new System.Drawing.Size(75, 23);
            this.btnGetText.TabIndex = 2;
            this.btnGetText.Text = "提取内容";
            this.btnGetText.UseVisualStyleBackColor = true;
            this.btnGetText.Click += new System.EventHandler(this.btnGetText_Click);
            // 
            // btnGetXmlPath
            // 
            this.btnGetXmlPath.Location = new System.Drawing.Point(15, 55);
            this.btnGetXmlPath.Name = "btnGetXmlPath";
            this.btnGetXmlPath.Size = new System.Drawing.Size(94, 23);
            this.btnGetXmlPath.TabIndex = 3;
            this.btnGetXmlPath.Text = "加载本地XML";
            this.btnGetXmlPath.UseVisualStyleBackColor = true;
            this.btnGetXmlPath.Click += new System.EventHandler(this.btnGetXmlPath_Click);
            // 
            // FrmGrab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 107);
            this.Controls.Add(this.btnGetXmlPath);
            this.Controls.Add(this.btnGetText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmGrab";
            this.Text = "网抓标准XML内容到Excel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGetText;
        private System.Windows.Forms.Button btnGetXmlPath;
    }
}