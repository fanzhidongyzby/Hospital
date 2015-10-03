using System;
namespace Hospital
{
    public class Drug
    {
        public String id;
        public String name;
        public String price;
        public String type;
        public String comment;
        public int count;

        public Drug() { }

        public Drug(String id, String name, String price, String type, int count, String comment) 
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.type = type;
            this.count = count;
            this.comment = comment;
        }

        public override String ToString()
        {
            return id + ", " + name + ", " + price + ", " + type + ", " + comment + ", " + count;
        }
    }
}