using System;
using System.Globalization;
using System.Xml;
namespace exeAlunoClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno A;
            A = new Aluno();


            Console.WriteLine("Nome do aluno: ");
            Console.ReadLine();


            Console.WriteLine("Digite as três notas do aluno: ");
            A.X = double.Parse(Console.ReadLine());
            A.Y = double.Parse(Console.ReadLine());
            A.Z = double.Parse(Console.ReadLine());


            double Nota = A.X + A.Y + A.Z;
            Console.WriteLine("Nota Final: " + Nota.ToString("F2", CultureInfo.InvariantCulture));


            double NotaFinal = A.NotaFinal();

            if (NotaFinal < 60.00)
            {
                Console.WriteLine("!Reprovado!");
            }
            else 
            {
               Console.WriteLine("Aprovado"); 
            }

            double Resto = A.Resto();
            Console.WriteLine("Faltaram " + Resto.ToString("F2", CultureInfo.InvariantCulture) + " Pontos");
            
        }
    }
}