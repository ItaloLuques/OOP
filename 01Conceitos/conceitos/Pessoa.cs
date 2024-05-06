using System;

class Pessoa
{
    public string Nome;
    public int Idade;

    public void mensagem()
    {
        Console.WriteLine("ola "+Nome+" voce tem "+Idade+" anos");
    }
}