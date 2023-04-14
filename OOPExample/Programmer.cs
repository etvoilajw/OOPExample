using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    public class Programmer : Creator
    {
        public override void Create()
        {
            if (base.CreativityLevel > 70 && base.Energy >= 80)
            {
                this.BrainstormSolutions();
                this.PickMostOptimalSolution();
                this.WriteCode();
                this.TestCode();
            }
            else
            {
                throw new Exception("Cannot create a program. Out of ideas and/or tired");
            }
        }

        private void BrainstormSolutions()
        {
            base.CreativityLevel = base.CreativityLevel - 15;
            base.Energy = base.Energy - 10;
            Console.WriteLine("Brainstorming solutions...");

        }

        private void PickMostOptimalSolution()
        {
            CreativityLevel = CreativityLevel - 5;
            Energy = Energy - 5;
            Console.WriteLine("Picking most optimal solution...");
        }

        private void WriteCode()
        {
            CreativityLevel = CreativityLevel - 7;
            Energy = Energy - 5;
            Console.WriteLine("Writing code...");
        }

        private void TestCode()
        {
            CreativityLevel = CreativityLevel - 3;
            Energy = Energy - 3;
            Console.WriteLine("Testing code...");
        }
    }
}
