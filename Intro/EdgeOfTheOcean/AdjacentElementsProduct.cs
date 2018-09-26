using System;

public static class AdjacentElementsProduct
{
    public static int GetAdjacentElementsProduct(int[] inputArray) 
    {
        var largest = 0;
        var shortest = 0;

        var numbers = new int[inputArray.Length];
        
        for (int i = 0; i < inputArray.Length - 1; i++)
            numbers[i] = inputArray[i] * inputArray[i + 1];

        largest = numbers[0];
        shortest = numbers[0];

        for (int i = 0; i < inputArray.Length - 1; i++)
        {
            if (numbers[i] < 0)
            {
                if (numbers[i] > shortest)
                    shortest = numbers[i];
            }
            
            if (numbers[i] > 0)
            {
                if (numbers[i] > largest)
                    largest = numbers[i];
            }
        }

        return Math.Max(shortest,largest);
    }
}