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
    public partial class SelectDrugUI : Form
    {
        public SelectDrugUI()
        {
            InitializeComponent();
        }

        private DrugDAO drugDAO = new DrugDAO();

        public TreatUI parentWindow = null;
        public Drug drug = null;
        public int count = 0;

        private void SelectDrugUI_Load(object sender, EventArgs e)
        {
            gvDrug.DataSource = drugDAO.getDrugDataTable();
        }

        private void btnAddDrug_Click(object sender, EventArgs e)
        {
            DrugUI drugUI = new DrugUI();
            int index = -1;
            if (gvDrug.CurrentRow != null && (index = gvDrug.CurrentRow.Index) >= 0)
            {
                DataGridViewRowCollection rows = gvDrug.Rows;
               drugUI.drugId = rows[index].Cells[0].Value.ToString();
            }

            DialogResult ret = drugUI.ShowDialog();
            if (ret == DialogResult.OK)
            {
                gvDrug.DataSource = drugDAO.getDrugDataTable();
            }
        }

        private void btnRegisterConfirm_Click(object sender, EventArgs e)
        {
            int index = -1;
            if (gvDrug.CurrentRow == null || (index = gvDrug.CurrentRow.Index) < 0)
            {
                MessageBox.Show("请选择药品信息");
                return;
            }

            DataGridViewRowCollection rows = gvDrug.Rows;
            String id = rows[index].Cells[0].Value.ToString();

            String number = this.txtNumber.Text;
            if (!Regex.IsMatch(number, @"^([0-9]{1,})$", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("请输入使用药品数量");
                return;
            }

            int count = Convert.ToInt32(number);
            Drug drug = drugDAO.getDrugById(id);
            int total = Convert.ToInt32(drug.count);


            DrugCount drugCount = parentWindow.getCacheDrug(drug);
            int selected = (drugCount != null ? drugCount.count : 0);


            if (selected + count > total || count <= 0)
            {
                MessageBox.Show("药品数量不合法：已选择 = " + selected 
                    + ", 待选择 = " + count
                    + ", 库存 = " + total);
                return;
            }

            this.drug = drug;
            this.count = count;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnRegisterCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
