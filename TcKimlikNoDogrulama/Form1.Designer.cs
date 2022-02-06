namespace TcKimlikNoDogrulama
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sfBtnKontrol = new Syncfusion.WinForms.Controls.SfButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoyisim = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtisim = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtdogumYil = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txttcNo = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoyisim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtisim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdogumYil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttcNo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttcNo);
            this.groupBox1.Controls.Add(this.txtdogumYil);
            this.groupBox1.Controls.Add(this.txtsoyisim);
            this.groupBox1.Controls.Add(this.txtisim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sfBtnKontrol);
            this.groupBox2.Location = new System.Drawing.Point(246, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 293);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlem";
            // 
            // sfBtnKontrol
            // 
            this.sfBtnKontrol.AccessibleName = "Button";
            this.sfBtnKontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sfBtnKontrol.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfBtnKontrol.Location = new System.Drawing.Point(7, 22);
            this.sfBtnKontrol.Name = "sfBtnKontrol";
            this.sfBtnKontrol.Size = new System.Drawing.Size(128, 34);
            this.sfBtnKontrol.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sfBtnKontrol.TabIndex = 0;
            this.sfBtnKontrol.Text = "Kontrol Et";
            this.sfBtnKontrol.UseVisualStyleBackColor = false;
            this.sfBtnKontrol.Click += new System.EventHandler(this.sfBtnKontrol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doğum Yılı";
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtsoyisim.BeforeTouchSize = new System.Drawing.Size(125, 22);
            this.txtsoyisim.Location = new System.Drawing.Point(19, 171);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(125, 22);
            this.txtsoyisim.TabIndex = 4;
            // 
            // txtisim
            // 
            this.txtisim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtisim.BeforeTouchSize = new System.Drawing.Size(125, 22);
            this.txtisim.Location = new System.Drawing.Point(19, 110);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(125, 22);
            this.txtisim.TabIndex = 3;
            // 
            // txtdogumYil
            // 
            this.txtdogumYil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtdogumYil.BeforeTouchSize = new System.Drawing.Size(125, 22);
            this.txtdogumYil.Location = new System.Drawing.Point(19, 232);
            this.txtdogumYil.Name = "txtdogumYil";
            this.txtdogumYil.Size = new System.Drawing.Size(125, 22);
            this.txtdogumYil.TabIndex = 5;
            // 
            // txttcNo
            // 
            this.txttcNo.BackColor = System.Drawing.Color.Cyan;
            this.txttcNo.BeforeTouchSize = new System.Drawing.Size(125, 22);
            this.txttcNo.Location = new System.Drawing.Point(19, 55);
            this.txttcNo.Name = "txttcNo";
            this.txttcNo.Size = new System.Drawing.Size(125, 22);
            this.txttcNo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "TC Kimlik No";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 317);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tc Kimlik No Doğrulama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtsoyisim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtisim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdogumYil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttcNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Syncfusion.WinForms.Controls.SfButton sfBtnKontrol;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txttcNo;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtdogumYil;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtsoyisim;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtisim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}

