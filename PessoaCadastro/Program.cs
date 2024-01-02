using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PessoaCadastro.Classe.Masculino;
using PessoaCadastro.Classe.Feminino;
using System.Globalization;

namespace PessoaCadastro
{
    class Program
    {
        //Programação Orientação ao Objeto
        //Aplicação, Cadastro de pessoa, masculino e feminino
        //Inserindo dados, tipo string int, double 
        //Inserindo dados, Cadastro de pessoas,
        //usando classe e subclasses
        //Data: 25/12/2023
        //Jonas Valereo -Técnico em Informática
        static void Main(string[] args)
        {
            //instanciando, declarando o objeto masculino da classe masculino
            Masculino masculino = new Masculino();

            /*declarando o codigo entrada de dado no console,
            declarando e acessando as propriedades da classe masculino*/
            Console.WriteLine();
            Console.WriteLine("BEM VINDOS AO SISTEMA DE CADASTRO DE PESSOAS");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Faça o cadastro de pessoa masculina");
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: ");
            masculino.Nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite seu sobrenome: ");
            masculino.Sobrenome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite sua idade: ");
            masculino.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite seu sexo: ");
            masculino.Sexo = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite seu peso: ");
            masculino.Peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            Console.WriteLine();
            Console.WriteLine("Digite seu celular: ");
            masculino.Celular = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite seu estado: ");
            masculino.Estado = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite seu pais: ");
            masculino.Pais = Console.ReadLine();

            //instanciando, declarando o objeto feminino da classe feminino
            Feminino feminino = new Feminino();

            /*declarando o codigo entrada de dado no console,
            declarando e acessando as propriedades da classe feminino*/
            Console.WriteLine();
            Console.WriteLine("BEM VINDOS AO SISTEMA DE CADASTRO DE PESSOAS");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Faça o cadastro de pessoa feminino");
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: ");
            feminino.Nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite seu sobrenome: ");
            feminino.Sobrenome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite sua idade: ");
            feminino.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite seu sexo: ");
            feminino.Sexo = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite seu peso: ");
            feminino.Peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Digite seu celular: ");
            feminino.Celular = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite seu estado: ");
            feminino.Estado = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite seu pais: ");
            feminino.Pais = Console.ReadLine();

            /*declarando, imprimir saida de dados console, chamando o objeto 
            masculino,
            chamando o método toString da classe masculino*/
            Console.WriteLine();
            Console.WriteLine("RESULTADO DO CADASTRO MASCULINO");
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine(masculino.ToString());

            /*declarando, imprimir saida de dados console, chamando o objeto 
           feminino,
           chamando o método toString da classe feminino*/
            Console.WriteLine();
            Console.WriteLine("RESULTADO DO CADASTRO FEMININO");
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine(feminino.ToString());

            Console.ReadKey();
        }
        //fim da aplicação cadastro de pessoas
    }
}