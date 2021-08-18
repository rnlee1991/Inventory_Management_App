using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Project
{
    public static class Inventory
    {
        public static BindingList<Part> AllParts = new BindingList<Part>();
        public static BindingList<Product> Products = new BindingList<Product>();

        public static void addProduct(Product product)
        {
            Inventory.Products.Add(product);
        }

        public static bool removeProduct(int ProductID)
        {
            var productToRemove = Products.Where(p => p.ProductID == ProductID).FirstOrDefault();
            if (productToRemove == null)
                throw new Exception($"Product with ID #{ProductID} could not be found.");

            if (productToRemove.AssociatedParts.Any())
                throw new Exception("Product has associated parts and cannot be deleted. Please remove any associated parts.");

            Products.Remove(productToRemove);
            return true;
            
        }
        public static Product lookupProduct(int ProductID)
        {
            return Products.Where(p => p.ProductID == ProductID).FirstOrDefault();
        }

        public static void updateProduct(int ProductID, Product product)
        {
            var productToUpdate = Products.Where(p => p.ProductID == ProductID).FirstOrDefault();
            if (productToUpdate == null)
                throw new Exception(message: $"A product with ID #{ProductID} could not be found.");

            productToUpdate.Name = product.Name;
            productToUpdate.Price = product.Price;
            productToUpdate.InStock = product.InStock;
            productToUpdate.Min = product.Min;
            productToUpdate.Max = product.Max;
        }

        public static void addPart(Part part)
        {
            AllParts.Add(part);
        }

        public static bool deletePart(Part part)
        {
            var partToDelete = AllParts.Where(p => p.PartID == part.PartID).FirstOrDefault();
            if (partToDelete == null) return false;

            AllParts.Remove(part);
            return true;
        }
        public static Part lookupPart(int PartID)
        {
            return AllParts.Where(p => p.PartID == PartID).FirstOrDefault();
        }

        public static void updatePart(int PartID, Part part)
        {
            var partToUpdate = AllParts.Where(p => p.PartID == PartID).FirstOrDefault();
            if (partToUpdate == null)
                throw new Exception(message: $"A part with ID #{PartID} could not be found.");

            var index = AllParts.IndexOf(partToUpdate);
            if(index != -1)
            {
                AllParts[index] = part;
            }
        }
        
    }
    
}
