/*Interface
-utilizada para criar exclusivamente metodos obrigatorios;
-uma classe pode implementar varias interfaces;
-os metodos da interface nao contem calculos, condicionais,
laços e demais açoes;
double calculo(double numero);
string text();
void mensagem(string nome, int idade);
-no c# por padrao um metodo criado na interface é abstrato
e publico;
-nas boas praticas do c#, toda interface tem a inicial I,
em seguida do nome da interface:
IPadrao
ICalculo
IConsulta
IAcoes