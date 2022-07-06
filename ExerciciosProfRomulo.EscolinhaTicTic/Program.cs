using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.EscolinhaTicTic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Exercício 4- Crie um programa para a escolinha Tic Tic
               calcular 3 notas de um aluno.
               Entrar com o nome do aluno e as três notas
               Mostrar a soma das notas e a média.
            */

            string nomeAluno, resultado;
            double nota1;
            double nota2;
            double nota3;
            double somaNota;
            double mediaNota; 

            Console.WriteLine("Nome aluno");
            nomeAluno = Console.ReadLine();

            Console.WriteLine("Qual a sua nota 1?");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a sua nota 2?");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a sua nota 3?");
            nota3 = double.Parse(Console.ReadLine());

            
            somaNota = (nota1 + nota2 + nota3);
            mediaNota = somaNota / 3;
            resultado = mediaNota >= 7 ? "Aprovado" : "Reprovado";

            Console.WriteLine($"O(a) {nomeAluno} com as notas: {nota1.ToString().Substring(0,Convert.ToInt64(nota1).ToString().Length + 3)}, {nota2.ToString("F")}, {nota3} ficou com a média {mediaNota}. ");

            if (mediaNota >=7) 
            {
                Console.WriteLine($"Você foi {resultado}. Parabéns!!");
            }
            else
            {
                Console.WriteLine($"Você foi {resultado}. Se esforce mais da próxima vez!!");
            }

                Console.ReadKey();
        }
    }
}
