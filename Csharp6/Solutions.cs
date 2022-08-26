
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Reflection.Emit;
using System.Data;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics.CodeAnalysis;
using System;
using System.Linq;
namespace Csharp6
{
    public static class Solutions
    {
        
        public static void Prob1()
        {   
            // var s = double.Parse(Console.ReadLine());
            // var r = double.Parse(Console.ReadLine());
             
            // Console.WriteLine(s + r ); 
        }
        // public static void Prob2()
        // {
        //     Console.WriteLine("222222");
        //     Console.WriteLine("2    2");
        //     Console.WriteLine("2    2");
        //     Console.WriteLine("222222");
        // }

        // public static void Prob3()
        // {
        //     Console.WriteLine("  A");
        //     Console.WriteLine(" A A");
        //     Console.WriteLine("AAAAA");
        // }

        // public static void Prob4()
        // {
        //     Console.WriteLine("\\    /\\");
        //     Console.WriteLine(" )  ( ')");
        //     Console.WriteLine("(  /  )");
        //     Console.WriteLine(" \\(__)|");
        // }
        
        // public static void Prob5()
        // {
        //     Console.WriteLine("|\\_/|");
        //     Console.WriteLine("|qp| /}");
        //     Console.WriteLine("( 0 )\"\"\"\\");
        //     Console.WriteLine("|\"^\"` |");
        //     Console.WriteLine("||_/=\\__|");
        // }

        // public static void Prob6()
        // // {
        // //     var num = Console.ReadLine()
        // //         .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        // //         .Select(n => int.Parse(n))
        // //         .ToList();
        // //         Console.WriteLine($"Birthdate is {num[0]:D2}-{num[1]:D2}.");
        // // }

        // // public static void Prob7()
        // // {
        // //     var a = int.Parse(Console.ReadLine());
        // //     Console.WriteLine($"{a}{a}{a}{a}{a}{a}");
        // //     Console.WriteLine($"{a}    {a}");
        // //     Console.WriteLine($"{a}    {a}");
        // //     Console.WriteLine($"{a}{a}{a}{a}{a}{a}");

        // // }

        // public static void Prob8()
        // {
        //     // var c=0;
        //     // c = int.Parse(Console.ReadLine());
        //     // Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
        //     // Console.Write($"{c,3}");
            
        //     // c = c % 31 + 1;
        //     // Console.Write($"{c,4}");
            
        //     // c = c % 31 + 1;
        //     // Console.Write($"{c,4}");
            
        //     // c = c % 31 + 1;
        //     // Console.Write($"{c,4}");
            
        //     // c = c % 31 + 1;
        //     // Console.Write($"{c,4}");
            
        //     // c = c % 31 + 1;
        //     // Console.Write($"{c,4}");
            
        //     // c = c % 31 + 1;
        //     // Console.Write($"{c,4}");
        // }

        // public static void Prob9()
        // {   
        // //    var a = int.Parse(Console.ReadLine());

        // //    Console.WriteLine($"{a}*1={a*1}");
        // //    Console.WriteLine($"{a}*1={a*2}");
        // //    Console.WriteLine($"{a}*1={a*3}");
        // //    Console.WriteLine($"{a}*1={a*4}");
        // //    Console.WriteLine($"{a}*1={a*5}");
        // //    Console.WriteLine($"{a}*1={a*6}");
        // //    Console.WriteLine($"{a}*1={a*7}");
        // //    Console.WriteLine($"{a}*1={a*8}");
        // //    Console.WriteLine($"{a}*1={a*9}");
        // }

        // public static void Prob10()
        // {
        //     Console.WriteLine("1!=1");
        //     Console.WriteLine($"2!={1*2}");
        //     Console.WriteLine($"3!={1*2*3}");
        //     Console.WriteLine($"4!={1*2*3*4}");
        //     Console.WriteLine($"5!={1*2*3*4*5}");
        // }

        // public static void Prob11()
        // {
        //     var fib1 = 0;
        //     var fib2 = 1;
        //     var fib3 = fib1 + fib2;
        //     Console.Write($"{fib1} {fib2} {fib3}");
           
        //     fib1 = fib2;
        //     fib2 = fib3;
        //     fib3 = fib1+fib2;
        //     Console.Write($"{fib3} ");  
            
        //     fib1 = fib2;
        //     fib2 = fib3;
        //     fib3 = fib1+fib2;
        //     Console.Write($"{fib3} ");  
            
        //     fib1 = fib2;
        //     fib2 = fib3;
        //     fib3 = fib1+fib2;
        //     Console.Write($"{fib3} ");  
            
