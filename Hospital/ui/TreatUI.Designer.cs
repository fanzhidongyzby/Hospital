namespace Hospital
{
    partial class TreatUI
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPatientGender = new System.Windows.Forms.Label();
            this.lbPatientID = new System.Windows.Forms.Label();
            this.lbPatientName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvDoctor = new System.Windows.Forms.DataGridView();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRemoveDrug = new System.Windows.Forms.Button();
            this.btnAddDrug = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.gvDrug = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTreatConfirm = new System.Windows.Forms.Button();
            this.btnTreatCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoctor)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDrug)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "性别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "身份证号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "姓名：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPatientGender);
            this.groupBox1.Controls.Add(this.lbPatientID);
            this.groupBox1.Controls.Add(this.lbPatientName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 52);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "病人信息";
            // 
            // lbPatientGender
            // 
            this.lbPatientGender.AutoSize = true;
            this.lbPatientGender.Location = new System.Drawing.Point(513, 26);
            this.lbPatientGender.Name = "lbPatientGender";
            this.lbPatientGender.Size = new System.Drawing.Size(41, 12);
            this.lbPatientGender.TabIndex = 8;
            this.lbPatientGender.Text = "label5";
            // 
            // lbPatientID
            // 
            this.lbPatientID.AutoSize = true;
            this.lbPatientID.Location = new System.Drawing.Point(253, 26);
            this.lbPatientID.Name = "lbPatientID";
            this.lbPatientID.Size = new System.Drawing.Size(41, 12);
            this.lbPatientID.TabIndex = 8;
            this.lbPatientID.Text = "label5";
            // 
            // lbPatientName
            // 
            this.lbPatientName.AutoSize = true;
            this.lbPatientName.Location = new System.Drawing.Point(65, 26);
            this.lbPatientName.Name = "lbPatientName";
            this.lbPatientName.Size = new System.Drawing.Size(41, 12);
            this.lbPatientName.TabIndex = 8;
            this.lbPatientName.Text = "label5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gvDoctor);
            this.groupBox2.Controls.Add(this.btnAddDoctor);
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 160);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "医生信息";
            // 
            // gvDoctor
            // 
            this.gvDoctor.AllowUserToAddRows = false;
            this.gvDoctor.AllowUserToDeleteRows = false;
            this.gvDoctor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDoctor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDoctor.Location = new System.Drawing.Point(8, 20);
            this.gvDoctor.Name = "gvDoctor";
            this.gvDoctor.ReadOnly = true;
            this.gvDoctor.RowTemplate.Height = 23;
            this.gvDoctor.Size = new System.Drawing.Size(601, 134);
            this.gvDoctor.TabIndex = 10;
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.AutoSize = true;
            this.btnAddDoctor.Location = new System.Drawing.Point(613, 20);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddDoctor.Size = new System.Drawing.Size(22, 23);
            this.btnAddDoctor.TabIndex = 9;
            this.btnAddDoctor.Text = "+";
            this.btnAddDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDoctor.UseVisualStyleBackColor = true;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRemoveDrug);
            this.groupBox3.Controls.Add(this.btnAddDrug);
            this.groupBox3.Controls.Add(this.txtComment);
            this.groupBox3.Controls.Add(this.gvDrug);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(641, 257);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "处方信息";
            // 
            // btnRemoveDrug
            // 
            this.btnRemoveDrug.AutoSize = true;
            this.btnRemoveDrug.Location = new System.Drawing.Point(613, 49);
            this.btnRemoveDrug.Name = "btnRemoveDrug";
            this.btnRemoveDrug.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRemoveDrug.Size = new System.Drawing.Size(22, 23);
            this.btnRemoveDrug.TabIndex = 10;
            this.btnRemoveDrug.Text = "-";
            this.btnRemoveDrug.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveDrug.UseVisualStyleBackColor = true;
            this.btnRemoveDrug.Click += new System.EventHandler(this.btnRemoveDrug_Click);
            // 
            // btnAddDrug
            // 
            this.btnAddDrug.AutoSize = true;
            this.btnAddDrug.Location = new System.Drawing.Point(613, 20);
            this.btnAddDrug.Name = "btnAddDrug";
            this.btnAddDrug.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddDrug.Size = new System.Drawing.Size(22, 23);
            this.btnAddDrug.TabIndex = 9;
            this.btnAddDrug.Text = "+";
            this.btnAddDrug.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDrug.UseVisualStyleBackColor = true;
            this.btnAddDrug.Click += new System.EventHandler(this.btnAddDrug_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(53, 144);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(556, 107);
            this.txtComment.TabIndex = 8;
            // 
            // gvDrug
            // 
            this.gvDrug.AllowUserToAddRows = false;
            this.gvDrug.AllowUserToDeleteRows = false;
            this.gvDrug.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDrug.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvDrug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDrug.Location = new System.Drawing.Point(6, 15);
            this.gvDrug.Name = "gvDrug";
            this.gvDrug.ReadOnly = true;
            this.gvDrug.RowTemplate.Height = 23;
            this.gvDrug.Size = new System.Drawing.Size(603, 123);
            this.gvDrug.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "医嘱：";
            // 
            // btnTreatConfirm
            // 
            this.btnTreatConfirm.Location = new System.Drawing.Point(480, 499);
            this.btnTreatConfirm.Name = "btnTreatConfirm";
            this.btnTreatConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnTreatConfirm.TabIndex = 9;
            this.btnTreatConfirm.Text = "确诊";
            this.btnTreatConfirm.UseVisualStyleBackColor = true;
            this.btnTreatConfirm.Click += new System.EventHandler(this.btnTreatConfirm_Click);
            // 
            // btnTreatCancel
            // 
            this.btnTreatCancel.Location = new System.Drawing.Point(578, 499);
            this.btnTreatCancel.Name = "btnTreatCancel";
            this.btnTreatCancel.Size = new System.Drawing.Size(75, 23);
            this.btnTreatCancel.TabIndex = 9;
            this.btnTreatCancel.Text = "取消";
            this.btnTreatCancel.UseVisualStyleBackColor = true;
            this.btnTreatCancel.Click += new System.EventHandler(this.btnTreatCancel_Click);
            // 
            // TreatUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 534);
            this.Controls.Add(this.btnTreatCancel);
            this.Controls.Add(this.btnTreatConfirm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "TreatUI";
            this.Text = "就诊";
            this.Load += new System.EventHandler(this.Treat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoctor)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDrug)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbPatientGender;
        private System.Windows.Forms.Label lbPatientID;
        private System.Windows.Forms.Label lbPatientName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTreatConfirm;
        private System.Windows.Forms.Button btnTreatCancel;
        private System.Windows.Forms.DataGridView gvDrug;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddDrug;
        private System.Windows.Forms.Button btnRemoveDrug;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.DataGridView gvDoctor;
    }
}