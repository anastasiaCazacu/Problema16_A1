using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema16_1
{
    internal class Dog:Animal, IRunnable
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cainele latra.");
        }
        public override void Eat() {
            Console.WriteLine("Animalul mananca oase.");
        }
        public void Run()
        {
            Console.WriteLine("Cainele alearga.");
        }
    }
}