        //     fib1 = fib2;
        //     fib2 = fib3;
        //     fib3 = fib1+fib2;
        //     Console.Write($"{fib3} ");  
            
        //     fib1 = fib2;
        //     fib2 = fib3;
        //     fib3 = fib1+fib2;
        //     Console.Write($"{fib3} ");  
            
        //     fib1 = fib2;
        //     fib2 = fib3;
        //     fib3 = fib1+fib2;
        //     Console.Write($"{fib3} ");  
            
        //     fib1 = fib2;
        //     fib2 = fib3;
        //     fib3 = fib1+fib2;
        //     Console.Write($"{fib3} ");  
        // }

        // // public static void Prob12()
        // // {
        // //     var a =int.Parse(Console.ReadLine()); 
        // //     // var b = int.Parse(a);
        // //     Console.WriteLine($"{a}\n{(char)a}");
        // // } 

        // // public static void Prob13()
        // // {
        // //    var s = Console.ReadLine()
        // //     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        // //     .Select(int.Parse)
        // //     .ToList();

        // //     Console.WriteLine($"Area is {s[0] * s[1]}.");
        // // }

        // // public static void Prob14()
        // // {
        // //     var a = double.Parse(Console.ReadLine());
        // //     var b = double.Parse(Console.ReadLine());

        // //     Console.WriteLine($"Area is {a*b:F2}.");
        // // }

        // // public static void Prob15()
        // // {
        // //     var a = double.Parse(Console.ReadLine());

        // //     Console.WriteLine( $"{Math.Round(a)}");
        // // }

        // // public static void Prob16()
        // // {
        // //     Console.WriteLine($"{Console.ReadLine().ToUpper()}");
        // // }

        // // public static void Prob17()
        // // {
        // //     Console.WriteLine($"{Console.ReadLine().ToLower()}");
        // // }

        // public static void Prob18()
        // {
        // //    var a = int.Parse(Console.ReadLine());

        // //    Console.Write($"{a/10000}!");
        // //    Console.Write($"{a/1000%10}!");
        // //    Console.Write($"{a/100%10}!");
        // //    Console.Write($"{a/10%10}!");
        // //    Console.Write($"{a%10}");
        // }

        // public static void Prob19()
        // {
        //     // var sec = int.Parse(Console.ReadLine());
        //     // Console.WriteLine($"{sec/3600:D2}:{sec%3600/60:D2}:{sec%60:D2}");
        // }

        // public static void Prob20()
        // {
        //     // var a = int.Parse(Console.ReadLine());

        //     // Console.Write($"{a/100%10:D}");
        // }

        // public static void Prob21()
        // {
        //     // var a = decimal.Parse(Console.ReadLine());
        //     // a = (int)(Math.Round(a /1000) *1000);

        //     // Console.WriteLine($"{a}");
        //     //------------------------
        // //     var a = int.Parse(Console.ReadLine());
        // // if(a%1000<500)
        // // {
        // //     a =a-a%1000;
        // //     Console.WriteLine(a);
        // // }
        // // else{
        // //     a= a-a%1000+1000;
        // // }
        // //-------------------------------------
        // // var c = int.Parse(Console.ReadLine());
        // // c=(c+500)/1000 *1000;
        // // Console.WriteLine(c);
        // }

        // public static void Prob22()
        // {
        //     // var pi=3.14;

        //     // var N = int.Parse(Console.ReadLine());
        //     // var r = N/(2*pi);
        //     // var S = (pi*r*r);
        //     // Console.WriteLine($"{Math.Round(S)}");
        // }

        // public static void Prob23()
        // {
        //     // var N = int.Parse(Console.ReadLine());

        //     // if(N>=20 && N<=30){
        //     //     Console.WriteLine("1");
        //     // }
        //     // else{
        //     //     Console.WriteLine("0");
        //     // }
        // }
        // public static void Prob24()
        // {
        //     // var N = char.Parse(Console.ReadLine());
        //     // if(N>='A' && N<='Z' || N>='a' && N<='z'){
        //     //     Console.WriteLine("1");
        //     // }
        //     // else{
        //     //     Console.WriteLine("0");
        //     // }
        // }

        // public static void Prob25()
        // {
        //     // var S = int.Parse(Console.ReadLine());
        //     // {
        //     //     if(S%2==0)
        //     //     {
        //     //         Console.WriteLine("Even");
        //     //     }
        //     //     else {
        //     //         Console.WriteLine("Odd");
        //     //     }
        //     // }
        // }

