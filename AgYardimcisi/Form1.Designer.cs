namespace AgYardimcisi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdns = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.getirBtn = new System.Windows.Forms.Button();
            this.BaglantiTestBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKart = new System.Windows.Forms.TextBox();
            this.RaporYazbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // txtip
            // 
            this.txtip.Location = new System.Drawing.Point(46, 11);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(194, 20);
            this.txtip.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "İp:";
            // 
            // txtdns
            // 
            this.txtdns.Location = new System.Drawing.Point(46, 37);
            this.txtdns.Name = "txtdns";
            this.txtdns.Size = new System.Drawing.Size(194, 20);
            this.txtdns.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dns:";
            // 
            // getirBtn
            // 
            this.getirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.getirBtn.Location = new System.Drawing.Point(20, 92);
            this.getirBtn.Name = "getirBtn";
            this.getirBtn.Size = new System.Drawing.Size(112, 23);
            this.getirBtn.TabIndex = 4;
            this.getirBtn.Text = "İp ve Dns Getir";
            this.getirBtn.UseVisualStyleBackColor = true;
            this.getirBtn.Click += new System.EventHandler(this.getirBtn_Click);
            // 
            // BaglantiTestBtn
            // 
            this.BaglantiTestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BaglantiTestBtn.Location = new System.Drawing.Point(138, 92);
            this.BaglantiTestBtn.Name = "BaglantiTestBtn";
            this.BaglantiTestBtn.Size = new System.Drawing.Size(112, 23);
            this.BaglantiTestBtn.TabIndex = 5;
            this.BaglantiTestBtn.Text = "Bağlantı Testi";
            this.BaglantiTestBtn.UseVisualStyleBackColor = true;
            this.BaglantiTestBtn.Click += new System.EventHandler(this.BaglantiTestBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kart:";
            // 
            // txtKart
            // 
            this.txtKart.Location = new System.Drawing.Point(46, 63);
            this.txtKart.Name = "txtKart";
            this.txtKart.Size = new System.Drawing.Size(194, 20);
            this.txtKart.TabIndex = 6;
            // 
            // RaporYazbtn
            // 
            this.RaporYazbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RaporYazbtn.Location = new System.Drawing.Point(93, 121);
            this.RaporYazbtn.Name = "RaporYazbtn";
            this.RaporYazbtn.Size = new System.Drawing.Size(85, 23);
            this.RaporYazbtn.TabIndex = 0;
            this.RaporYazbtn.Text = "Rapor Yaz";
            this.RaporYazbtn.Click += new System.EventHandler(this.RaporYazbtn_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(262, 160);
            this.Controls.Add(this.RaporYazbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKart);
            this.Controls.Add(this.BaglantiTestBtn);
            this.Controls.Add(this.getirBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdns);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ağ Yardımcım";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button getirBtn;
        private System.Windows.Forms.Button BaglantiTestBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKart;
        private System.Windows.Forms.Button RaporYazbtn;
    }
}

