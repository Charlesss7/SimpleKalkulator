using System;

namespace Kalkulator
{
    class Program
    {
        //Method, Math.Round -> handle angka desimal
        
        static void Addition(float num1,float num2){
            float result;
            result = num1+num2;
            Console.WriteLine("Result of Addition : {0}",Math.Round(result,3));
        }
        static void Substraction(float num1,float num2){
            float result;
            result = num1-num2;        
            Console.WriteLine("Result of Substraction : {0}",Math.Round(result,3));
        }
        static void Multiplication(float num1,float num2){
            float result;
            result = num1*num2;
            Console.WriteLine("Result of Multiplication : {0}",Math.Round(result,3));
        }
        static void Division(float num1,float num2){
            float result;
            result = num1/num2;
            Console.WriteLine("Result of Division : {0}",Math.Round(result,3));
        }
        static void Main(string[] args)
        {
            int choice;         //pilihan user
            float num1,num2;    // jika user input desimal & bil bulat
            do{
                //Clean Console Log
                Console.Clear();

                //Tampilan Awal
                Console.WriteLine("Enter the action to be performed");
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("Press 2 for Substraction");
                Console.WriteLine("Press 3 for Multiplication");
                Console.WriteLine("Press 4 for Division");

                //Input User - Milih
                Console.Write("Choose : ");
                choice = Convert.ToInt32(Console.ReadLine());

                //Input User - Angka 1 dan Angka 2
                Console.Write("Enter 1st input :");
                num1 = float.Parse(Console.ReadLine());

                Console.Write("Enter 2nd input :");
                num2 = float.Parse(Console.ReadLine());
                
                //Switch CASES
                switch(choice)
                {
                    case 1:
                        Addition(num1,num2);
                        break;
                    case 2:
                        Substraction(num1,num2);
                        break;
                    case 3:
                        Multiplication(num1,num2);
                        break;
                    case 4:
                        Division(num1,num2);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }     

                //Repeat
                Console.Write("Try Again (y/n)? : ") ;
            }while(Console.ReadKey().Key == ConsoleKey.Y);
        }
    }
}

