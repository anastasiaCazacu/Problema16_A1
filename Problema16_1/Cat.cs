using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema16_1
{
    internal class Cat : Animal, IRunnable
    {
        public override void MakeSound()
        {
            Console.WriteLine("Pisica face miau.");
        }
        public override void Eat()
        {
            Console.WriteLine("Animalul mananca peste.");
        }
        public void Run()
        {
            Console.WriteLine("Pisica alearga.");
        }
    }
}
