internal class Program
{
    private static void Main(string[] args)
    {
        int num;

        Console.Write("INFORME O NÚMERO DE TERMOS DESEJADO: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num < 1)
        {
            Console.WriteLine("INFORME UM NÚMERO MAIOR QUE ZERO.");
        }
        else
        {
            int f1 = 1; int f2 = 1;
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(f1);
                int next_termo = f1 + f2;
                f1 = f2;
                f2 = next_termo;
            }
        }
    }
}
