using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio08
{
    public class Espanhol
    {
        public void calcularMediaAluno(double nota1, double nota2, double nota3) {
            double media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("A média do aluno é: " + media);
        }
    }
}