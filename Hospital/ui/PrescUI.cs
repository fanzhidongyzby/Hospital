using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital
{
    public partial class PrescUI : Form
    {
        public PrescUI()
        {
            InitializeComponent();
        }

        public Presc presc = null;
        private DoctorDAO doctorDAO = new DoctorDAO();
        private PatientDAO patientDAO = new PatientDAO();
        private PrescDAO prescDAO = new PrescDAO();

        private void PrescUI_Load(object sender, EventArgs e)
        {
            String depart = presc.doctor.depart;


            this.gbDepart.Text = depart;
            this.lbDoctorNumber.Text = doctorDAO.getDoctorNumberByDepart(depart).ToString();
            this.lbPatientNum.Text = patientDAO.getPatientNumberByDepart(depart).ToString();
            this.lbTotal.Text = prescDAO.getIncomeByDepart(depart).ToString() + " RMB";

            this.lbPatientName.Text = presc.patient.name;
            this.lbPatientID.Text = presc.patient.id;
            this.lbPatientGender.Text = presc.patient.gender;

            this.lbDoctorName.Text = presc.doctor.name;
            this.lbDoctorID.Text = presc.doctor.id;
            this.lbDoctorGender.Text = presc.doctor.gender;

            this.gvDrug.DataSource = prescDAO.getPrescDataTable(presc.id);
            this.txtComment.Text = presc.comment;

            this.lbPrescTotal.Text = prescDAO.getTotalPrice(presc.id).ToString() + " RMB";
        }

        private void btnTreatConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnTreatCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
