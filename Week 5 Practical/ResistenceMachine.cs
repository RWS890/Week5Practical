using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using Week_5_Practical;

namespace Week_5_Practical
{
 class ResistenceMachine
    {
        private int weightStackMax;
        private int resistanceMachine;

        // Public property
        public int WeightStackMax
        {
            get { return weightStackMax; }
            set
            {
                if (value > 0)
                {
                    weightStackMax = value;
                }
                else
                {
                    Console.WriteLine("Error: Weight stack must be greater than zero.");
                }
            }
        }

        public ResistenceMachine(int equipmentId, string name, bool isAvailable, int weightStackMax)
             : base(equipmentId, name, isAvailable)
        {
            this.WeightStackMax = weightStackMax;
            
        }
    }
}



