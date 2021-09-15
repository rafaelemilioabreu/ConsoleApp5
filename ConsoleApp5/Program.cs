using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> listaNUmeros = new List<int>();

             bool EncontrarNumeroPar(int numero)
            {

                if (numero%2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


          
            List<int> Pares(List<int> lista)
            {
                List<int> listaPares = lista.FindAll(EncontrarNumeroPar);
                

                return listaPares;
            }


            /*public bool EsImpar(int x){
                 if (x % 2 != 0){
                    return true;
                else{
                return false;
         }
        }
*/
            Func<int, bool> EsImpar = x => x % 2 != 0;
            


            /*public double CalcularITBIS(double precio){
                var itebis = precio * 0.18;
                return itebis;
}*/


            Func<double, double> CalcularITBIS = itbis => itbis * 0.18;





  


        }
    }
}
