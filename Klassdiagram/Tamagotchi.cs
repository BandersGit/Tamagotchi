using System;
using System.Collections.Generic;
namespace Klassdiagram
{
    public class Tamagotchi
    {
        private int hunger = 5;

        private int boredom = 5;

        private List<string> words = new List<string>();

        private bool isAlive = true;

        private Random generator = new Random();

        public string name;


        public void Feed()
        {
            hunger = -1;
        }

        public void Hi()
        {
            System.Console.WriteLine(words[generator.Next(0, words.Count)]);
            ReduceBoredom();
        }

        public void Teach(string word)
        {
            words.Add(word);
            ReduceBoredom();
        }

        public void Tick()
        {
            hunger = +1;

            boredom = +1;
        }

        public void PrintStats()
        {
            System.Console.WriteLine(hunger + boredom);

            if (isAlive == true)
            {
                System.Console.WriteLine("It's alive!");
            }
        }

        public bool GetAlive()
        {
            if (hunger == 10 || boredom == 10)
            {
                isAlive = false;
            }

            return isAlive;
        }

        private void ReduceBoredom()
        {
            boredom = -1;
        }
    }
}
