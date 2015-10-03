using System;
namespace Hospital
{
    public class DrugCount
    {
        public Presc presc;
        public Drug drug;
        public int count;

        public DrugCount() { }

        public DrugCount(Presc presc, Drug drug, int count)
        {
            this.presc = presc;
            this.drug = drug;
            this.count = count;
        }
    }
}