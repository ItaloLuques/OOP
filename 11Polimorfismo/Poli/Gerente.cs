using System;

class Gerente : Imposto
{   
    //override = quer dizer q esta alterando um metodo
    //metodos
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("desconto gerente do vale alimentaçao $"+(salario*0.15));
    }
}