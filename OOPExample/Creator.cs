using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    public abstract class Creator
    {
        private int creativityLevel = 100;

        private int energy = 100;

        public int CreativityLevel
        {
            get
            {
                return creativityLevel;
            }

            set
            {
                if (value >= 0 && value <= 100)
                {
                    creativityLevel = value; 
                }
                else
                {
                    throw new Exception("Creativity level can only a be value between 0 and 100.");
                }
            }
        }

        public int Energy
        {
            get
            {
                return energy;
            }

            set
            {
                if (value >= 0 && value <= 100)
                {
                    energy = value;
                }
                else
                {
                    throw new Exception("Energy level can only a be value between 0 and 100.");
                }
            }
        }

        public abstract void Create();
    }
}
