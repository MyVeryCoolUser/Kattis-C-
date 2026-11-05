namespace Kattis_QualityAdjustedLifeYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // NOTE: qualityYearString MUST be formatted as (num 1) (num 2) in the 
                // Gets the number of years, dictating the number of times the for loop runs.
                string yearsEntry = Console.ReadLine();
                int numOfYears = int.Parse(yearsEntry);
                double overallQuality = 0;

                // Takes two numbers entered and splits into 2 array indexes so both numbers can be used

                for (int i = 0; i < numOfYears; i++)
                {
                    string qualityYearString = Console.ReadLine();
                    string[] qualityYearSection = qualityYearString.Split(" ");
                    double quality = double.Parse(qualityYearSection[0]);
                    double years = double.Parse(qualityYearSection[1]);
                    double yearQuality = quality * years;
                    overallQuality = overallQuality + yearQuality;
                }
                Console.WriteLine(overallQuality);
        }
    }
}
