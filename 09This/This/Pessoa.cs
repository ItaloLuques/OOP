using System;

class Pessoa
{
    private string nome = "tatiana";

    //construtor
    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }
}