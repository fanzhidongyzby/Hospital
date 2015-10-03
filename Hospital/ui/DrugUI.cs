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
    public partial class DrugUI : Form
    {
        public DrugUI()
        {
            InitializeComponent();
        }

        private DrugDAO drugDAO = new DrugDAO();

        public String drugId = "";
        private void DrugUI_Load(object sender, EventArgs e)
        {
            if (drugId.Length != 0)
            {
                Drug drug = drugDAO.getDrugById(drugId);
                this.txtID.Text = drug.id.Trim();
                this.txtName.Text = drug.name.Trim();
                this.txtPrice.Text = drug.price.Trim();
                this.txtCount.Text = drug.count.ToString();
                this.txtComment.Text = drug.comment.Trim();
                this.cbType.Text = drug.type.Trim();
            }
        }

        private bool checkInput(String name, String id, String price, String type, String count, bool addDrug)
        {
            return addDrug ? id.Length != 0 && Regex.IsMatch(count, @"^\d+$", RegexOptions.IgnoreCase)
                : id.Length != 0 && name.Length != 0 && type.Length != 0
                && Regex.IsMatch(price, @"^\d+[.]{0,1}\d+$", RegexOptions.IgnoreCase)
                && Regex.IsMatch(count, @"^\d+$", RegexOptions.IgnoreCase);
        }

        private void btnRegisterConfirm_Click(object sender, EventArgs e)
        {
            bool addDrug = this.chkAdd.Checked;
            String id = this.txtID.Text;
            String name = this.txtName.Text;
            String price = this.txtPrice.Text;
            String type = this.cbType.Text;
            String comment = this.txtComment.Text;
            String count = this.txtCount.Text;

            if (!checkInput(name, id, price, type, count, addDrug))
            {
                MessageBox.Show("药品信息登记错误！");
                return;
            }

            if (addDrug)
            {
                if (!drugDAO.addDrug(id, Convert.ToInt32(count)))
                {
                    MessageBox.Show("药品入库失败！");
                    return;
                }
            }
            else
            {
                Drug drug = new Drug(id, name, price, type,Convert.ToInt32(count), comment);

                if (!drugDAO.updateDrug(drug))
                {
                    MessageBox.Show("药品信息登记失败！");
                    return;

                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnRegisterCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkAdd_CheckedChanged(object sender, EventArgs e)
        {
            this.txtName.Enabled = !this.txtName.Enabled;
            this.txtPrice.Enabled = !this.txtPrice.Enabled;
            this.cbType.Enabled = !this.cbType.Enabled;
            this.txtComment.Enabled = !this.txtComment.Enabled;
        }
    }
}
