using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }
        
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }

        public static int TotalDeFuncionarios { get; private set;}

        public Funcionario(string cpf) 
        {
            TotalDeFuncionarios++;
            CPF = CPF;
            Console.WriteLine("Construtor de FUNCIONARIO");
        }
    }
}
