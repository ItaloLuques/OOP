uisng System;

class PessoaFisica : Padrao
{
    //metodo obrigatorio
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("taxa para pessoa fisica $"+(valor*0.1));
    }

}