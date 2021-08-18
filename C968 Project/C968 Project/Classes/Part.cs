using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Project
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

    }

    public class InHousePart : Part
    {
        public int MachineID { get; set; }
        public InHousePart(int p1, string p2, decimal p3, int p4, int p5, int p6, int mID)
        {
            PartID = p1;
            Name = p2;
            Price = p3;
            InStock = p4;
            Min = p5;
            Max = p6;
            MachineID = mID;
        }
    }
    public class OSPart : Part
    {
        public string CompanyName { get; set; }
        public OSPart(int p1, string p2, decimal p3, int p4, int p5, int p6, string CN)
        {
            PartID = p1;
            Name = p2;
            Price = p3;
            InStock = p4;
            Min = p5;
            Max = p6;
            CompanyName = CN;
        }
    }
}
