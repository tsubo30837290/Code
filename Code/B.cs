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

            // ������ t �Ɋ܂܂�镶�� c �̃C���f�b�N�X�𒲂ׂ�
            int index = t.IndexOf(c);

            if (index != -1)
            { // ���� c �������� t �Ɋ܂܂��ꍇ
              // ���� c �������܂܂��\�������邽�߁A�S�Ēu������
                t = t.Remove(index, 1);
            }

            t += c.ToString();
        }

        Console.WriteLine(t);
    }
}
