namespace Hospital
{
    partial class PatientUI
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnUnknown = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnRegisterConfirm = new System.Windows.Forms.Button();
            this.btnRegisterCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(297, 21);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名：";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(120, 61);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(297, 21);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "身份证号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "性别：";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(4, 3);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(35, 16);
            this.rbtnMale.TabIndex = 2;
            this.rbtnMale.Text = "男";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(73, 3);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(35, 16);
            this.rbtnFemale.TabIndex = 2;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "女";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnUnknown
            // 
            this.rbtnUnknown.AutoSize = true;
            this.rbtnUnknown.Checked = true;
            this.rbtnUnknown.Location = new System.Drawing.Point(140, 3);
            this.rbtnUnknown.Name = "rbtnUnknown";
            this.rbtnUnknown.Size = new System.Drawing.Size(47, 16);
            this.rbtnUnknown.TabIndex = 2;
            this.rbtnUnknown.TabStop = true;
            this.rbtnUnknown.Text = "保密";
            this.rbtnUnknown.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "备注：";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(120, 135);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(297, 142);
            this.txtComment.TabIndex = 3;
            // 
            // btnRegisterConfirm
            // 
            this.btnRegisterConfirm.Location = new System.Drawing.Point(228, 301);
            this.btnRegisterConfirm.Name = "btnRegisterConfirm";
            this.btnRegisterConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterConfirm.TabIndex = 4;
            this.btnRegisterConfirm.Text = "登记";
            this.btnRegisterConfirm.UseVisualStyleBackColor = true;
            this.btnRegisterConfirm.Click += new System.EventHandler(this.btnRegisterConfirm_Click);
            // 
            // btnRegisterCancel
            // 
            this.btnRegisterCancel.Location = new System.Drawing.Point(342, 301);
            this.btnRegisterCancel.Name = "btnRegisterCancel";
            this.btnRegisterCancel.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterCancel.TabIndex = 5;
            this.btnRegisterCancel.Text = "取消";
            this.btnRegisterCancel.UseVisualStyleBackColor = true;
            this.btnRegisterCancel.Click += new System.EventHandler(this.btnRegisterCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnMale);
            this.panel1.Controls.Add(this.rbtnFemale);
            this.panel1.Controls.Add(this.rbtnUnknown);
            this.panel1.Location = new System.Drawing.Point(120, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 24);
            this.panel1.TabIndex = 2;
            // 
            // PatientUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 340);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegisterCancel);
            this.Controls.Add(this.btnRegisterConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtName);
            this.Name = "PatientUI";
            this.Text = "病人信息";
            this.Load += new System.EventHandler(this.PatientUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnUnknown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnRegisterConfirm;
        private System.Windows.Forms.Button btnRegisterCancel;
        private System.Windows.Forms.Panel panel1;
    }
}