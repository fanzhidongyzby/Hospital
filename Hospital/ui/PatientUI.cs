using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Hospital
{
    public partial class PatientUI : Form
    {
        public PatientUI()
        {
            InitializeComponent();
        }

        private PatientDAO patientDAO = new PatientDAO();

        private bool checkInput(String name, String id)
        {
            return name.Length != 0 && Regex.IsMatch(id, @"^(^\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$", RegexOptions.IgnoreCase);
        }

        private void btnRegisterConfirm_Click(object sender, EventArgs e)
        {
            String name = this.txtName.Text.Trim();
            String id = this.txtID.Text.Trim();
            String gender = this.rbtnMale.Checked ? "男" : this.rbtnFemale.Checked ? "女" : "保密";
            String comment = this.txtComment.Text.Trim();

            if (!checkInput(name,id))
            {
                MessageBox.Show("病人信息登记错误！");
                return;
            }

            Patient patient = new Patient(id, name, gender, comment);

            if (!patientDAO.updatePatient(patient))
            {
                MessageBox.Show("病人信息登记失败！");
                return;

            }

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnRegisterCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public String patientId = "";
        private void PatientUI_Load(object sender, EventArgs e)
        {
            if (patientId.Length != 0)
            {
                Patient patient = patientDAO.getPatientById(patientId);
                this.txtName.Text = patient.name;
                this.txtID.Text = patient.id;
                this.txtComment.Text = patient.comment;
                switch (patient.gender)
                {
                    case "男": this.rbtnMale.Checked = true; break;
                    case "女": this.rbtnFemale.Checked = true; break;
                    default: this.rbtnUnknown.Checked = true; break;
                }
            }
        }

    }
}
