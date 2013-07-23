using System;


class FirstBigger
{
    
    static int FirstBiggerMember(int[] array)
    {
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (FindBiggerNeighbour.IsBiggerNeighbour(i, array))//I added class FindBiggerNeighbour to references and made it public
            {
                index = i;
                break;
            }
                               
        }
        return index;

    }


    static void Main()
    {
        int[] myArray = { 2, 7, 8, 7, 18, 14, 16, 15 };
        if (FirstBiggerMember(myArray)>-1)
        {
            Console.WriteLine("First member in the array which is bigger than its neighbours is on possition {0}.",FirstBiggerMember(myArray));
        }
        else
        {
            Console.WriteLine("There is no member in your array which is bigger than its neighbours.");
        }
    }
}
