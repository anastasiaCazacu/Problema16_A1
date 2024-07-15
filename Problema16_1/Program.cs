namespace Problema16_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal caine1 = new Dog();
            Animal pisica1 = new Cat();

            pisica1.MakeSound();
            pisica1.Eat();

            caine1.MakeSound();
            caine1.Eat();

            Console.WriteLine("\nUtilizarea interfetei IRunnable");
            IRunnable runnableDog = caine1 as IRunnable;
            IRunnable runnableCat = pisica1 as IRunnable;

            if (runnableDog != null)
            {
                runnableDog.Run();
            }

            if (runnableCat != null)
            {
                runnableCat.Run();
            }
        }
    }
}
