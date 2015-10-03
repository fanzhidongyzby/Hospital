namespace Hospital
{
    partial class DrugUI
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
            this.btnRegisterCancel = new System.Windows.Forms.Button();
            this.btnRegisterConfirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkAdd = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnRegisterCancel
            // 
            this.btnRegisterCancel.Location = new System.Drawing.Point(386, 343);
            this.btnRegisterCancel.Name = "btnRegisterCancel";
            this.btnRegisterCancel.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterCancel.TabIndex = 17;
            this.btnRegisterCancel.Text = "取消";
            this.btnRegisterCancel.UseVisualStyleBackColor = true;
            this.btnRegisterCancel.Click += new System.EventHandler(this.btnRegisterCancel_Click);
            // 
            // btnRegisterConfirm
            // 
            this.btnRegisterConfirm.Location = new System.Drawing.Point(290, 343);
            this.btnRegisterConfirm.Name = "btnRegisterConfirm";
            this.btnRegisterConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterConfirm.TabIndex = 16;
            this.btnRegisterConfirm.Text = "添加";
            this.btnRegisterConfirm.UseVisualStyleBackColor = true;
            this.btnRegisterConfirm.Click += new System.EventHandler(this.btnRegisterConfirm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "使用说明：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "价格：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "名称：";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(129, 102);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(268, 21);
            this.txtPrice.TabIndex = 10;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(129, 222);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(297, 99);
            this.txtComment.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(297, 21);
            this.txtName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "类型：";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "处方药",
            "非处方药"});
            this.cbType.Location = new System.Drawing.Point(129, 138);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(297, 20);
            this.cbType.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "RMB";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(129, 21);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(297, 21);
            this.txtID.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "编号：";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(129, 176);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(211, 21);
            this.txtCount.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "数量：";
            // 
            // chkAdd
            // 
            this.chkAdd.AutoSize = true;
            this.chkAdd.Location = new System.Drawing.Point(354, 178);
            this.chkAdd.Name = "chkAdd";
            this.chkAdd.Size = new System.Drawing.Size(72, 16);
            this.chkAdd.TabIndex = 19;
            this.chkAdd.Text = "是否入库";
            this.chkAdd.UseVisualStyleBackColor = true;
            this.chkAdd.CheckedChanged += new System.EventHandler(this.chkAdd_CheckedChanged);
            // 
            // DrugUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 393);
            this.Controls.Add(this.chkAdd);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btnRegisterCancel);
            this.Controls.Add(this.btnRegisterConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtName);
            this.Name = "DrugUI";
            this.Text = "药品信息";
            this.Load += new System.EventHandler(this.DrugUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterCancel;
        private System.Windows.Forms.Button btnRegisterConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkAdd;
    }
}