        // public static void Prob26()
        // {
        //     // var A = Console.ReadLine().Split().Select(int.Parse).ToList();
        //     // var N = A[0];
        //     // var M = A[1];

        //     // if(N > M)
        //     // {
        //     //     System.Console.WriteLine(N);
        //     // }
        //     // else
        //     // {
        //     //     System.Console.WriteLine(M);
        //     // }  
        // }

        // public static void Prob27()
        // {
        // // var B = Console.ReadLine().Split().Select(int.Parse).ToList();

        // // var C = B[0];
        // // var W = B[1];
        // // if(C>W)
        // // {
        // //     Console.WriteLine(C / W);
        // //     Console.WriteLine(C % W);
        // // }
        // // else {
        // //     Console.WriteLine(W / C);
        // //     Console.WriteLine(W % C);
        // // }
        // }
  
        // public static void Prob28()
        // {
        //     // var C = Console.ReadLine().Split().Select(int.Parse).ToList();

        //     // var A = C[0];
        //     // var B = C[1];

        //     // if(A == 0)
        //     // {
        //     //     A=24;
        //     // }

        //     // var Z = A * 60 + B -45;
        //     // Console.WriteLine($"{Z/60} {Z%60}");
        // }

        // public static void Prob29()
        // {
        //     // var N = int.Parse(Console.ReadLine());
        //     // if(N < 0 && N > 39)
        //     // {
        //     //     System.Console.WriteLine("tashqarida o'yna");
        //     // }
        //     // else
        //     // {
        //     //     System.Console.WriteLine("ichkarida o'yna");
        //     // }
        // }

        // public static void Prob30()
        // {
        //     // var C = Console.ReadLine().Split().Select(int.Parse).ToList();

        //     // var a = C[0];
        //     // var b = C[1];

        //     // if(a*a==b)
        //     // {
        //     //     Console.WriteLine($"{a}*{a}={b}");
        //     // }
        //     // else{
        //     //     Console.WriteLine($"{b}*{b}={a}");
        //     // }

        // }

        // public static void Prob31()
        // {
        //     // var A = Console.ReadLine().Split().Select(int.Parse).ToList();

        //     // var a = A[0];
        //     // var b = A[0];
        //     // var c = A[0];
        //     // if(a > c && a >b)
        //     // {
        //     //     Console.WriteLine(a);
        //     // }
        //     // else if(b > a && b > c)
        //     // {
        //     //     Console.WriteLine(b);
        //     // }
        //     // else if(c > a && c > b)
        //     // {
        //     //     Console.WriteLine(c);
        //     // }
        // }

        // public static void Prob32()
        // {
        //     // var A = int.Parse(Console.ReadLine());
            
        //     // if(A % 2 == 0 && A % 3 == 0 && A % 5 == 0)
        //     // {
        //     //     System.Console.WriteLine("A");
        //     // }
        //     // else if(A % 2 == 0 && A % 3 == 0)
        //     // {
        //     //     System.Console.WriteLine("B");
        //     // }
        //     // else if(A % 2 == 0 && A % 5 == 0)
        //     // {
        //     //     System.Console.WriteLine("C");
        //     // }
        //     // else if(A % 3 == 0 && A % 5 == 0)
        //     // {
        //     //     System.Console.WriteLine("D");
        //     // }
        //     // else if(A % 2 == 0 || A % 3 == 0 || A % 5 == 0)
        //     // {
        //     //     System.Console.WriteLine("E");
        //     // }
        //     // else
        //     // {
        //     //     System.Console.WriteLine("N");
        //     // }
        // }
 
        // public static void Prob33()
        // {
        //     // var c = int.Parse(Console.ReadLine());

        //     // if(DateTime.IsLeapYear(c)){
        //     //     Console.WriteLine("1");
        //     // }
        //     // else {
        //     //     Console.WriteLine("0");
        //     // }
        // } 
    
        // public static void Prob34()
        // {
        //     // var N = int.Parse(Console.ReadLine());
        //     // var M = int.Parse(Console.ReadLine());

        //     // if(M == N){
        //     //     Console.WriteLine("YORVORDIZ");
        //     // }
        //     // else{
        //     //     if(N<M) {
        //     //         Console.WriteLine("PASTGA");
        //     //     }
        //     //     else {
        //     //         Console.WriteLine("TEPAGA");
        //     //     }
                
        //     //     M = int.Parse(Console.ReadLine());

        //     //     if(M==N){
        //     //         Console.WriteLine("YORVORDIZ");
        //     //     }
        //     //     else if(N>M){
        //     //         Console.WriteLine("TEGAPA");
        //     //     }
        //     //     else{
        //     //         Console.WriteLine("PASTGA");
        //     //     }
        //     // }
        // }

