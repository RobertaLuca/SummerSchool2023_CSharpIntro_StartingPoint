namespace CSharp_Training;

public class Collections
{
    public static void List()
    {
        /* TODO 6
         * Create a list and initialize it using Add method
         * Create a list with initializer
         * Print list elements using for loop and foreach
         */

        List<int> list = new();

        list.Add(0);
        list.Add(1);
        list.Add(2);

        List<int> listWithInitializer = new()
        {
            0,
            1,
            2
        };

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        foreach (var item in listWithInitializer)
        {
            Console.WriteLine(item);
        }
    }

    public static void Dictionary()
    {
        /* TODO 7
         * Create a dictionary and initialize it (2 methods)
         * Print the elements using for loop and foreach
         * .ToString() is not mandatory, but it is recommended for value types
         */

    }

    public static void Arrays()
    {
        // TODO 8: Arrays

        int[] a = new int[3];
        a[0] = 1;
        a[1] = 2;
        a[2] = 3;

        int[] b = new int[] { 1, 2, 3 };

        int[] c = { 1, 2, 3 };

        foreach (var item in a)
        {
            Console.WriteLine(item);
        }
    }
}
