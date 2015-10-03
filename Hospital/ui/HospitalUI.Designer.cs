namespace Hospital
{
    partial class HospitalUI
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnTreat = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnFetch = new System.Windows.Forms.Button();
            this.gvMain = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(12, 23);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "挂号";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnTreat
            // 
            this.btnTreat.Location = new System.Drawing.Point(206, 23);
            this.btnTreat.Name = "btnTreat";
            this.btnTreat.Size = new System.Drawing.Size(75, 23);
            this.btnTreat.TabIndex = 2;
            this.btnTreat.Text = "就诊";
            this.btnTreat.UseVisualStyleBackColor = true;
            this.btnTreat.Click += new System.EventHandler(this.btnTreat_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(435, 23);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "付费";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(663, 23);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(75, 23);
            this.btnFetch.TabIndex = 2;
            this.btnFetch.Text = "取药";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // gvMain
            // 
            this.gvMain.AllowUserToAddRows = false;
            this.gvMain.AllowUserToDeleteRows = false;
            this.gvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMain.Location = new System.Drawing.Point(12, 68);
            this.gvMain.Name = "gvMain";
            this.gvMain.ReadOnly = true;
            this.gvMain.RowTemplate.Height = 23;
            this.gvMain.Size = new System.Drawing.Size(727, 393);
            this.gvMain.TabIndex = 3;
            // 
            // HospitalUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 473);
            this.Controls.Add(this.gvMain);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnTreat);
            this.Controls.Add(this.btnRegister);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "HospitalUI";
            this.Text = "医院管理系统";
            this.Load += new System.EventHandler(this.Hospital_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnTreat;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.DataGridView gvMain;
    }
}

