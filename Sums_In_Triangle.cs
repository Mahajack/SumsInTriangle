using System;
namespace LargestSumsInTriangle
{ 
public class SumInTriangle
{
       //First getting input elements as a string
         string[] RowElements = new string[100];
       //Formatting the input elements as a Array
          int[,]Array = new int[100,100];
          int RowIndex,ColumnIndex,NumberOfRows;

   public  void GetInputValues()
   {
      NumberOfRows = -1;
      Console.WriteLine("Enter the Number of Rows:\t");
      while( NumberOfRows<1)
      {
         NumberOfRows = Convert.ToInt32(Console.ReadLine());
         if(NumberOfRows<1)
         {
             
             Console.WriteLine("Enter an Positive Integer between 0 to 100");
         }
      }
         Console.WriteLine("Enter the Elements of an Array:");
         
         for(RowIndex = 0;RowIndex < NumberOfRows; RowIndex++)
         {
            RowElements[RowIndex] = Console.ReadLine();
             for(ColumnIndex = 0;ColumnIndex <= RowIndex; ColumnIndex++)
            {
            Array[RowIndex,ColumnIndex] = Int32.Parse(RowElements[RowIndex].Split(' ')[ColumnIndex]);
            }
        } Console.WriteLine("");
    }
   
    public void ToCalculateMaximumPathSum()
    {
        // Adding the element of row 1
        // to both the elements of row 2
        // to reduce a step from the loop
        if (NumberOfRows > 1)
            Array[1, 1] = Array[1, 1] +
                        Array[0, 0];
            Array[1, 0] = Array[1, 0] +
                        Array[0, 0];
   
        // Traverse remaining rows
        for(int RowIndex = 2; RowIndex < NumberOfRows; RowIndex++)
        {
            Array[RowIndex, 0] = Array[RowIndex, 0] +
                        Array[RowIndex - 1, 0];
            Array[RowIndex, RowIndex] = Array[RowIndex, RowIndex] +
                        Array[RowIndex - 1, RowIndex - 1];
   
            //Loop to traverse columns
            for (int ColumnIndex = 2; ColumnIndex < RowIndex; ColumnIndex++)
            {
   
                // Checking the two conditions,
                // directly below and below right.
                // Considering the greater one
               
                // tri[i] would store the possible
                // combinations of sum of the paths
                if (Array[RowIndex, ColumnIndex] + Array[RowIndex - 1, ColumnIndex - 1] >=
                    Array[RowIndex, ColumnIndex] + Array[RowIndex - 1, ColumnIndex])
               
                    Array[RowIndex, ColumnIndex] = Array[RowIndex, ColumnIndex] +
                                Array[RowIndex - 1, ColumnIndex - 1];
                   
                else
                    Array[RowIndex, ColumnIndex] = Array[RowIndex, ColumnIndex] +
                                Array[RowIndex - 1, ColumnIndex];
            }
        }
       
        // array at n-1 index (array[i])
        // stores all possible adding
        // combination, finding the
        // maximum one out of them
        int max = Array[NumberOfRows - 1, 0];
       
        for(int RowIndex = 1; RowIndex < NumberOfRows; RowIndex++)
        {
            if(max < Array[NumberOfRows - 1, RowIndex])
                max = Array[NumberOfRows - 1, RowIndex];
        }
        Console.Write("The Sums in a Triangle is: ");
        Console.WriteLine(max);
    }
    public static void Main()
    { 
        SumInTriangle sum = new SumInTriangle();
        int Iteration, IterationIndex;
        Iteration = -1;
        while(Iteration<1)
        {
        Console.WriteLine("Enter the number of Testcases:");
        Iteration = Convert.ToInt32(Console.ReadLine());
        if(Iteration<1)
         {
            Console.WriteLine("Enter an Positive Integer: ");
         }
        }
        for(IterationIndex=1;IterationIndex<=Iteration;IterationIndex++)
        {
        sum.GetInputValues();
        sum.ToCalculateMaximumPathSum();
        }
}
}
}




