namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        int[] x = {1,2,3,4,5};
        
        Array.Reverse(x);
        foreach (int i in x) {
            Console.WriteLine(i);           
        }
    }
}
