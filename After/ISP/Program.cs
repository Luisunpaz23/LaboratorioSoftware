﻿using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Run();

            Fish fish = new Fish();
            fish.Eat();
            fish.Swim();
        }
    }
}
