namespace Hospital
{
    partial class SelectDrugUI
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
            this.btnAddDrug = new System.Windows.Forms.Button();
            this.gvDrug = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnRegisterCancel = new System.Windows.Forms.Button();
            this.btnRegisterConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvDrug)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddDrug
            // 
            this.btnAddDrug.AutoSize = true;
            this.btnAddDrug.Location = new System.Drawing.Point(719, 12);
            this.btnAddDrug.Name = "btnAddDrug";
            this.btnAddDrug.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddDrug.Size = new System.Drawing.Size(22, 23);
            this.btnAddDrug.TabIndex = 12;
            this.btnAddDrug.Text = "+";
            this.btnAddDrug.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDrug.UseVisualStyleBackColor = true;
            this.btnAddDrug.Click += new System.EventHandler(this.btnAddDrug_Click);
            // 
            // gvDrug
            // 
            this.gvDrug.AllowUserToAddRows = false;
            this.gvDrug.AllowUserToDeleteRows = false;
            this.gvDrug.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDrug.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvDrug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDrug.Location = new System.Drawing.Point(12, 12);
            this.gvDrug.Name = "gvDrug";
            this.gvDrug.ReadOnly = true;
            this.gvDrug.RowTemplate.Height = 23;
            this.gvDrug.Size = new System.Drawing.Size(701, 123);
            this.gvDrug.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "数量：";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(59, 155);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(143, 21);
            this.txtNumber.TabIndex = 14;
            this.txtNumber.Text = "1";
            // 
            // btnRegisterCancel
            // 
            this.btnRegisterCancel.Location = new System.Drawing.Point(655, 226);
            this.btnRegisterCancel.Name = "btnRegisterCancel";
            this.btnRegisterCancel.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterCancel.TabIndex = 16;
            this.btnRegisterCancel.Text = "取消";
            this.btnRegisterCancel.UseVisualStyleBackColor = true;
            this.btnRegisterCancel.Click += new System.EventHandler(this.btnRegisterCancel_Click);
            // 
            // btnRegisterConfirm
            // 
            this.btnRegisterConfirm.Location = new System.Drawing.Point(541, 226);
            this.btnRegisterConfirm.Name = "btnRegisterConfirm";
            this.btnRegisterConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterConfirm.TabIndex = 15;
            this.btnRegisterConfirm.Text = "选择";
            this.btnRegisterConfirm.UseVisualStyleBackColor = true;
            this.btnRegisterConfirm.Click += new System.EventHandler(this.btnRegisterConfirm_Click);
            // 
            // SelectDrugUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 261);
            this.Controls.Add(this.btnRegisterCancel);
            this.Controls.Add(this.btnRegisterConfirm);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddDrug);
            this.Controls.Add(this.gvDrug);
            this.Name = "SelectDrugUI";
            this.Text = "选择药品";
            this.Load += new System.EventHandler(this.SelectDrugUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDrug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDrug;
        private System.Windows.Forms.DataGridView gvDrug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnRegisterCancel;
        private System.Windows.Forms.Button btnRegisterConfirm;
    }
}