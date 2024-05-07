/*Abstração
-é uma classe que pode conter metodos obrigratorios
para todas as classes que a herdarem;
-é possivel criar metodos convencionais(nao obrigatorios)
,para que as classes que herdem consigam utilizar;
-nao é possivel instanciar uma classe abstrata. exemplo: 
Produto prod = new Produto();
-padrao utilizado em projetos com muitos desenvolvedores,
pois garante uma estrtutura pre-moldada com ações que podem
ser realizadas;
-como é utilizada a herança, cada classe poder herdar apenas
uma classe abstrata:

class Produto : PadraoProduto >ok
class PadraoProduto, CalculoImpostos >erro
