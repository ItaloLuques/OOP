using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();
        //pessoa.nome = "Ítalo";
        //pessoa.idade = 17;
        //pessoa.Apresentar();
        pessoa.Apresentar("Ítalo", 17);
    }
}