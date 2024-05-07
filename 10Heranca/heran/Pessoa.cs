using System;

class Pessoa
{
    protected string nome;
    protected int idade;

    //metodo0
    protected void mensagemPessoa()
    {
        Console.WriteLine("nome: "+nome);
        Console.WriteLine("idade: "+idade);
    }
}