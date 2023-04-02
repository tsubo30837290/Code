using System;

public class B
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();

        string t = "";

        for (int i = 0; i < n; i++)
        {
            char c = s[i];

            // 文字列 t に含まれる文字 c のインデックスを調べる
            int index = t.IndexOf(c);

            if (index != -1)
            { // 文字 c が文字列 t に含まれる場合
              // 文字 c が複数含まれる可能性があるため、全て置換する
                t = t.Remove(index, 1);
            }

            t += c.ToString();
        }

        Console.WriteLine(t);
    }
}
