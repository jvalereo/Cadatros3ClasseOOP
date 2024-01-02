using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PessoaCadastro.Classe.Feminino
{
    //Programação Orientação ao Objeto
    //Aplicação, Cadastro de pessoa, masculino e feminino
    //Inserindo dados, tipo string int, double 
    //Inserindo dados, Cadastro de pessoas,
    //usando classe e subclasses
    //Data: 25/12/2023
    //Jonas Valereo -Técnico em Informática
    class Feminino : Pessoa
    {
        /*declarando os attributos da classe masculino,
        tipo string, int, double, private*/
        private double _peso;
        private string _celular;
        private string _estado;
        private string _pais;

        //declarando o construtor e passando parametros da class feminino
        public Feminino(string nome, string sobrenome, int idade, string sexo,
            double peso, string celular, string estado, string pais) 
            : base(nome,sobrenome,idade,sexo)
        {
            _nome = nome;
            _sobrenome = sobrenome;
            _idade = idade;
            _sexo = sexo;
            _peso = peso;
            _celular = celular;
            _estado = estado;
            _pais = pais; 
        }
        //declarando o construtor padrão da class feminino
        public Feminino()
        {

        }
        //declarando propriedade, get e se da class feminino
        //propriedade get e set

        //propriedade Nome get e set
        public string Nome
        {
            get { return _nome; }
            set { _nome = value;  }
        }
        //propriedade Sobrenome get e set
        public string Sobrenome
        {
            get { return _sobrenome; }
            set { _sobrenome = value; }
        }
        //propriedade Idade get e set
        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }
        //propriedade Sexo get e set
        public string Sexo
        {
            get { return _sexo;  }
            set { _sexo = value;  }
        }
        //propriedade Sexo get e set
        public double Peso
        {
            get { return _peso;  }
            set { _peso = value;  }
        }
        //propriedade Celular get e set
        public string Celular
        {
            get { return _celular;  }
            set { _celular = value; }
        }
        //propriedade Estado get e set
        public string Estado
        {
            get { return _estado;  }
            set { _estado = value;  }
        }
        //propriedade Pais get e set
        public string Pais
        {
            get { return _pais;  }
            set { _pais = value;  }
        }
        //declarando o método Dados da class feminio
        public string DadosF()
        {
            //criando uma instância de um objeto f StringBuilder
            StringBuilder f = new StringBuilder();

            f.AppendLine();
            f.AppendLine("Nome = " + Nome + " " + Sobrenome);
            f.AppendLine("Idade = " + Idade + " anos");
            f.AppendLine("Sexo =  " + Sexo);
            f.AppendLine("Peso = " + Peso.ToString("F2", CultureInfo.InvariantCulture) + " Kg");
            f.AppendLine("Celular =  " + Celular);
            f.AppendLine("Estado = " + Estado);
            f.AppendLine("Pais = " + Pais);

            return f.ToString();
        }
        //declarando modificador objeto da class feminino, para tipo string
        public override string ToString()
        {
            return DadosF().ToString();
        }
        //fim da class feminio
    }
}