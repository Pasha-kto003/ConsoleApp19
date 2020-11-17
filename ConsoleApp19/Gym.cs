using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp19
{
    class Gym
    {

        List<Animal> animals= new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }
        public void LetsMove()
        {
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i] is IWalking)
                {

                    IWalking iDog = animals[i] as IWalking;
                    iDog.Walk();
                }

                else if (animals[i] is ISwimming)

                {
                    ISwimming iFish = animals[i] as ISwimming;
                    iFish.Swim();
                }

                else if (animals[i] is IFlying)
                {
                    IFlying iBird = animals[i] as IFlying;
                    iBird.Fly();
                }
                else if (animals[i] is IFlying)
                {
                    IFlying iButterfly = animals[i] as IFlying;
                    iButterfly.Fly();
                }

            }

        }

    }
}
