using System;

abstract class Padrao
{
    //metodos
    //1 obrigatorio
    public abstract void taxaEmprestimo(double valor);

    //opcional
    public void calculoPoupancao(double valor, double taxa)
    {
        Console.WriteLine("ganhos obtidos pela poupança $"+(valor*taxa));
    }
}