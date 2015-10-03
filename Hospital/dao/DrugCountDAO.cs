using System;
using System.Data;
using System.Collections.Generic;
namespace Hospital
{
    class DrugCountDAO
    {
        private Database db = Database.getInstance();

        private DrugDAO drugDAO = new DrugDAO();

        public bool insertDrugCountList(List<DrugCount> drugCountList)
        {
            for (int i = 0; i < drugCountList.Count; i++)
            {
                if (!insertDrugCount(drugCountList[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public bool insertDrugCount(DrugCount drugCount)
        {
            String cmd = "insert into drugcount values ('" + drugCount.presc.id + "', '" + drugCount.drug.id + "', '" + drugCount.count + "')";
            return db.update(cmd);
        }

        public List<DrugCount> getDrugCountById(Presc presc)
        {
            List<DrugCount> drugCounts = new List<DrugCount>();

            DataTable table = db.queryDataTable("select drug, count from drugcount where presc = '" + presc.id + "'");
            if (table.Rows.Count == 0)
            {
                return drugCounts;
            }

            DataRowCollection rows = table.Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                object[] items = table.Rows[i].ItemArray;
                DrugCount drugCount = new DrugCount();

                String drugId = items[0].ToString();
                drugCount.count = Convert.ToInt32(items[1].ToString());

                drugCount.drug = drugDAO.getDrugById(drugId);
                drugCount.presc = presc;

                drugCounts.Add(drugCount);
            }

            return drugCounts;
        }
    }
}