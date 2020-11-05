using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press '0' to stop counting");
            List<double> holdingList = new List<double>();

            //Accepts an input value
            for (int i = 0; ; i++)
            {
                holdingList.Add(Input());
                if (holdingList[i] == 0)
                    break;
            }

            double originalTotalMinutes = 0;
            List<double> minuteList = new List<double>();
            //Removes the decimal value and creates an integer value           
            for (int i = 0; i < holdingList.Count; i++)
            {
                double truncatedMintues = Math.Truncate(holdingList[i]);
                minuteList.Add(truncatedMintues);
                //This could be deleted, *maybe
                originalTotalMinutes = minuteList.Sum();
            }

            //Console.WriteLine("Sum: " + originalTotalMinutes);

            double holdingSeconds = 0;
            //Gets the decimal value and stores them into a list
            List<double> secondsList = new List<double>();
            for (int i = 0; i < holdingList.Count; i++)
            {
                holdingSeconds = holdingList[i] - minuteList[i];
                secondsList.Add(holdingSeconds);
            }

            //Takes the seconds array and turns them into mintues
            double totalSeconds = (secondsList.Sum() * 100) / 60;
            //Console.WriteLine("Total seconds part: " + totalSeconds);
            
            //From seconds we have minutes and now need to remove any remaining seconds
            double additionalMinutes = Math.Truncate(totalSeconds);
            //Console.WriteLine("Additional mintues: " + additionalMinutes);

            //Add the original mintues to new mintues(from seconds)
            double totalMinutes = originalTotalMinutes + additionalMinutes;
            //Console.WriteLine("New total minutes: " + totalMinutes);
            
            //Take the remaining seconds and turn them from decimal to seconds
            double seconds = (totalSeconds - additionalMinutes) * 60;
            double roundedSeconds = Math.Round(seconds);
            //Console.WriteLine(roundedSeconds);

            //Take the minutes and convert them to hours if needed
            double originalTotalHours = 0;
            double originalHours = 0;
            double holdingMinutes = 0;
            double minutesPart = 0;
            double roundedMinutes = 0;

            if (totalMinutes >= 60)
            {
                originalTotalHours = totalMinutes / 60;
                originalHours = Math.Truncate(originalTotalHours);
                holdingMinutes = originalTotalHours - originalHours;
                minutesPart = holdingMinutes * 60;
                roundedMinutes = Math.Round(minutesPart);
                
                Console.WriteLine("Total time: {0} hours: {1} minutes: {2} seconds",originalHours, roundedMinutes, roundedSeconds);
            }
            else if (totalMinutes < 60)
            {
                Console.WriteLine("Total time: {0} minutes: {1} seconds", totalMinutes, roundedSeconds);
            }


            Console.ReadLine();
        }

        static double Input()
        {
            Console.WriteLine("Enter in a number: ");
            double inputValue = Convert.ToDouble(Console.ReadLine());
            return inputValue;
        }
    }
}
