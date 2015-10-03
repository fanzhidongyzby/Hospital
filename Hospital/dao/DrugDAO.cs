using System;
using System.Data;
using System.Collections.Generic;
namespace Hospital
{
    class DrugDAO
    {
        private Database db = Database.getInstance();

        public bool fetchDrugs(List<DrugCount> drugCountList)
        {
            db.beginTransaction();
            bool ret = true;
            for (int i = 0; i < drugCountList.Count; i++)
            {
                if (!addDrug(drugCountList[i].drug.id, -drugCountList[i].count))
                {
                    ret = false;
                    break;
                }
            }
            db.endTransaction(ret);
            return ret;
        }

        public bool addDrug(String id, int countChange)
        {
            Drug drug = getDrugById(id);
            if (drug == null)
            {
                return false;
            }

            if (countChange < 0 && -countChange > drug.count)
            {
                return false;
            }

            drug.count += countChange;
            return updateDrug(drug);
        }

        public bool updateDrug(Drug drug)
        {
            String queryCmd = "select * from drug where id = '" + drug.id + "'";
            bool exist = db.queryDataTable(queryCmd).Rows.Count == 1;

            String cmd = "insert into drug values ('" + drug.id + "', '" + drug.name + "', '" + drug.price + "', '"
                + drug.type + "', '" + drug.comment + "', '" + drug.count + "')";

            if (exist)
            {
                cmd = "update drug set name = '" + drug.name + "', price = '" + drug.price + "', type = '" + drug.type +
                    "', count = '" + drug.count + "', comment = '" + drug.comment + "' where id = '" + drug.id + "'";
            }

            return db.update(cmd);
        }

        public Drug getDrugById(String id)
        {
            DataTable table = db.queryDataTable("select id, name, price, type, comment, count from drug where id = '" + id + "'");
            if (table.Rows.Count == 0)
            {
                return null;
            }

            DataRow row = table.Rows[0];
            Drug drug = new Drug();

            drug.id = row.Field<String>("id");
            drug.name = row.Field<String>("name");
            drug.price = row.Field<Single>("price").ToString();
            drug.type = row.Field<String>("type");
            drug.comment = row.Field<String>("comment");
            drug.count = row.Field<int>("count");

            return drug;
        }

        public DataTable getDrugDataTable()
        {
            String cmd = @"select id as 编号, name as 名称, price as '价格（RMB）', type as 类型, count as 数量, comment as 备注 from drug order by name";
            return db.queryDataTable(cmd);
        }
    }
}