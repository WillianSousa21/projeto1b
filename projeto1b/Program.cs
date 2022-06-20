using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1b
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            //cria locação de espaço na memoria para armazenar os dados do tipo pessoa
            pessoa aluno;

            //criação do objeto orientado
            aluno = new pessoa();

            //variação de uso
            pessoa professor = new pessoa();

            //uso do objeto em branco 
            aluno.nome = "Igor";
            professor.nome = "Prof. Welt";

            //mostra o determinado uso
            Console.WriteLine("Professor:" + professor.nome);
            Console.WriteLine("Aluno:" + aluno.nome);
            Console.ReadKey();

        

        }
    }
}
