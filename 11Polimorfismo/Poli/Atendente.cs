using System;

class Atendente : Imposto
{
    //override = quer dizer que esta alterando um metodo
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("desconto atendente do vale alimentaçao $"+(salario*0.12));
    }
}