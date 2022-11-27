using System.Security.Cryptography.X509Certificates;
using System.Text;
int a,b,c ;
int max=2;

Console.Write("a=");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("b=");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("c=");
c=Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    a = max;
}
else { b = max; }
if (max> c) { Console.WriteLine("Maximum=" + max); }
else {Console.WriteLine("Maximum="+c); }








