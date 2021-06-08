using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }

        public Diretor(string cpf) : base(string cpf) 
        {
            Console.WriteLine("construtor de DIRETOR");
        }
    }
}
