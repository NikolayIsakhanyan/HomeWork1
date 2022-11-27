using System.Security.Cryptography.X509Certificates;
using System.Text;
int a,b,c ;
//int max=2;
//Console.Write("a=");//31
//a = Convert.ToInt32(Console.ReadLine());
//Console.Write("b=");
//b = Convert.ToInt32(Console.ReadLine());
//Console.Write("c=");
//c=Convert.ToInt32(Console.ReadLine());
//if (a > b)
//{
//    a = max;
//}
//else { b = max; }
//if (max> c) { Console.WriteLine("Maximum=" + max); }
//else {Console.WriteLine("Maximum="+c); }



//Console.Write("a=");//33
//a = Convert.ToInt32(Console.ReadLine());
//Console.Write("b=");
//b = Convert.ToInt32(Console.ReadLine());
//Console.Write("c=");
//c = Convert.ToInt32(Console.ReadLine());
//if(a==b || a==c || b==c) { Console.WriteLine("true"); }
//else { Console.WriteLine("false"); }


//int l = 0;//34
//Console.Write("a=");
//a = Convert.ToInt32(Console.ReadLine());
//Console.Write("b=");
//b = Convert.ToInt32(Console.ReadLine());
//Console.Write("c=");
//c = Convert.ToInt32(Console.ReadLine());
//if (a == 2) { l++; }
//if (b == 2) { l++; }
//if (c == 2) { l++; }
//if (l >= 2) { Console.WriteLine("True"); }
//else { Console.WriteLine("False"); }


//37
//Console.Write("a=");
//a = Convert.ToInt32(Console.ReadLine());
//Console.Write("b=");
//b = Convert.ToInt32(Console.ReadLine());
//Console.Write("c=");
//c = Convert.ToInt32(Console.ReadLine());

//int l = (a + b) / 2;
//if (l == c) { Console.WriteLine("true"); }
//else { Console.WriteLine("false"); }    

int max,min;
Console.Write("a=");//39
a = Convert.ToInt32(Console.ReadLine());
Console.Write("b=");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("c=");
c = Convert.ToInt32(Console.ReadLine());
if (a > b) { max = a; min = b; }
else { max = b; min = a; }
if (c < min) { Console.Write(c+"  "); Console.Write(min+"  "); Console.Write(max); }
 else {if (c > max) { Console.Write(min+"  "); Console.Write(max+"  "); Console.Write(c); }
          else 
         { Console.Write(max+" "); Console.Write(min + "  "); Console.Write(c); }
    }









