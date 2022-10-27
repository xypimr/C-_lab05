namespace task02;

class Program
{
    static void Main(string[] args)
    {
        MyList<int> list = new MyList<int>(10);
        list[0] = 1;
        for (int i = 0; i < list.Capacity; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
}