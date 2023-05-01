using System;

namespace Julianavaibaternomaycon
{
    public class Program
    {
        public static int  idadeJu ;
        public static string nomeJu;
        public static double idadeJu2;
        public static float valor;
        static void Main(string[] args)
        {
            

            nomeJu = Console.ReadLine();

           // Console.WriteLine("O nome da pessoa informada é "+ nomeJu);

            //Console.WriteLine("Informe a idade da pessoa ");

            //idadeJu = Convert.ToInt32(Console.ReadLine());

            //.WriteLine("A idade que voce informou é " + idadeJu);


            Console.WriteLine("Pergunta a idade novamente ");
            idadeJu2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Por favor, informe o nome da pessoa!");
            Console.WriteLine("A idade que você informou é " + idadeJu2);

           
        }
    }
}


