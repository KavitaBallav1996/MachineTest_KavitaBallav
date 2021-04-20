using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricPairs_Application
{
    #region ### Class ###
    //Create class SymmetricPairs
    public class SymmetricPairs
    {
        #region ###### Method ######
        //Create method Find Symmetric Pairs
        static void findSymmetricPairs(int[,] array)
        {
            //Create object of dictionary
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int value = 0;

            for (int i = 0; i < array.GetLength(0);i++ )
            {
                //Declaring objects
                int firstValue = array[i,0];
                int secondValue = array[i,1];

                //Store key and value
                if (dic.ContainsKey(secondValue))
                {
                    value = dic[secondValue];
                }

                //Check whether the values of two pair is symmetric or not
                if (value != 0 && value == firstValue)
                {
                   
                    Console.WriteLine("("+secondValue+","+firstValue+")");
                }
                else
                {
                    dic.Add(firstValue,secondValue);
                }

            }
        }
        #endregion

        #region ### Main Function ###
        //Main Function
        public static void Main(string[] args)
        {
            //Add input
            int[,] input = new int[5, 2];

            //User defined input
            System.Console.WriteLine("Enter the values: ");
            for (int x = 0; x < input.GetLength(0); x++)
            {
                input[x, 0] = int.Parse(Console.ReadLine());
                input[x, 1] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(); 

            //Display the pairs
            Console.WriteLine("Following pairs have symmetric pairs");
            findSymmetricPairs(input);

            Console.ReadLine();

        }
        #endregion
    }
    #endregion 
}
