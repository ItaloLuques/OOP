using System;

class Imposto
{
    //virtual = quer dizer q esse metodo pode sofrer alterações
    //metodos
    public virtual void valeAlimentacao(double salario)
    {
        Console.WriteLine("desconto padrao do vale alimentacao $"+(salario*0.1));
    }
    public virtual void valeTransporte(double salario)
    {
        Console.WriteLine("desconto padrao do vale transporte $"+(salario*0.06));
    }
}