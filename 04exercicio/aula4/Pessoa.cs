using System;


class Pessoa
{
    public double peso, altura;

    public double calculo()
    {
        return peso / (altura * altura)
    }
    //situacao
    public string situacao(double imc)
    {
        //variavel
        string retorno;
        //condicionais
        if(imc<18.5)
        {
            retorno = "abaixo do peso";
        }
        else if(imc<25)
        {
            retorno="peso normal";
        }
        else if(imc<30)
        {
            retorno="acima do peso";
        }
        else if(imc<35)
        {
            retorno="obesidade 1";
        }
        else if(imc<40)
        {
            retorno="obesidade 2";
        }
        else 
        {
            retorno = "obesidade 3";
        }
        return retorno;
        
        //mensagem
        void mensagem()
        {
            //obter calculo
            double obterCalculo = calculo();
            //obter situcacao
            string obterSituacao = situacao(obterCalculo);
            //exibir mensagem
            Console.WriteLine("seu imc é de "+obterCalculo);
            Console.WriteLine("sua situação e de "+obterSituacao);
        }
    }
}