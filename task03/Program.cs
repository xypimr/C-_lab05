namespace task03;

class Program
{
    static void Main(string[] args)
    {
        MyDictionary<string, string> dic = new MyDictionary<string, string>();
        Console.WriteLine(dic.Capacity);
        dic.Add("qwe", "123");
        dic.Add("asd", "456");
        foreach (var i in dic)
        {
            Console.WriteLine($"{i}\t");
        }
    }
}