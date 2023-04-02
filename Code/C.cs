using System;

public class C 
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string s = "";
        while (n > 0)
        {
            int r = n % 36;
            if (r < 10)
            {
                s = r.ToString() + s;
            }
            else
            {
                char c = (char)('A' + r - 10);
                s = c.ToString() + s;
            }
            n /= 36;
        }
        if (s == "") s = "0";

        Console.WriteLine(s);
    }
}
