using System;

class PessoaJuridica :Padrao
{
    //metodo obrigatorio
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("taxa para pessoa juridica $"+(valor*0.2));
    }
}