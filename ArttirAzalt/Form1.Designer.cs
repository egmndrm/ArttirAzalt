namespace ArttirAzalt
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
            this.txbSayi = new System.Windows.Forms.TextBox();
            this.rbArttir = new System.Windows.Forms.RadioButton();
            this.rbAzalt = new System.Windows.Forms.RadioButton();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn30 = new System.Windows.Forms.Button();
            this.btn40 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbSayi
            // 
            this.txbSayi.Location = new System.Drawing.Point(221, 57);
            this.txbSayi.Name = "txbSayi";
            this.txbSayi.Size = new System.Drawing.Size(100, 20);
            this.txbSayi.TabIndex = 0;
            // 
            // rbArttir
            // 
            this.rbArttir.AutoSize = true;
            this.rbArttir.Location = new System.Drawing.Point(144, 183);
            this.rbArttir.Name = "rbArttir";
            this.rbArttir.Size = new System.Drawing.Size(46, 17);
            this.rbArttir.TabIndex = 1;
            this.rbArttir.TabStop = true;
            this.rbArttir.Text = "Arttir";
            this.rbArttir.UseVisualStyleBackColor = true;
            this.rbArttir.CheckedChanged += new System.EventHandler(this.rbArttir_CheckedChanged);
            // 
            // rbAzalt
            // 
            this.rbAzalt.AutoSize = true;
            this.rbAzalt.Location = new System.Drawing.Point(325, 183);
            this.rbAzalt.Name = "rbAzalt";
            this.rbAzalt.Size = new System.Drawing.Size(48, 17);
            this.rbAzalt.TabIndex = 2;
            this.rbAzalt.TabStop = true;
            this.rbAzalt.Text = "Azalt";
            this.rbAzalt.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(78, 123);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(75, 23);
            this.btn10.TabIndex = 3;
            this.btn10.Text = "10";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(173, 123);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(75, 23);
            this.btn20.TabIndex = 4;
            this.btn20.Text = "20";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // btn30
            // 
            this.btn30.Location = new System.Drawing.Point(263, 123);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(75, 23);
            this.btn30.TabIndex = 5;
            this.btn30.Text = "30";
            this.btn30.UseVisualStyleBackColor = true;
            this.btn30.Click += new System.EventHandler(this.btn30_Click);
            // 
            // btn40
            // 
            this.btn40.Location = new System.Drawing.Point(359, 123);
            this.btn40.Name = "btn40";
            this.btn40.Size = new System.Drawing.Size(75, 23);
            this.btn40.TabIndex = 6;
            this.btn40.Text = "40";
            this.btn40.UseVisualStyleBackColor = true;
            this.btn40.Click += new System.EventHandler(this.btn40_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 430);
            this.Controls.Add(this.btn40);
            this.Controls.Add(this.btn30);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.rbAzalt);
            this.Controls.Add(this.rbArttir);
            this.Controls.Add(this.txbSayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbSayi;
        private System.Windows.Forms.RadioButton rbArttir;
        private System.Windows.Forms.RadioButton rbAzalt;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.Button btn40;
    }
}

