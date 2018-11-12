using System;
public static class MakeArrayConsecutiveTwo
{
    public static void GetArrayConsecutive(int[] statues)
    {
        var smallest = statues[0];

        for(var i = 0; i < statues.Length; i++)
        {
            for(var j = 0; j < statues.Length; j++)
            {
                if (statues[j] < smallest)
                {
                    var temp = statues[i];
                    statues[i] = statues[j];
                    statues[j] = temp;
                    smallest = statues[j];
                }
            }
        }

        for(var i = 0; i < statues.Length; i++)
        {
            Console.WriteLine(statues[i]);
        }
    }
}