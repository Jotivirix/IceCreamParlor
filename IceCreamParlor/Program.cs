

//Set the environment variable in Visual Studio if you get any error with following line.
using IceCreamParlor;
/**
* 
* Author: José Ignacio Navas Sanz+
* Date: 17th October 2023
* Description: HackerRank Ice Cream Parlor Solution in C# for Alstom Company
* 
*/
TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//Trips that will be done to the Ice Cream Parlor
int trips = Convert.ToInt32(Console.ReadLine().Trim());

//iterate over trips
for (int tItr = 0; tItr < trips; tItr++)
{
    //Money collected
    int money = Convert.ToInt32(Console.ReadLine().Trim());

    //Number of ice cream prices
    int numberOfPrices = Convert.ToInt32(Console.ReadLine().Trim());

    //Array of prices
    List<int> arrayOfPrices = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

    //Result - The position of the ice creams that will be bough
    List<int> result = Result.IcecreamParlor(money, arrayOfPrices);

    //Adding the result in text format to the file previously defined 
    textWriter.WriteLine(String.Join(" ", result));
}

//Free resources and close all the items blocked by the program
textWriter.Flush();
textWriter.Close();