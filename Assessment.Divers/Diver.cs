using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment.Divers
{
    public class Diver
    {
        public string Name { get; set; }
        public List<string> Fish { get; set; }
        public Diver(string name)
        {
            Name = name;
            Fish = new List<string>();
        }

        public void AddFish(string fish)
        {
            Fish.Add(fish);
        }

        public string GetDescription()
        {
            if (Fish.Count == 0)
            {
                return $"{Name} doesn't like any fish";
            }

            string fish = string.Join(",", Fish);

            return $"{Name} likes {fish.ToLower()}";
        }

        public List<string> FishesSortedAlphabetically(int numOfLetters)
        {
            List<string> fishAlphabetically = new List<string>();

            foreach (var fish in Fish)
            {
                if (fish.Length >= numOfLetters)
                {
                    fishAlphabetically.Add(fish);
                }
            }



            fishAlphabetically.Sort();
            return fishAlphabetically;
        }

        public object FishesSortedAlphabetically_Linq(int numOfLetters)
        {
            var q = Fish
                 .Where(f => f.Length >= numOfLetters)
                 .OrderBy(f => f);
            return q;

        }

        
        int position = 0;
        string operatorToBeUsed;
        
        public int GetPosition()
        {
            return position;
        }

        public void SetDirectionDown()
        {
            operatorToBeUsed = "-";
        }


        public void SetDirectionUp()
        {
            operatorToBeUsed = "+";
        }
        public void Swim()
        {
            if (operatorToBeUsed == "-")
            {
                position--;
            }
            else if (operatorToBeUsed == "+")
            {
                position++;
            }
        }
    }
}
