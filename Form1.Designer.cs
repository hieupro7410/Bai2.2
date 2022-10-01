using System.Diagnostics;
using System.Threading;
namespace Bai2._2
{
    partial class Form1
    {
       

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtThreads = new System.Windows.Forms.TextBox();
            this.btnCham = new System.Windows.Forms.Button();
            this.btnNhanh = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbKetqua = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "nhập số thread cần chạy :";
            // 
            // txtThreads
            // 
            this.txtThreads.Location = new System.Drawing.Point(374, 28);
            this.txtThreads.Name = "txtThreads";
            this.txtThreads.Size = new System.Drawing.Size(250, 47);
            this.txtThreads.TabIndex = 1;
            // 
            // btnCham
            // 
            this.btnCham.Location = new System.Drawing.Point(630, 22);
            this.btnCham.Name = "btnCham";
            this.btnCham.Size = new System.Drawing.Size(200, 58);
            this.btnCham.TabIndex = 2;
            this.btnCham.Text = "Ưu tiên thấp";
            this.btnCham.UseVisualStyleBackColor = true;
            this.btnCham.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNhanh
            // 
            this.btnNhanh.Location = new System.Drawing.Point(836, 22);
            this.btnNhanh.Name = "btnNhanh";
            this.btnNhanh.Size = new System.Drawing.Size(188, 58);
            this.btnNhanh.TabIndex = 3;
            this.btnNhanh.Text = "Ưu tiên cao";
            this.btnNhanh.UseVisualStyleBackColor = true;
            this.btnNhanh.Click += new System.EventHandler(this.btnNhanh_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1092, 28);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(338, 58);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Tính tích 2 ma trận";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbKetqua
            // 
            this.lbKetqua.FormattingEnabled = true;
            this.lbKetqua.ItemHeight = 41;
            this.lbKetqua.Location = new System.Drawing.Point(12, 104);
            this.lbKetqua.Name = "lbKetqua";
            this.lbKetqua.Size = new System.Drawing.Size(1418, 578);
            this.lbKetqua.TabIndex = 5;
            this.lbKetqua.SelectedIndexChanged += new System.EventHandler(this.lbKetqua_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 702);
            this.Controls.Add(this.lbKetqua);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnNhanh);
            this.Controls.Add(this.btnCham);
            this.Controls.Add(this.txtThreads);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtThreads;
        private Button btnCham;
        private Button btnNhanh;
        private Button btnStart;
        private ListBox lbKetqua;
    }
}