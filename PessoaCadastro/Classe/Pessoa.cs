using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaCadastro.Classe
{
    //Programação Orientação ao Objeto
    //Aplicação, Cadastro de pessoa, masculino e feminino
    //Inserindo dados, tipo string int, double 
    //Inserindo dados, Cadastro de pessoas,
    //usando classe e subclasses
    //Data: 25/12/2023
    //Jonas Valereo -Técnico em Informática
    class Pessoa
    {
        /*declarando os attributos de classe pessoa,
         tipo string, int, double, protected*/
        protected string _nome;
        protected string _sobrenome;
        protected int _idade;
        protected string _sexo;

        //declarando o construtor e passando paramentros da class pessoa
        public Pessoa(string nome, string sobrenome, int idade, string sexo)
        {
            _nome = nome;
            _sobrenome = sobrenome;
            _idade = idade;
            _sexo = sexo;
        }
        //declarando o construtor padrão da class pessoa
        public Pessoa()
        {

        }
        //fim da class pessoa
    }
}