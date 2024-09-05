using System;
using System.Collections.Generic; 

namespace Arrays_Diccionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letras = {"a", "b", "c"};
            int[] nums = {1, 2, 3};
            float[] floats =  {1.1f, 2.2f, 3.3f};
            bool[] bools = {true, false, true};

            // Console.WriteLine(letras);
            // Console.WriteLine(letras[0]);
            // Console.WriteLine(nums[0]);
            // Console.WriteLine(floats[0]);
            // Console.WriteLine(bools[0]);
            
            // int longitud = "abcde".Length;
            // Console.WriteLine(longitud);
            // longitud = letras.Length;
            // Console.WriteLine(longitud);

            for (int i = 0; i < letras.Length; i++){
                // Console.WriteLine("letras[" + i + "] = " + letras[i]);
            }

            foreach (string item in letras){
                // Console.WriteLine(item);
            }

            Dictionary<string, int> meses =  new Dictionary<string, int>(); 
            meses.Add("Enero", 01);
            meses.Add("Febrero", 02);
            meses.Add("Marzo", 03);
            // Console.WriteLine(meses);
            // Console.WriteLine(meses["Enero"]);
            meses.Remove("Febrero");
            foreach(KeyValuePair<string, int> elem in meses){
                // Console.WriteLine(elem.Key);
            }

            Dictionary<string, int> peliculas = new Dictionary<string, int>
            {
                {"Harry Potter", 8},
                {"The Hunger Games", 5},
                {"Star Wars", 6}
            };
            // Console.WriteLine(peliculas["Star Wars"]);

            foreach(KeyValuePair<string, int> elem in peliculas){
                // Console.WriteLine(elem.Key + ": " + elem.Value);
            }

        }
    }
}