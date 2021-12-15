using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventOfCode_awieckert
{
    public class Question1
    {
        ProblemIngestionHelper _problemHelper;

        public Question1()
        {
            _problemHelper = new ProblemIngestionHelper();
        }
        public int SolveThatShit()
        {
            var numberList = _problemHelper.GetListOfInts(".\\Question1Data.txt");

            var listOfIncreasingNumbers = numberList.Where((number, i) => number > ((i - 1) == -1 ? numberList[i] : numberList[i - 1]));

            return listOfIncreasingNumbers.Count();
        }

        public int SolveThatShitAgain()
        {
            var numberList = _problemHelper.GetListOfInts(".\\Question1bData.txt");

            var sum = numberList.Where((num, i) => numberList[i + 2] != -1).Select((number, i) => numberList.Take(new Range(i, i + 2)).Sum());

            return 1;
            //var sums = numberList.Select((number, i) =>
            //{
            //    if (numberList[i + 2] == -1) continue;
            //    return numberList.Take(new Range(i, i + 2)).Sum();
            //}
            //);
        }
    }
}
