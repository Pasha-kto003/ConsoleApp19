using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Kabosu", new DateTime(2010, 8, 10)); // ada
            Console.WriteLine($" Возраст Кабосу: { dog.Age} лет"); //Имя переводим на русский
            ((IWalking)dog).Walk();

            Butterfly but = new Butterfly("Machaon", new DateTime(2019, 10, 10));
            Console.WriteLine($"Возраст Махаона : { but.Age} год");
            ((IFlying)but).Fly();

            Bird bidy = new Bird("Tanusha",  new DateTime( 2007, 7, 7));
            Console.WriteLine($"Возраст Танюши: {bidy.Age} лет");
            ((IFlying)bidy).Fly();

            Fish fsh = new Fish("Nemo", new DateTime(2007, 7, 12));
            Console.WriteLine($"Возраст Немо: { fsh.Age} лет");
            ((ISwimming)fsh).Swim();
        }

    }
}
