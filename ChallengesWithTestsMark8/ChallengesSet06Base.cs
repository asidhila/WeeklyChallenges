using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06Base
    {

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> nthElement = new List<double>();
            double[] nullCheck = new double[0];

            if (elements == null)
            {
                return nullCheck;
            }
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    nthElement.Add(elements[i]);
                }

                if (n < 0 || n > elements.Count)
                {
                    nthElement.Clear();
                }
            }

            return nthElement.ToArray();


        }
    }
}