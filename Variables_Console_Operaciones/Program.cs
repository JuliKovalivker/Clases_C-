using System;

namespace Variables_Console_Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            string palabra = "hola";
            float num2 = 0.5f;;
            char letra = 'a';
            bool estado = true;

            int suma = 1 + 1;        // 2
            int resta = 1 - 1;       // 0
            int multi = 1 * 3;       // 3
            int divi = 4 / 2;        // 2
            float divif =  5f / 2f;  // 2.5
            int modulo = 5 % 2;      // 1
            int potencia = 5 ^ 2;    // 25
            int raiz = 25 ^ (1/2);   // 5
            int div_entera = 5 / 2;  // 2

        
            string frase = "Hola" + "mundo";             // Holamundo
            string frase2 = "Hola" + "" + "mundo";       // Hola mundo
            string frase3 = "Hola " + "mundo";           // Hola mundo
            string numeros = "1" + "2";                  // 12
            string letras_y_mas = "a" + 1 + "3" + "+";   // a13+

            
            // Console.WriteLine("Hola Mundo!");
            // Console.WriteLine(frase3 + "!");
            // Console.WriteLine(raiz);
            // Console.WriteLine(raiz + 4);
            // Console.WriteLine(estado);
            // Console.WriteLine("Tengo " + numeros + " años");
    

            bool igualdad = 5 == 5;          // True
            bool mayor = 5 > 4;              // True
            bool menor = 5 < 4;              // False
            bool mayor_igual = 5 >= 5;       // True
            bool menor_igual = 5 <= 3;       // False
            bool diferente = 5 != 5;         // False
            bool negacion = !false;          // True
            bool and = true && false;        // False
            bool or = true || false;         // True
        
            //string nombre = Console.ReadLine();
            //Console.WriteLine("Hola " + nombre);

            //int edad = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Tengo " + edad + " años");

            bool cero = Convert.ToBoolean(0);
            bool uno = Convert.ToBoolean(523);
            //Console.WriteLine(Convert.ToString(uno));
         
        }
    }
}