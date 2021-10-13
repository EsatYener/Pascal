using System;
public class Pascal
{
    public static void Main()
    {
        int row, c = 1, i, j, k;
        while (true)
        {
            Console.Write("Enter number of rows: ");
            string kosul=Console.ReadLine();
            while (!(int.TryParse(kosul, out row) && row > 0))
                {
                    Console.Write("Sıfırdan küçük veya sıfır giremezseniz.");
                    Console.Write("Yeniden sayı giriniz:");
                    kosul = Console.ReadLine();
                }
            

            for (i = 0; i < row; i++)
            {
                for (j = 1; j <= row - i; j++)
                    Console.Write("  ");
                for (k = 0; k <= i; k++)
                {
                    if (i == 0 || k == 0)
                        c = 1;
                    else
                        c = c * (i - k + 1) / k;
                    Console.Write("{0}   ", c);
                }
                Console.Write("\n");
            }

        }
    }
}