using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
//int a,b,c ;
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
//C
//c = Convert.ToInt32(Console.ReadLine());

//int l = (a + b) / 2;
//if (l == c) { Console.WriteLine("true"); }
//else { Console.WriteLine("false"); }    

//int max,min;
//Console.Write("a=");//39onsole.Write("a=");
//a = Convert.ToInt32(Console.ReadLine());
//Console.Write("b=");
//b = Convert.ToInt32(Console.ReadLine());
//Console.Write("c=");
//a = Convert.ToInt32(Console.ReadLine());
//Console.Write("b=");
//b = Convert.ToInt32(Console.ReadLine());
//Console.Write("c=");
//c = Convert.ToInt32(Console.ReadLine());
//if (a > b) { max = a; min = b; }
//else { max = b; min = a; }
//if (c < min) { Console.Write(c+"  "); Console.Write(min+"  "); Console.Write(max); }
// else {if (c > max) { Console.Write(min+"  "); Console.Write(max+"  "); Console.Write(c); }
//          else 
//         { Console.Write(max+" "); Console.Write(min + "  "); Console.Write(c); }
//    }


//int x, n;//151
//double s=0;
//int j = 1;
//Console.Write("x=");
//x = Convert.ToInt32(Console.ReadLine());
//Console.Write("n=");
//n = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i <= n; i++)
//{
//    for (i = 0; i <= n; i++) { j *= i + 1; }
//    s += Math.Pow(Math.Log(3), n) * Math.Pow(x, n) / j;
//}
//Console.WriteLine("s=" + s);


//int x, n;//151
//double s = 0;
//int j = 1;
//Console.Write("x=");
//x = Convert.ToInt32(Console.ReadLine());
//Console.Write("n=");
//n = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//{
//    for (i = 1; i <= n*n; i++) { j *= i + 1; }
//    s += Math.Pow(n*x*x,n) / j;
//}
//Console.WriteLine("s=" + s);


//int x,s=0;//151

// Console.Write("x=");
//x = Convert.ToInt32(Console.ReadLine());
//for (int i = 1;i<=10000 ; i++)
//{

//    if ((i % x) == 0) {s+= i; }
// }
//Console.WriteLine(s);


//int s = 0;//155
//for(int i = 12; i <= 99; i = i + 3)
//{
//     s = s + i;
//}Console.WriteLine("s="+s);


//int p = 1;//159
//for (int i = 100; i <= 1000; i++)
//{
//    if (i % 3 == 1 && i % 4 == 2)

//        p = p*i;

//}
//Console.WriteLine("p="+p);

//int p = 1;
//int i = 100;
//do
//{
//    if (i % 3 == 1 && i % 4 == 2)
//    {
//        p *= i;
//    }
//} while (i <= 1000);
//Console.WriteLine("p=" + p);
//Console.ReadKey();

//int p = 1;
//int i = 100;
//while (i <= 1000)
//{
//    if (i % 3 == 1 && i % 4 == 2)
//    {
//        p *= i;
//    }
//}
//Console.WriteLine("p=" + p);
//Console.ReadKey();






//for (int i = 9999; i >= 1000; i--)//163
//{
//    if ((Math.Sqrt(i * 26) - Math.Truncate(Math.Sqrt(i * 26))) == 0) { Console.WriteLine(i); break; }

//}





//int[] arrey = new int[8];//221
//for (int i = 0; i < arrey.Length; i++)
//{
//    arrey[i] = Convert.ToInt32(Console.ReadLine());
    
//}
//for (int i = 0; i < arrey.Length; i++)
//{
//    if (arrey[i] > 0)
//    {
//        Console.Write(arrey[i]);
//    }
//}