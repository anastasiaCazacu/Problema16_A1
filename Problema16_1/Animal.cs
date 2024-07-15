using System;
namespace Problema16_1
{
    abstract class Animal
    {
        public abstract void MakeSound();
        public virtual void Eat()
        {
            Console.WriteLine("Animalul mananca.");
        }
    }
}
