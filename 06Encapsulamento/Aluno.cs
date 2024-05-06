using System;

class Aluno
{
    private double nota1, nota2;

    //media
    private double media()
    {
        return (nota1 + nota2) / 2;
    }   
    //mensagem
    public void mensagem()
    {
        Console.WriteLine("informe a nota 1");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("informe a nota 2");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("A media é "+media());
    }
    
}