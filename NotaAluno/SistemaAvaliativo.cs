using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NotaAluno
{
    internal class SistemaAvaliativo
    {
        public string Nome;
        public double N1, N2, N3;
        public double NotaFinal()
        {
            return N1 + N2 + N3;
        }
        public bool Aprovado()
        {
            if (NotaFinal()>=60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SituacaoAluno()
        {
            if (NotaFinal()>=60)
            {
                Console.WriteLine("Você foi aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine($"Falta {60.0 - NotaFinal()}");
            }
        }
    }
}
