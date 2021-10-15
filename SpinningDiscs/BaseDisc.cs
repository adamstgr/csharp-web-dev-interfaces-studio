using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public int StorageCapacity { get; set; }
        public string Label { get; set; }
        
        public BaseDisc(int storageCapacity, string label)
        {
            StorageCapacity = storageCapacity;
            Label = label;
        }

        public void GiveManufacturer(string manufacturer)
        {
            Console.WriteLine($"The manufacturer of this particular round thing is {manufacturer}.");
        }
    }
}
