using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            static void HelloWord1(){
                Console.WriteLine("Hello World");
            }

            static string HelloWorld2(){
                return "Hello World";
            }
    
            static int Suma(int num1, int num2){
                return num1 + num2;
            }
  
            Console.WriteLine(Suma(2, 5));
            Console.WriteLine(Suma(2, 5) + 4);
        
            static bool Funcion3(){
                return true;
            }

            static string[] GetNames(){
                string[] ret = { "Matthew", "Mark", "Luke", "John" };
                return ret;
            }

            Console.WriteLine(GetNames()[0]);
                
            static string Funcion4(string palabra){
                return palabra;
            }
            static string Funcion5(){
                return Funcion4("wop");
            }

            //Console.WriteLine(Funcion5());
    
        }
    }
}
