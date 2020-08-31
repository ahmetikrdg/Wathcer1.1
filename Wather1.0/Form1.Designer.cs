namespace Wather1._0
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
            this.stop = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnexcel = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.txtekle = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Azure;
            this.stop.Location = new System.Drawing.Point(244, 29);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(82, 26);
            this.stop.TabIndex = 2;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(527, 476);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnexcel
            // 
            this.btnexcel.BackColor = System.Drawing.Color.Azure;
            this.btnexcel.Location = new System.Drawing.Point(339, 29);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(82, 26);
            this.btnexcel.TabIndex = 4;
            this.btnexcel.Text = "Excel";
            this.btnexcel.UseVisualStyleBackColor = false;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.Azure;
            this.btnstart.Location = new System.Drawing.Point(153, 29);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(82, 26);
            this.btnstart.TabIndex = 5;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // txtekle
            // 
            this.txtekle.Location = new System.Drawing.Point(771, 281);
            this.txtekle.Name = "txtekle";
            this.txtekle.Size = new System.Drawing.Size(128, 20);
            this.txtekle.TabIndex = 6;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(797, 307);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 7;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(946, 577);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtekle);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.stop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.TextBox txtekle;
        private System.Windows.Forms.Button btnekle;
    }
}

