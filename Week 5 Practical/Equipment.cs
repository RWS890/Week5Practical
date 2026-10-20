using System;
using System.Collections.Generic;
using System.Text;

namespace Week_5_Practical
{
    internal class Equipment
    {
        private int equipmentID;
        private string name;
        private bool isAvailable;

        // Public properties routing the data
        public int EquipmentID
        {
            get { return equipmentID; }
            set { equipmentID = value; }
        }
        public string Name
        {
            get { return Name; }
            set
        {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Error: Equipment name cannot be blank.");
                }
            }
        }
        
        public bool IsAvailable
        {
            get { return isAvailable = value; }
            set { }
        }
        public Equipment(int memberID, string name, bool isAvailable)
        {
            // Data is securely routed through the public properties
            this.equipmentID = equipmentID;
            this.Name = name;
            this.isAvailable = isAvailable;
        }
    }
}
