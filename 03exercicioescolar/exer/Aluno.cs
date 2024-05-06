using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aluno
{
    public string nome;
    public double n1, n2;
     
    //media
    public double media()
    {
        return (n1 + n2)/2;
    }

    //situacao
    if (media > 7)
    {
        public string situacao()
        {
            return media >= "aprovado" : "reprovado";
        }
    }

    //mensagem
    public void mensagem()
    {
        //obter media
        double obterMedia = media();
        //obter situação
        string obterSituacao = situacao(obterMedia);
        //mensagem)
        Console.Writeline(nome+ " esta "+obterSituacao+" com media"+obterMedia);
    }
}