        // public static void Prob35()
        // {
        //     // var a = char.Parse(Console.ReadLine());

        //     // if(char.IsLower(a)){
        //     //     Console.WriteLine(char.ToUpper(a));
        //     // }
        //     // else if(char.IsUpper(a))
        //     // {
        //     //     Console.WriteLine(char.IsLower(a));
        //     // }

        // }

        // public static void Prob36()
        // {
        //     // int strike = 0, ball = 0;

        //     // var a = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        //     // var b = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        //     // if(b[0] == a[0]){
        //     //     strike++;
        //     // }
        //     // else if(b[0]==a[1] || b[0] == a[2]){
        //     //     ball++;
        //     // }
        //     // if(b[1] == a[1])
        //     // {
        //     //     strike++;
        //     // }
        //     // else if(b[1]==a[2] || b[1]==a[0]){
        //     //     ball++;
        //     // }
        //     // if(b[2]==a[2]){
        //     //     strike++;
        //     // }
        //     // else if(b[2]==a[0] || b[2]==a[1])
        //     // {
        //     //     ball++;
        //     // }
        //     // Console.WriteLine($"{strike}S{ball}B");
        // } 
    
        // public static void Prob37()
        // {
        //     // var a = int.Parse(Console.ReadLine());
        //     // var Q = char.Parse(Console.ReadLine());
        //     // var b = int.Parse(Console.ReadLine());
            
        //     // if(Q=='+'){
        //     //     Console.WriteLine($"{a+b}");
        //     // }
        //     // else 
        //     // {
        //     //     Console.WriteLine($"{a-b}");
        //     // }
        // }
   
        // public static void Prob38()
        // {
        //     // var n = int.Parse(Console.ReadLine());
        //     // var m = int.Parse(Console.ReadLine());

        //     // switch(n){
        //     //     case 1: Console.WriteLine($"Americano \n{(m-500)/500} {(m-500)%500/100}"); break;
        //     //     case 2: Console.WriteLine($"Caffe Latte \n{(m-400)/400} {(m-400)%500/100}");break;
        //     //     case 3: Console.WriteLine($"Lemon Tea \n{(m-400)/400} {(m-400)%500/100}"); break;
        //     // }
        // }
    
        // public static void Prob39()
        // {
        //     // var nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        //     // string res = new string ("false");
        //     // for(int i=0; i<1; i++){
        //     //     if(Math.Pow(nums[i], 2) + Math.Pow(nums[i+1], 2) == Math.Pow(nums[i+2], 2)){
        //     //         res = "true";
        //     //     }
        //     //     else if( Math.Pow(nums[i], 2) + Math.Pow(nums[i+2], 2) == Math.Pow(nums[i+1], 2))
        //     //     {
        //     //         res = "true";
        //     //     }
        //     //     else if(Math.Pow(nums[i+1], 2) + Math.Pow(nums[i+2], 2) == Math.Pow(nums[i], 2))
        //     //     {
        //     //         res = "true";
        //     //     }

        //     //     Console.WriteLine(res);
        //     // }
        // }
    
        // public static void Prob40()
        // {
        //     // int n = int.Parse(Console.ReadLine()), sum = 0;

        //     // var nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);

        //     // foreach(var num in nums)
        //     // {
        //     //     sum =+ (int)Math.Pow(num, 3);
        //     // }
        //     // Console.WriteLine(sum);
        // }
    
        // public static void Prob41()
        // {
        //     // long n = long.Parse(Console.ReadLine());

        //     // for(int i=1; ; i++){
        //     // if(n%i==0){
        //     //     n/=i;
        //     // }
        //     // else {
        //     //     break;
        //     // }
        //     // }
            
        //     // if(n==1){
        //     //     Console.WriteLine("true");
        //     // }
        //     // else {
        //     //     Console.WriteLine("false");
        //     // }
        // }
    
        // public static void Prob42()
        // {
        //     long n = long.Parse(Console.ReadLine());

        //     for(long i=n; ; i++)
        //     {
        //         bool tubmi = true;
        //         for(long j=2; j <= Math.Sqrt(i) ; j++)
        //         {
        //             if(i%j==0)
        //             {
        //                 tubmi = false;
        //                 break;
        //             }
        //         }

        //         if(tubmi == true)
        //         {
        //             Console.WriteLine(i);
        //             break;
        //         }
        //     }
        // }
    
        public static void Prob43()
        {
            
        }
    }

        
    
}