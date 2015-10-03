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
    public partial class DoctorUI : Form
    {
        public DoctorUI()
        {
            InitializeComponent();
        }

        private DoctorDAO doctorDAO = new DoctorDAO();

        private bool checkInput(String name, String id, String depart)
        {
            return name.Length != 0 && depart .Length !=0 && Regex.IsMatch(id, @"^(^\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$", RegexOptions.IgnoreCase);
        }

        private void btnRegisterConfirm_Click(object sender, EventArgs e)
        {
            String name = this.txtName.Text.Trim();
            String id = this.txtID.Text.Trim();
            String gender = this.rbtnMale.Checked ? "男" : this.rbtnFemale.Checked ? "女" : "保密";
            String depart = this.txtDepart.Text.Trim();
            String comment = this.txtComment.Text.Trim();

            if (!checkInput(name,id, depart))
            {
                MessageBox.Show("医生信息登记错误！");
                return;
            }

            Doctor doctor = new Doctor(id, name, gender, depart, comment);

            if (!doctorDAO.updateDoctor(doctor))
            {
                MessageBox.Show("医生信息登记失败！");
                return;

            }

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnRegisterCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public String doctorId = "";
        private void DoctorUI_Load(object sender, EventArgs e)
        {
            if (doctorId.Length != 0)
            {
                Doctor doctor = doctorDAO.getDoctorById(doctorId);
                this.txtName.Text = doctor.name;
                this.txtID.Text = doctor.id;
                this.txtDepart.Text = doctor.depart;
                this.txtComment.Text = doctor.comment;
                switch (doctor.gender)
                {
                    case "男": this.rbtnMale.Checked = true; break;
                    case "女": this.rbtnFemale.Checked = true; break;
                    default: this.rbtnUnknown.Checked = true; break;
                }
            }
        }

    }
}
