using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set;}

        public Funcionario(double salario, string cpf) 
        {
            Console.WriteLine("Criando um Funcionário");
            TotalDeFuncionarios++;
            CPF = cpf;
            Salario = salario;
            
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
    }
}
