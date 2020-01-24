using System;

namespace SuminTriangle
{
    class MaximumSum
    {
        static void Main(string[] args)
        {
           
            int row, column,m;
            Console.WriteLine("Enter the Number of Rows and Columns : ");
            m = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[100,100];
            string[] number = new string[100];
            
            
            Console.WriteLine("The Matrix is:");
            for ( row = 0; row < m; row++)
            {
                number[row] = Console.ReadLine();
                for (column = 0; column <= row-2; column++)
                {
                   array[row,column] = Int32.Parse(number[row].Split(' ')[column]);   
                }      
            }

            /*loop for sum of maximum number calculation*/
            for ( row = m - 1; row >= 0; row--) 
            { 
            for (column = 0; column <= row; column++) 
                {
                 if (array[row + 1,column] >  
                    array[row + 1,column + 1])
                    {
                       array[row,column] += array[row + 1,column];        
                    }  
                else
                   {
                       array[row,column] += array[row + 1,column + 1]; 
                   }
                }
            }
            Console.Write("\nSums in a Triangle is : ");
            Console.Write("{0}\t",array[0,0]);
            Console.Write("\n");
           }
       }
    }



