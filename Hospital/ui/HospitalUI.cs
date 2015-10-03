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
    public partial class HospitalUI : Form
    {
        public HospitalUI()
        {
            InitializeComponent();
        }

        private PatientDAO patientDAO = new PatientDAO();
        private DrugDAO drugDAO = new DrugDAO();
        private Presc presc = null;

        private void Hospital_Load(object sender, EventArgs e)
        {
            gvMain.DataSource = patientDAO.getPatientDataTable();
            this.btnTreat.Enabled = false;
            this.btnPay.Enabled = false;
            this.btnFetch.Enabled = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            gvMain.DataSource = patientDAO.getPatientDataTable();

            PatientUI patientUI = new PatientUI();
            int index = -1;
            if (gvMain.CurrentRow != null && (index = gvMain.CurrentRow.Index) >= 0)
            {
                DataGridViewRowCollection rows = gvMain.Rows;
                patientUI.patientId = rows[index].Cells[0].Value.ToString();
            }

            DialogResult ret = patientUI.ShowDialog();
            if (ret == DialogResult.OK)
            {
                gvMain.DataSource = patientDAO.getPatientDataTable();
                this.btnRegister.Enabled = false;
                this.btnTreat.Enabled = true;
            }
        }

        private void btnTreat_Click(object sender, EventArgs e)
        {
            int index = -1; ;
            if (gvMain.CurrentRow == null || (index = gvMain.CurrentRow.Index) < 0)
            {
                MessageBox.Show("就诊前，请先选择挂号的病人。");
                return;
            }

            DataGridViewRowCollection rows = gvMain.Rows;
            String id = rows[index].Cells[0].Value.ToString();

            TreatUI treatUI = new TreatUI();
            treatUI.patientID = id;
            DialogResult ret = treatUI.ShowDialog();
            if (ret == DialogResult.OK)
            {
                this.presc = treatUI.presc;
                this.btnTreat.Enabled = false;
                this.btnPay.Enabled = true;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (this.presc == null)
            {
                MessageBox.Show("就诊后才能付费");
                return;
            }

            PrescUI prescUI = new PrescUI();
            prescUI.presc = presc;
            DialogResult ret = prescUI.ShowDialog();
            if (ret == DialogResult.OK)
            {
                this.btnPay.Enabled = false;
                this.btnFetch.Enabled = true;
            }
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            List<DrugCount> drugCountList = presc.drugCountList;
            if (!drugDAO.fetchDrugs(drugCountList))
            {
                MessageBox.Show("药品数量更新失败！");
            }
            

            gvMain.DataSource = drugDAO.getDrugDataTable();

            this.btnFetch.Enabled = false;
            this.btnRegister.Enabled = true;

        }
    }
}
