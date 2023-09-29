Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Приклад 1:");

string s = "Dfg+t5-r7y;asd*s34;rt";
int t = s.IndexOf(';');
int i, k = 0;
for (i = 0; i <= t; i++)
{
    if (char.IsLetter(s[i])) k++;
}
Console.WriteLine(k);
Console.ReadKey();

Console.WriteLine("Приклад 2:");
string s1 = "АУАУАПАУК";
int i1 = 0;
do
{
    string ss = s1.Substring(i1,2);
    if (ss == "АУ")
    {
        s1 = s1.Insert(i1, "O"); i1 = i1 + 3;
    }
    else
    {
        i1++;
    };
}
while (i1 < s1.Length -1);
Console.WriteLine(s1);
Console.ReadKey();

Console.WriteLine("Приклад 3");
string s2 = "біологія алгебра історія географія геометрія";
string c2 = "і";
string[] a;
a = s2.Split(' ');
int i2;
for (i2 = 0; i2 < a.Length; i2++)
{
    int t2 = a[i2].IndexOf(c2);
    if (t2 != -1) Console.WriteLine(a[i2]);
}
Console.ReadKey();

Console.WriteLine("Приклад 4");
string s3 = "біологія алгебра історія географія геометрія";
string[] a3;
a3 = s3.Split(" ");
Array.Reverse(a3);
string s4 = string.Join(" ", a3);
Console.WriteLine(s4);
Console.ReadKey();