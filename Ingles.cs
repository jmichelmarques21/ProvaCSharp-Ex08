using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio08
{
    public class Ingles : Curso
    {


        public void gerarCertificado(){
            if (this.nivel == "Básico") {
                System.Console.WriteLine("O aluno concluiu com sucesso o curso de Inglês nível Básico");
            } else if (this.nivel == "Intermediário") {
                System.Console.WriteLine("O aluno concluiu com sucesso o curso de Inglês nível Intermediário"); 
            } else {
                System.Console.WriteLine("O aluno concluiu com sucesso o curso de Inglês nível Avançado");
            }
        }
    }
}