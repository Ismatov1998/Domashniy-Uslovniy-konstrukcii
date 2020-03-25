using System;

namespace farukh
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////N-2
            Console.WriteLine(" Задания второе ");
            int a,b;
            Console.WriteLine("Введите первое число");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b=Convert.ToInt32(Console.ReadLine());
            if(a!=b)
            {
             Console.WriteLine("///////");
             Console.WriteLine(a+1);
             Console.WriteLine(b+1);
            }
             else
             {
                b=0;
                a=0;
              Console.WriteLine("///////");
              Console.WriteLine(a);
              Console.WriteLine(b);   
             } 
            Console.WriteLine("Задания-3");
            ///////////N--3
            double operand1,operand2;
            string sign;
            Console.WriteLine(" Задайте первое число");
            operand1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Задайте второе число");
            operand2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Задайте первое число");
            Console.WriteLine("Какую операцию хотите выполнить");
            sign=Console.ReadLine();
            switch(sign)
            {
                case "+": 
                {
                 Console.WriteLine(operand1+operand2);
                 break;
                }
                 case "-": 
                {
                 Console.WriteLine(operand1-operand2);
                 break;
                }
                 case "*": 
                {
                 Console.WriteLine(operand1*operand2);
                 break;
                }
                 case "/": 
                {
                 if(operand2!=0)
                 {
                 Console.WriteLine(operand1/operand2);
                 break;
                 }
                 else
                 Console.WriteLine("на ноль делить нельзя");
                 break;                  
                }
                // Console.WriteLine($"Результат = {a}");
                

            }
            //////////N-4
            Console.WriteLine("Задания 4");
            int a1;
            Console.WriteLine("Введите число");
            a1=Convert.ToInt32(Console.ReadLine());
            if(a1>=0 && a1<=14)
            {
              Console.WriteLine("[0,14]");
            }
              if(a1>=15 && a1<=35)
            {
              Console.WriteLine("[15,35]");
   
            }                
              if(a1>=36 && a1<=50)
            {
              Console.WriteLine("[36,50]");
            }     
              if(a1>=51 && a1<=100)
            {
              Console.WriteLine("[51,10012]");
   
            }  
             if(a1>100 || a1<0)
            {
                Console.WriteLine("Не принадлежить не одному из этих интервалов");
            }   


            
        }  
    }
}
