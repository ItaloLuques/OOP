using System;

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa= new Pessoa();
        pessoa.Nome = "Ítalo";
        pessoa.Idade = 17;
        pessoa.mensagem();

        Carro carro= new Carro();
        carro.Marca="Ram";
        carro.ano = "2024";
        carro.Modelo = "dodge RAm";
        carro.mensagem2();
    }
}