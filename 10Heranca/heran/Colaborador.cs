using System;

class Colaborador : Pessoa
{
    private double salario;
    //construtor
    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;
        
        mensagemPessoa();
        mensagemColaborador();
    }
    //metodo
    private void mensagemColaborador()
    {
        Console.WriteLine("salario: "+salario);
    }

}