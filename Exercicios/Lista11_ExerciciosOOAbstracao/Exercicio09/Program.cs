/*9 -
a) Crie uma classe base "Pessoa" com propriedades como "Nome" e "Idade." 
b) Crie uma classe derivada "Estudante" que herde de "Pessoa" e adicione propriedades específicas, como "Matricula" e "Curso."
c) Certifique-se de que a classe derivada chame o construtor da classe base
*/
namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudante e1 = new Estudante("Gabriel",23,"1232443233","SI");


        }
    }
}