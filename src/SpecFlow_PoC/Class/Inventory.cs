using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow_PoC.Class
{
    public class Inventory
    {
        public int CurrentQuantity { get; set; }

        public int Set (int initialQuantity)
        {
            return CurrentQuantity = initialQuantity;
        }

        public int Add(int quantityToAdd)
        {
            CurrentQuantity += quantityToAdd;
            return CurrentQuantity;
        }

        public int GetQuantity() 
        { 
            return CurrentQuantity;
        }

        public int Remove(int quantityToRemove)
        {
            CurrentQuantity -= quantityToRemove;
            return CurrentQuantity;
        }
    }
}
