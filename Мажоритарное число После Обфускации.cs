using System;
using System.Linq;

class Program
{static void Main(){Random r=new Random();int[]n=new int[1000];for(int i=0;i<1000;i++){n[i]=r.Next(0,1001);}int ME=SEARCH_ME(n);if(ME!=-1){Console.WriteLine($"Мажоритарное число:{ME}");}else{Console.WriteLine("Мажоритарного числа нет.");}}
 static int SEARCH_ME(int[]n){int a=-1;int b=0;foreach(var k in n){if(b==0){a=k;b=1;}else if(k==a){b++;}else{b--;}}b=0;foreach(var k in n){if(k==a){b++;}}if(b>n.Length/2){return b;}else{return-1;}}}
