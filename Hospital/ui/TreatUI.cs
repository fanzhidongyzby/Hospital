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
    public partial class TreatUI : Form
    {
        public TreatUI()
        {
            InitializeComponent();
        }

        private PatientDAO patientDAO = new PatientDAO();
        private DoctorDAO doctorDAO = new DoctorDAO();
        private PrescDAO prescDAO = new PrescDAO();

        public String patientID = "";
        public String docotrID = "";

        public Presc presc = new Presc();

        private DataTable drugTable = new DataTable("药品表");
        private List<DrugCount> drugList = new List<DrugCount>();

        public DrugCount getCacheDrug(Drug drug)
        {
            int index = findDrug(drug);
            if (index == -1)
            {
                return null;
            }

            return presc.drugCountList[index];
        }

        private int findDrug(Drug drug)
        {
            for (int i = 0; i < presc.drugCountList.Count; i++)
            {
                if (presc.drugCountList[i].drug.id == drug.id)
                {
                    return i;
                }
            }
            return -1;
        }

        private void drugListToTable()
        {
            drugTable.Rows.Clear();
            for (int i = 0; i < presc.drugCountList.Count; i++)
            {
                Drug drug = presc.drugCountList[i].drug;
                DataRow row = drugTable.NewRow();
                row["编号"] = drug.id;
                row["名称"] = drug.name;
                row["价格（RMB）"] = drug.price;
                row["数量"] = presc.drugCountList[i].count;
                drugTable.Rows.Add(row);
            }
        }

        private void addDrug(Drug drug, int count)
        {
            int index = findDrug(drug);
            if (index != -1)
            {
                presc.drugCountList[index].count += count;
                presc.drugCountList[index].drug = drug;
            }
            else
            {
                DrugCount drugCount = new DrugCount(presc, drug, count);
                presc.drugCountList.Add(drugCount);
            }

            drugListToTable();
        }

        
        
        private void Treat_Load(object sender, EventArgs e)
        {
            presc.patient = patientDAO.getPatientById(patientID);
            if (presc.patient == null)
            {
                MessageBox.Show("病人信息加载失败");
                this.Close();
                return;
            }

            this.lbPatientName.Text = presc.patient.name;
            this.lbPatientID.Text = presc.patient.id;
            this.lbPatientGender.Text = presc.patient.gender;

            gvDoctor.DataSource = doctorDAO.getDoctorDataTable();
            
            drugTable.Columns.Add("编号", Type.GetType("System.String"));
            drugTable.Columns.Add("名称", Type.GetType("System.String"));
            drugTable.Columns.Add("价格（RMB）", Type.GetType("System.String"));
            drugTable.Columns.Add("数量", Type.GetType("System.Int32"));

            gvDrug.DataSource = drugTable;
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            DoctorUI doctorUI = new DoctorUI();
            int index = -1;
            if (gvDoctor.CurrentRow !=null && (index = gvDoctor.CurrentRow.Index) >= 0)
            {
                doctorUI.doctorId = this.gvDoctor.Rows[index].Cells[0].Value.ToString();
            }



            DialogResult ret = doctorUI.ShowDialog();
            if (ret == DialogResult.OK)
            {
                gvDoctor.DataSource = doctorDAO.getDoctorDataTable();
            }
        }

        private void btnAddDrug_Click(object sender, EventArgs e)
        {
            SelectDrugUI selectDrugUI = new SelectDrugUI();
            selectDrugUI.parentWindow = this;
            DialogResult ret = selectDrugUI.ShowDialog();
            if (ret == DialogResult.OK)
            {
                addDrug(selectDrugUI.drug, selectDrugUI.count);
            }
        }

        private void btnRemoveDrug_Click(object sender, EventArgs e)
        {
            if (gvDrug.CurrentRow == null)
            {
                return;
            }

            int index = -1;
            if (gvDrug.CurrentRow == null || (index = gvDrug.CurrentRow.Index) < 0)
            {
                MessageBox.Show("请选择要删除的药品");
                
                return;
            }

            presc.drugCountList.RemoveAt(index);
            gvDrug.Rows.RemoveAt(index);
        }

        private void btnTreatConfirm_Click(object sender, EventArgs e)
        {
            int index = -1;
            if (gvDoctor.CurrentRow == null || (index = gvDoctor.CurrentRow.Index) < 0)
            {
                MessageBox.Show("请选择就诊的医生");
                return;
            }

            String doctorId = this.gvDoctor.Rows[index].Cells[0].Value.ToString();
            presc.doctor = doctorDAO.getDoctorById(doctorId);
            if (presc.doctor == null)
            {
                MessageBox.Show("医生信息不存在");
                return;
            }

            if (presc.drugCountList.Count == 0)
            {
                MessageBox.Show("请选择处方需要的药品");
                return;
            }

            presc.comment = this.txtComment.Text;

            if (!prescDAO.insertPresc(presc))
            {
                MessageBox.Show("处方生成失败");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnTreatCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
