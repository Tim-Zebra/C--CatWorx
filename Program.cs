using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> myScoreBoard = new Dictionary<string, int>();

            myScoreBoard.Add("firstInning", 10);
            myScoreBoard.Add("secondInning", 20);
            myScoreBoard.Add("thirdInning", 30);
            myScoreBoard.Add("fourthInning", 40);
            myScoreBoard.Add("fifthInning", 50);

            // Dictionary<string, int> myScoreBoard = new Dictionary<string, int>(){
            // { "firstInning", 10 },
            // { "secondInning", 20},
            // { "thirdInning", 30},
            // { "fourthInning", 40},
            // { "fifthInning", 50}
};
        }
    }
}
