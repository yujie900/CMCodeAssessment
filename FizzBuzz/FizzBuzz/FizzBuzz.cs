using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        public FizzBuzz ()
        {
            CustomTexts = new Dictionary<int, string>();
        }
        private Dictionary<int, string> CustomTexts;
        public List<string> GetFizzBuzz(int lowerBound, int upperBound)
        {
            List<string> results = new List<string>();
            for (int i = lowerBound; i<=upperBound;i++)
            {
                if (i % 3 == 0 && i %5 == 0)
                {
                    results.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    results.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    results.Add("Buzz");
                }
                else
                {
                    results.Add(i.ToString());
                }
            }
            return results;
        }
        public void SetCustom(int index, string displayText)
        {
            CustomTexts.Add(index, displayText);
        }
        public List<string> GetCustom(int lowerBound, int upperBound)
        {
            List<string> results = new List<string>();
            for (int i = lowerBound; i <= upperBound; i++)
            {
                bool hasAdded = false;
                foreach (int key in CustomTexts.Keys)
                {
                    if (i % key == 0)
                    {
                        if (!hasAdded)
                        {
                            results.Add(CustomTexts[key]);
                            hasAdded = true;
                        }
                        else
                        {
                            results[i-1] = results[i-1] + CustomTexts[key];
                        }
                    }
                }
                if (!hasAdded)
                {
                    results.Add(i.ToString());
                }
            }
            return results;
        }
    }
}
