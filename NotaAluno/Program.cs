using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SistemaAvaliativo A;
            A = new SistemaAvaliativo();
            Console.Write("Nome do aluno: ");
            Console.WriteLine("Digite as notas: ");
            A.N1 = double.Parse(Console.ReadLine());
            A.N2 = double.Parse(Console.ReadLine());
            A.N3 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Nota final = {A.NotaFinal()}");
            A.SituacaoAluno();
            Console.ReadLine();
        }
    }
}
