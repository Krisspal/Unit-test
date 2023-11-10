namespace Calculator2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btChia = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình tính toán đơn giản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKetQua);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSoB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(67, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tính toán đơn giản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số thứ nhất:";
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(165, 47);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(230, 22);
            this.txtSoA.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số thứ hai:";
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(165, 91);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(230, 22);
            this.txtSoB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết quả:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(165, 133);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(230, 22);
            this.txtKetQua.TabIndex = 1;
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(190, 316);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(92, 39);
            this.btCong.TabIndex = 2;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = true;
            // 
            // btTru
            // 
            this.btTru.Location = new System.Drawing.Point(284, 316);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(92, 39);
            this.btTru.TabIndex = 2;
            this.btTru.Text = "Trừ";
            this.btTru.UseVisualStyleBackColor = true;
            // 
            // btNhan
            // 
            this.btNhan.Location = new System.Drawing.Point(378, 316);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(92, 39);
            this.btNhan.TabIndex = 2;
            this.btNhan.Text = "Nhân";
            this.btNhan.UseVisualStyleBackColor = true;
            // 
            // btChia
            // 
            this.btChia.Location = new System.Drawing.Point(472, 316);
            this.btChia.Name = "btChia";
            this.btChia.Size = new System.Drawing.Size(92, 39);
            this.btChia.TabIndex = 2;
            this.btChia.Text = "Chia";
            this.btChia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 399);
            this.Controls.Add(this.btChia);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btTru;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btChia;
    }
}

