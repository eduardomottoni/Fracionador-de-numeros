using System;
using System.Runtime;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;


namespace QuebraNum
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {

                Console.WriteLine("Digite um número");
                int numero = Convert.ToInt32(Console.ReadLine()); // recebe o numero
                List<int[]> resultado = new List<int[]>();
                resultado = Quebra(numero);
                

                resultado = CompararListas(resultado);
                resultado = resultado.OrderByDescending(x => x.First()).ToList();
                foreach (var item in resultado)
                {

                    Console.WriteLine("[{0}]", string.Join(", ", item));
                    
                }

            }
        }

        private static List<int[]> CompararListas(List<int[]> resultado)
        {
            List<int[]> transitor = new List<int[]>(resultado);
            foreach (var item in resultado)
            {
                int i = 0;
                foreach (var subitem in resultado)
                {

                    if (item.SequenceEqual(subitem))
                    {
                        i++;
                    }
                    if (i > 1)
                    {
                        transitor.Remove(subitem);
                        i--;
                    }
                }
            }
            return transitor;
        }

        public static List<int[]> Quebra(int quebrado)
        {
            List<int[]> resultado = new List<int[]>();
            int media = GetMedia(quebrado);
            List<int> intermed = new List<int>();
            List<int[]> resultadomed = new List<int[]>();
            int iterador = quebrado - 1;
            for (int i = 1; i <= iterador; i++)
            {
                int segundo = quebrado - i;
                if (false)
                { }
                else
                {
                    intermed.Add(segundo);
                    intermed.Add(i);
                    resultado.Add(intermed.ToArray());
                    intermed.Clear();
                    if(i>1)
                    {
                        resultadomed = Quebra(i);
                        foreach (var item in resultadomed)
                        {
                            intermed.Clear();
                            intermed.Add(segundo);
                            foreach (var num in item)
                            {
                                intermed.Add(num);
                                
                               
                            }
                            resultado.Add(intermed.ToArray());

                        }
                        intermed.Clear();
                        
                        

                    }

                    

                }
               
                

            }

            //resultado = resultado.Distinct().ToList();

            foreach (var item in resultado)
            {

                Array.Sort<int>(item,
                    new Comparison<int>(
                            (i1, i2) => i2.CompareTo(i1)
                    ));
            }
            //resultado = resultado.OrderByDescending(x => x.Last()).ToList();
            resultado = CompararListas(resultado);
            return resultado;
        }
        public static int GetMedia(int quebra)
        {
            return Convert.ToInt32(Math.Ceiling(Convert.ToDouble(quebra) / 2));
        }

    }
}
