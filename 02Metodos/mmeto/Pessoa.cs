using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Pessoa
{
    //metodo1
    public void Apresentar()
    {
        Console.WriteLine("ola");
    }
    //metodo2
    public void Apresentar(string nome)
    {
        
        Console.WriteLine("ola "+nome);
    }
    //metodo3
    public void Apresentar(string nome, int idade)
    {
        
        Console.WriteLine("ola "+nome+" voce tem "+idade+" anos ");
    }
}