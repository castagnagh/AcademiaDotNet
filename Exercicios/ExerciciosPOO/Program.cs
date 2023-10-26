/*Crie uma classe chamada Pessoa com seus atributos conforme sua preferência(Nome, CPF, data de nascimento, RG etc).
• Crie métodos para cadastrar e apresentar na tela os dados desta classe.*/

namespace ExerciciosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.CadastrarPessoa();
            p.ApresentarDados();
        }
    }
}