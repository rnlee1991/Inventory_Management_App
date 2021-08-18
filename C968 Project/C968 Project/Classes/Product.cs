using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Project
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product(int p1, string p2, decimal p3, int p4, int p5, int p6)
        {
            ProductID = p1;
            Name = p2;
            Price = p3;
            InStock = p4;
            Min = p5;
            Max = p6;
        }
       
        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        public bool removeAssociatedPart(int PartID)
        {
            var partToRemove = AssociatedParts.Where(p => p.PartID == PartID).FirstOrDefault();
            if (partToRemove == null)
                throw new Exception(message: $"A part with ID #{PartID} is not associated with this product.");

            AssociatedParts.Remove(partToRemove);
            return true;
        }
        public Part lookupAssociatedPart(int PartID)
        {
            var part = AssociatedParts.Where(p => p.PartID == PartID).FirstOrDefault();
            if (part == null)
                throw new Exception(message: $"A part with ID #{PartID} is not associated with this product.");

            return part;
        }

    }
}
