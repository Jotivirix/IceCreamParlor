/**
 * 
 * Author: José Ignacio Navas Sanz+
 * Date: 17th October 2023
 * Description: HackerRank Ice Cream Parlor Solution in C# for Alstom Company
 * 
 */

namespace IceCreamParlor
{
    public class Result
    {

        public Result() { }

        /// <summary>
        /// IcecreamParlor should calculate which flavours can be combined
        /// with the money pooled. The solution has to be unique and it can
        /// not be exceeded money.
        /// </summary>
        /// <param name="m">Money pooled</param>
        /// <param name="arr">Array of prices of ice cream flavors</param>
        /// <returns>List of position of ice cream flavor that can buy with pooled money</returns>
        public static List<int> IcecreamParlor(int money, List<int> arr)
        {
            List<int> flavorPos = new List<int>();

            for (int i = 0; i < arr.Count; i++)
            {
                //The price is lower than the money we have.
                //We should add unless is the second flavour, where we want to spend all the money
                if (arr[i] < money)
                {
                    if (flavorPos.Count == 0)
                    {
                        flavorPos.Add(i + 1);
                        money -= arr[i];
                    }
                }
                else if (arr[i] == money)
                {
                    if (flavorPos.Count == 1)
                    {
                        //Add
                        flavorPos.Add(i + 1);
                        money -= arr[i];
                        break;
                    }
                }
            }

            //Sorting the positions array
            flavorPos.Sort();

            return flavorPos;
        }
    }
}
