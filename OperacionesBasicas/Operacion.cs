using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesBasicas
{
   
    public class Operacion
    {
        public Operacion()
        {
           calculadora();
        }
        public void calculadora()
        {
            int s1, s2, r;
            Console.Write("Ingresa el numero a sumar:");
            s1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el  segundo numero a sumar:");
            s2 = int.Parse(Console.ReadLine());
            r = s1 + s2;
            Console.WriteLine("Resultado:" + r);
            
            int r1, r2, t;
            Console.Write("Ingresa el numero a restar:");
            r1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el  segundo numero a restar:");
            r2 = int.Parse(Console.ReadLine());
            t = r1 - r2;
            Console.WriteLine("Resultado:" + t);

            int d1, d2, rt;
            Console.Write("Ingresa el numero a dividir:");
            d1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el  segundo numero a dividir:");
            d2 = int.Parse(Console.ReadLine());
            rt = d1/d2;
            Console.WriteLine("Resultado:" + rt);

            int m1, m2, rtt;
            Console.Write("Ingresa el numero a multiplicarr:");
            m1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el  segundo numero a multiplicar:");
            m2 = int.Parse(Console.ReadLine());
            rtt = m1 * m2;
            Console.WriteLine("Resultado de la multiplicacion:" + rtt);


            Console.ReadKey();
        }
       
    }
}
